using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AcamTi.KeyboardShortcutManager.KeyLogging;

namespace AcamTi.KeyboardShortcutManager.Forms
{
    public partial class SettingsForm : Form
    {
        private readonly Settings _settings;
        private ActionDefinitionForm _actionDefinitionForm;
        private KeyShortcutDetector _keyDetector;
        public Action<Settings> OnSettingsUpdated;

        public SettingsForm(Settings settings)
        {
            _settings = settings;

            InitializeComponent();
            DisplayKeyShortcut();

            PrepareListOfActions();
        }

        private void PrepareListOfActions()
        {
            lstActionDefinitions.Items.Clear();

            _settings.ActionDefinitions.Select(
                    action => new ListViewItem
                    {
                        Text = action.Name,
                        SubItems =
                        {
                            string.Join(" + ", action.Shortcut),
                            action.Content
                        },
                        Tag = action
                    }
                )
                .ToList()
                .ForEach(
                    item => { lstActionDefinitions.Items.Add(item); }
                );
        }

        private void DisplayKeyShortcut()
        {
            lblShortcut.Text = string.Join(" + ", _settings.KeyShortcutActivator);
        }

        private void btnSetShortcut_Click(object sender, EventArgs e)
        {
            _settings.KeyShortcutActivator.Clear();
            lblShortcut.Text = string.Empty;

            _keyDetector = KeyShortcutDetector.InitService(OnShortcutDetected);
        }

        private void OnShortcutDetected(IEnumerable<Keys> keys)
        {
            _keyDetector?.Dispose();
            _keyDetector = null;

            _settings.KeyShortcutActivator = new List<Keys>(keys);
            OnSettingsUpdated(_settings);

            lblShortcut.Invoke(
                new MethodInvoker(DisplayKeyShortcut)
            );
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _keyDetector?.Dispose();
            _keyDetector = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _actionDefinitionForm = new ActionDefinitionForm(new ActionDefinition(), ActionDefinitionValidator);

            _actionDefinitionForm.OnSave += actionDefinition =>
            {
                _settings.ActionDefinitions.Add(actionDefinition);
                PrepareListOfActions();
            };

            Hide();
            _actionDefinitionForm.ShowDialog();
            Show();
        }

        private bool ActionDefinitionValidator(ActionDefinition itemToValidate)
        {
            if (_settings.ActionDefinitions.Any(item => item.Id == itemToValidate.Id))
            {
                return _settings.ActionDefinitions
                    .Where(i => i.Id != itemToValidate.Id)
                    .All(item => IsKeyCombinaisonDifferent(item, itemToValidate));
            }

            return _settings.ActionDefinitions
                .All(item => IsKeyCombinaisonDifferent(item, itemToValidate));
        }

        private static bool IsKeyCombinaisonDifferent(ActionDefinition actionDefinition1,
            ActionDefinition actionDefinition2)
        {
            var valid = false;
            Keys[] shortcutList1;
            Keys[] shortcutList2;

            if (actionDefinition1.Shortcut.Count() > actionDefinition2.Shortcut.Count())
            {
                shortcutList1 = actionDefinition1.Shortcut.ToArray();
                shortcutList2 = actionDefinition2.Shortcut.ToArray();
            }
            else
            {
                shortcutList1 = actionDefinition2.Shortcut.ToArray();
                shortcutList2 = actionDefinition1.Shortcut.ToArray();
            }

            foreach (Keys key in shortcutList1)
            {
                if (shortcutList2.All(k => k != key))
                    valid = true;
            }

            return valid;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (lstActionDefinitions.SelectedIndices.Count <= 0) return;

            _actionDefinitionForm = new ActionDefinitionForm(
                lstActionDefinitions.SelectedItems[0].Tag as ActionDefinition,
                ActionDefinitionValidator
            );

            _actionDefinitionForm.OnSave += actionDefinition =>
            {
                int index = _settings.ActionDefinitions.FindIndex(
                    i => i.Id == actionDefinition.Id
                );

                if (index > -1)
                    _settings.ActionDefinitions[index] = actionDefinition;

                PrepareListOfActions();
            };

            Hide();
            _actionDefinitionForm.ShowDialog();
            Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstActionDefinitions.SelectedIndices.Count <= 0) return;

            var actionDefinition = lstActionDefinitions.SelectedItems[0].Tag as ActionDefinition;

            int index = _settings.ActionDefinitions.FindIndex(
                i => i.Id == actionDefinition?.Id
            );

            if (index > -1)
                _settings.ActionDefinitions.RemoveAt(index);

            PrepareListOfActions();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

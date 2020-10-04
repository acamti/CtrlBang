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
                        }
                    }
                )
                .ToList()
                .ForEach(item => lstActionDefinitions.Items.Add(item));
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
                // update
                return _settings.ActionDefinitions.Where(i => i.Id != itemToValidate.Id)
                    .All(
                        item => itemToValidate.Shortcut.Aggregate(
                            true,
                            (result, key) => result && item.Shortcut.Any(s => s == key)
                        )
                    );
            }

            //add
            return _settings.ActionDefinitions.All(
                item =>
                {
                    var valid = false;

                    foreach (Keys key in itemToValidate.Shortcut)
                    {
                        if (item.Shortcut.All(k => k != key))
                            valid = true;
                    }

                    return valid;
                }
            );
        }
    }
}

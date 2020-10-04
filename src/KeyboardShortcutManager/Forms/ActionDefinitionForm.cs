using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AcamTi.KeyboardShortcutManager.KeyLogging;

namespace AcamTi.KeyboardShortcutManager.Forms
{
    public partial class ActionDefinitionForm : Form
    {
        private readonly Func<ActionDefinition, bool> _actionDefinitionValidator;
        private Guid _id;
        private KeyShortcutDetector _keyDetector;
        private List<Keys> _keyShortcutActivator;
        public Action<ActionDefinition> OnSave;

        public ActionDefinitionForm(ActionDefinition actionDefinition, Func<ActionDefinition, bool> keyValidator)
        {
            InitializeComponent();

            SetupContent(actionDefinition);

            _actionDefinitionValidator = keyValidator;
        }

        private void SetupContent(ActionDefinition actionDefinition)
        {
            _id = actionDefinition.Id;
            txtName.Text = actionDefinition.Name;
            _keyShortcutActivator = new List<Keys>(actionDefinition.Shortcut);
            DisplayKeyShortcut();

            if (actionDefinition.Type == ActionDefinition.ActionType.Powershell)
                txtPowershell.Text = actionDefinition.Content;
        }

        private void btnSetShortcut_Click(object sender, EventArgs e)
        {
            _keyShortcutActivator.Clear();
            lblShortcut.Text = string.Empty;

            _keyDetector = KeyShortcutDetector.InitService(OnShortcutDetected);
        }

        private void OnShortcutDetected(IEnumerable<Keys> keys)
        {
            _keyDetector?.Dispose();
            _keyDetector = null;

            _keyShortcutActivator = new List<Keys>(keys);

            lblShortcut.Invoke(new MethodInvoker(DisplayKeyShortcut));
        }

        private void DisplayKeyShortcut()
        {
            lblShortcut.Text = string.Join(" + ", _keyShortcutActivator);
        }

        private void ActionDefinitionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _keyDetector?.Dispose();
            _keyDetector = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ActionDefinition actionDef = BuildActionDefinition();

            if (txtName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Name must not be empty");
                return;
            }

            if (rdoPowershell.Checked &&
                txtPowershell.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Powershell script cannot be empty");
                return;
            }

            if (!_actionDefinitionValidator(actionDef))
            {
                MessageBox.Show("Invalid Key Combinaison");
                return;
            }

            OnSave(actionDef);
            Close();
        }

        private ActionDefinition BuildActionDefinition() =>
            new ActionDefinition(_id)
            {
                Name = txtName.Text,
                Type = ActionDefinition.ActionType.Powershell,
                Content = txtPowershell.Text,
                Shortcut = new List<Keys>(_keyShortcutActivator)
            };
    }
}

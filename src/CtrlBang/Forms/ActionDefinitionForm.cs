using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AcamTi.CtrlBang.KeyLogging;

namespace AcamTi.CtrlBang.Forms
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

            switch (actionDefinition.Type)
            {
                case ActionDefinition.ActionType.File:
                    rdoFile.Checked = true;
                    txtFile.Text = actionDefinition.Content;

                    break;
                case ActionDefinition.ActionType.Powershell:
                    rdoPowershell.Checked = true;
                    txtPowershell.Text = actionDefinition.Content;

                    break;
                case ActionDefinition.ActionType.Url:
                    rdoUrl.Checked = true;
                    txtUrl.Text = actionDefinition.Content;

                    break;
                default: throw new ArgumentOutOfRangeException();
            }
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
            var actionDef = BuildActionDefinition();

            if ( txtName.Text.Trim() == string.Empty )
            {
                MessageBox.Show("Name must not be empty");

                return;
            }

            if ( rdoFile.Checked && txtFile.Text.Trim() == string.Empty )
            {
                MessageBox.Show("File location cannot be empty");

                return;
            }

            if ( rdoPowershell.Checked && txtPowershell.Text.Trim() == string.Empty )
            {
                MessageBox.Show("Powershell script cannot be empty");

                return;
            }

            if ( rdoUrl.Checked && txtUrl.Text.Trim() == string.Empty )
            {
                MessageBox.Show("Url cannot be empty");

                return;
            }

            if ( !_actionDefinitionValidator(actionDef) )
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
                Type = ExtractType(),
                Content = ExtractContent(),
                Shortcut = new List<Keys>(_keyShortcutActivator)
            };

        private string ExtractContent()
        {
            if ( rdoFile.Checked )
                return txtFile.Text;

            if ( rdoPowershell.Checked )
                return txtPowershell.Text;

            return txtUrl.Text;
        }

        private ActionDefinition.ActionType ExtractType()
        {
            if ( rdoFile.Checked )
                return ActionDefinition.ActionType.File;

            if ( rdoPowershell.Checked )
                return ActionDefinition.ActionType.Powershell;

            return ActionDefinition.ActionType.Url;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RdoTypeChanged(object sender, EventArgs e)
        {
            SetTypeVisibility();
        }

        private void SetTypeVisibility()
        {
            txtFile.Visible = rdoFile.Checked;
            txtPowershell.Visible = rdoPowershell.Checked;
            txtUrl.Visible = rdoUrl.Checked;
        }
    }
}

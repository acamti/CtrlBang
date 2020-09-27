using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AcamTi.KeyboardShortcutManager.KeyLogging;

namespace AcamTi.KeyboardShortcutManager
{
    public partial class SettingsForm : Form
    {
        private KeyShortcutDetector _keyDetector;
        private List<Keys> _selectedKeys = new List<Keys>(new[] { Keys.Control, Keys.LWin, Keys.Z });

        public SettingsForm()
        {
            InitializeComponent();

            DisplayKeyShortcut();
        }

        private void DisplayKeyShortcut()
        {
            lblShortcut.Text = string.Join(" + ", _selectedKeys);
        }

        private void btnSetShortcut_Click(object sender, EventArgs e)
        {
            _selectedKeys.Clear();
            lblShortcut.Text = string.Empty;

            _keyDetector = new KeyShortcutDetector();
            _keyDetector.OnShortcutDetected += OnShortcutDetected;
            _keyDetector.Start();
        }

        private void OnShortcutDetected(IEnumerable<Keys> keys)
        {
            _selectedKeys = new List<Keys>(keys);

            _keyDetector?.Dispose();
            _keyDetector = null;

            lblShortcut.Invoke(
                new MethodInvoker(DisplayKeyShortcut)
            );
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _keyDetector?.Dispose();
            _keyDetector = null;
        }
    }
}

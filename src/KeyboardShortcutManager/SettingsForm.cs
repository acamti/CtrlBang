using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AcamTi.KeyboardShortcutManager.KeyLogging;

namespace AcamTi.KeyboardShortcutManager
{
    public partial class SettingsForm : Form
    {
        private readonly Settings _settings;
        private KeyShortcutDetector _keyDetector;
        public Action<Settings> OnSettingsUpdated;

        public SettingsForm(Settings settings)
        {
            _settings = settings;

            InitializeComponent();
            DisplayKeyShortcut();
        }

        private void DisplayKeyShortcut()
        {
            lblShortcut.Text = string.Join(" + ", _settings.KeyShortcutActivator);
        }

        private void btnSetShortcut_Click(object sender, EventArgs e)
        {
            _settings.KeyShortcutActivator.Clear();
            lblShortcut.Text = string.Empty;

            _keyDetector = new KeyShortcutDetector();
            _keyDetector.OnShortcutDetected += OnShortcutDetected;
            _keyDetector.Start();
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
    }
}

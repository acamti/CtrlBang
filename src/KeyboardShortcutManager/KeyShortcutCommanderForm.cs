using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AcamTi.KeyboardShortcutManager.KeyLogging;

namespace AcamTi.KeyboardShortcutManager
{
    public partial class KeyShortcutCommanderForm : Form
    {
        private readonly KeyShortcutDetector _keyMonitor;
        public Func<Settings> GetSettings;

        public KeyShortcutCommanderForm()
        {
            InitializeComponent();

            _keyMonitor = new KeyShortcutDetector
            {
                OnShortcutDetected = OnShortcutDetected
            };

            _keyMonitor.Start();
        }

        private void OnShortcutDetected(IEnumerable<Keys> keys)
        {
            lblShortcut.Invoke(
                IsShortcutActivator(keys)
                    ? () => lblShortcut.Text = string.Join(" + ", keys)
                    : new MethodInvoker(() => lblShortcut.Text = "Incorrect shortcut")
            );
        }

        private bool IsShortcutActivator(IEnumerable<Keys> keys)
        {
            if (keys.Count() != GetSettings().KeyShortcutActivator.Count) return false;

            return keys.All(
                key =>
                    GetSettings().KeyShortcutActivator.Any(k => (int) k == (int) key)
            );
        }

        private void KeyShortcutCommander_FormClosing(object sender, FormClosingEventArgs e)
        {
            _keyMonitor.Dispose();
        }
    }
}

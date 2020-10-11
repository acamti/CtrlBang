using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AcamTi.CtrlBang.Extensions;
using AcamTi.CtrlBang.KeyLogging;

namespace AcamTi.CtrlBang.Forms
{
    public partial class KeyShortcutCommanderForm : Form
    {
        private readonly KeyShortcutDetector _keyMonitor;
        private bool _isListening;
        public Func<Settings> GetSettings;

        public KeyShortcutCommanderForm()
        {
            InitializeComponent();

            _keyMonitor = KeyShortcutDetector.InitService(OnShortcutDetected);

            CreateControl();
            CreateGraphics();
        }

        private void OnShortcutDetected(IEnumerable<Keys> keys)
        {
            if ( !IsShortcutActivator(keys) )
            {
                if ( !Visible ) return;

                BeginInvoke(new MethodInvoker(Hide));

                if ( _isListening )
                {
                    foreach (var actionDefinition in GetSettings()
                        .ActionDefinitions.Where(
                            actionDefinition => actionDefinition.Shortcut.IsSameAs(keys)
                        )) actionDefinition.Execute();
                }

                _isListening = false;

                return;
            }

            _isListening = true;
            BeginInvoke(new MethodInvoker(Show));

            BeginInvoke(new MethodInvoker(() => SetForegroundWindow(Handle)));
        }

        [DllImport("User32")]
        private static extern int SetForegroundWindow(IntPtr hwnd);

        private bool IsShortcutActivator(IEnumerable<Keys> keys)
        {
            if ( keys.Count() != GetSettings().KeyShortcutActivator.Count )
                return false;

            return keys.All(
                key => GetSettings()
                    .KeyShortcutActivator.Any(k => (int)k == (int)key));
        }

        private void KeyShortcutCommander_FormClosing(object sender, FormClosingEventArgs e)
        {
            _keyMonitor.Dispose();
        }
    }
}

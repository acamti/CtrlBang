﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AcamTi.KeyboardShortcutManager.KeyLogging;

namespace AcamTi.KeyboardShortcutManager.Forms
{
    public partial class KeyShortcutCommanderForm : Form
    {
        private readonly KeyShortcutDetector _keyMonitor;
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
            if (!IsShortcutActivator(keys))
            {
                if (!Visible) return;
                BeginInvoke(new MethodInvoker(Hide));
                lblListening.BeginInvoke(new MethodInvoker(lblListening.Hide));
                return;
            }

            BeginInvoke(new MethodInvoker(Show));
            BeginInvoke(new MethodInvoker(() => Focus()));

            lblListening.BeginInvoke(new MethodInvoker(lblListening.Show));
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
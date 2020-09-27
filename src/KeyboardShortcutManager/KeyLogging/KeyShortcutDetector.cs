﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AcamTi.KeyboardShortcutManager.KeyLogging
{
    public class KeyShortcutDetector : IDisposable
    {
        private KeyListener _keyListener;
        private List<Keys> _pressedKeys;
        public Action<IEnumerable<Keys>> OnShortcutDetected;

        public KeyShortcutDetector() =>
            _pressedKeys = new List<Keys>();

        public void Dispose()
        {
            _keyListener.OnKeyActivityChanged -= OnKeyActivityChanged;
        }

        public void Start()
        {
            _keyListener = KeyListener.Listen();
            _keyListener.OnKeyActivityChanged += OnKeyActivityChanged;
        }

        private void OnKeyActivityChanged(Keys[] keys)
        {
            if (keys.Any())
            {
                IEnumerable<Keys> newKeys = keys.Where(k => _pressedKeys.Contains(k) == false);
                (_pressedKeys ??= new List<Keys>()).AddRange(newKeys);
            }
            else
            {
                OnShortcutDetected(_pressedKeys);
                _pressedKeys.Clear();
            }
        }
    }
}

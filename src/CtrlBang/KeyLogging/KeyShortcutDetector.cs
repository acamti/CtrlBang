using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AcamTi.CtrlBang.KeyLogging
{
    public class KeyShortcutDetector : IDisposable
    {
        private KeyListener _keyListener;
        private Action<IEnumerable<Keys>> _onShortcutDetected;
        private List<Keys> _pressedKeys;

        private KeyShortcutDetector() =>
            _pressedKeys = new List<Keys>();

        public void Dispose()
        {
            _keyListener.OnKeyActivityChanged -= OnKeyActivityChanged;
        }

        public static KeyShortcutDetector InitService(Action<IEnumerable<Keys>> onShortcutDetected)
        {
            var detector = new KeyShortcutDetector();
            detector._onShortcutDetected += onShortcutDetected;

            detector.Start();

            return detector;
        }

        private void Start()
        {
            _keyListener = KeyListener.Listen();
            _keyListener.OnKeyActivityChanged += OnKeyActivityChanged;
        }

        private void OnKeyActivityChanged(Keys[] keys)
        {
            if ( keys.Any() )
            {
                var newKeys = keys.Where(k => _pressedKeys.Contains(k) == false);
                ( _pressedKeys ??= new List<Keys>() ).AddRange(newKeys);
            }
            else
            {
                _onShortcutDetected(_pressedKeys);
                _pressedKeys.Clear();
            }
        }
    }
}

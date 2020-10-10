using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace AcamTi.KeyboardShortcutManager.KeyLogging
{
    public class KeyListener
    {
        private static KeyListener _keyListener;
        private static Thread _keyListenerThread;
        private static bool _isCancelled;

        private readonly Keys[] _keysToExclude =
        {
            Keys.LShiftKey,
            Keys.RShiftKey,
            Keys.LControlKey,
            Keys.RControlKey,
            Keys.LMenu,
            Keys.RMenu,
            Keys.Apps,
            Keys.CapsLock,
            Keys.VolumeDown,
            Keys.VolumeMute,
            Keys.VolumeUp,
            Keys.MediaStop,
            Keys.MediaNextTrack,
            Keys.MediaPlayPause,
            Keys.MediaPreviousTrack,
            Keys.SelectMedia,
            Keys.LButton,
            Keys.MButton,
            Keys.RButton,
            Keys.XButton1,
            Keys.XButton2
        };

        private List<Keys> _monitoredKeys;
        public Action<Keys[]> OnKeyActivityChanged;

        private KeyListener() =>
            _monitoredKeys = new List<Keys>();

        public static KeyListener Listen()
        {
            StartThread();

            return _keyListener;
        }

        public static void Stop()
        {
            _isCancelled = true;
        }

        private static void StartThread()
        {
            _keyListener ??= new KeyListener();

            if ( _keyListenerThread != null && _keyListenerThread.IsAlive )
                return;

            _keyListenerThread = new Thread(() => { _keyListener.ListenToKeyboardActivity(); });

            _keyListenerThread.Start();
        }

        private void ListenToKeyboardActivity()
        {
            var keyStates = Enumerable
                .Range(0, 254)
                .Select((index, state) => ( Key: index, State: 0 ))
                .ToArray();

            Thread.Sleep(100);

            while ( OnKeyActivityChanged != null && !_isCancelled )
            {
                for (var index = 0; index < 254; index++)
                {
                    keyStates[index].State = GetAsyncKeyState(keyStates[index].Key);
                }

                IEnumerable<int> pressedKeys = keyStates
                    .Where(x => x.State != 0)
                    .Select(x => x.Key)
                    .ToArray();

                ReleasePressedKeys(pressedKeys.Select(key => key));

                foreach (var keyValue in pressedKeys)
                    PressKey(keyValue);
            }
        }

        private void PressKey(int keyValue)
        {
            if ( _monitoredKeys.Any(key => key == (Keys)keyValue) )
                return;

            if ( !IsMonitored(keyValue) ) return;

            _monitoredKeys.Add((Keys)keyValue);

            OnKeyActivityChanged(_monitoredKeys
                                     .OrderBy(key => (int)key)
                                     .ToArray());
        }

        private bool IsMonitored(int keyValue) =>
            _keysToExclude.All(keyNotMonitored => keyNotMonitored != (Keys)keyValue);

        private void ReleasePressedKeys(IEnumerable<int> pressedKeys)
        {
            var keysToBeRelease = _monitoredKeys
                .Where(key => pressedKeys.All(pressedKey => (Keys)pressedKey != key));

            _monitoredKeys = new List<Keys>(
                _monitoredKeys.Where(
                    key => keysToBeRelease.All(toBeReleasedKey => key != toBeReleasedKey)));

            if ( keysToBeRelease.Any() )
                OnKeyActivityChanged(_monitoredKeys.OrderBy(k => (int)k).ToArray());
        }

        [DllImport("user32.dll")]
        private static extern int GetAsyncKeyState(int i);
    }
}

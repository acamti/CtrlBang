using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcamTi.KeyboardShortcutManager
{
    public class KeyListener
    {
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
            Keys.SelectMedia
        };

        private List<Keys> _monitoredKeys;
        public Action<Keys[]> OnKeyActivityChanged;

        public KeyListener() =>
            _monitoredKeys = new List<Keys>();

        public async Task ListenToKeyboardActivity(CancellationToken cancellationToken)
        {
            int[] keyRange = Enumerable.Range(0, 254).ToArray();

            while (!cancellationToken.IsCancellationRequested)
            {
                await Task.Delay(100);

                int[] pressedKeys = keyRange
                    .Select((index, state) => (Key: index, State: GetAsyncKeyState(state)))
                    .Where(x => x.State != 0)
                    .Select(x => x.Key)
                    .ToArray();

                ReleasePressedKeys(pressedKeys.Select(key => key));

                foreach (int keyValue in pressedKeys)
                    PressKey(keyValue);
            }
        }

        private void PressKey(int keyValue)
        {
            if (_monitoredKeys.Any(key => key == (Keys) keyValue))
                return;

            if (!IsMonitored(keyValue)) return;

            _monitoredKeys.Add((Keys) keyValue);

            OnKeyActivityChanged(_monitoredKeys.OrderBy(key => (int) key).ToArray());
        }

        private bool IsMonitored(int keyValue) =>
            _keysToExclude.All(keyNotMonitored => keyNotMonitored != (Keys) keyValue);

        private void ReleasePressedKeys(IEnumerable<int> pressedKeys)
        {
            IEnumerable<Keys> keysToBeRelease = _monitoredKeys
                .Where(key => pressedKeys.All(pressedKey => (Keys) pressedKey != key));

            _monitoredKeys = new List<Keys>(
                _monitoredKeys
                    .Where(key => keysToBeRelease.All(toBeReleasedKey => key != toBeReleasedKey))
            );

            if (keysToBeRelease.Any())
                OnKeyActivityChanged(_monitoredKeys.OrderBy(k => (int) k).ToArray());
        }

        [DllImport("user32.dll")]
        private static extern int GetAsyncKeyState(int i);
    }
}

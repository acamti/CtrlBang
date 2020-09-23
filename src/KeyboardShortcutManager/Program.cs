using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace AcamTi.KeyboardShortcutManager
{
    internal static class Program
    {
        private static readonly CancellationTokenSource Token = new CancellationTokenSource();
        private static Thread _keyListenerThread;
        private static SettingsForm _settingsForm;
        private static NotifyIcon _icon;

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            StartKeyListeningThread();
            SetupExitBehavior();
            SetTaskbarIcon();

            Application.Run();
        }

        private static void SetupExitBehavior()
        {
            Application.ApplicationExit += (sender, eventArgs) =>
            {
                _icon.Icon = null;
                Token.Cancel();
            };
        }

        private static void StartKeyListeningThread()
        {
            _keyListenerThread = new Thread(
                async () =>
                {
                    var keyListener = new KeyListener
                    {
                        OnKeyActivityChanged = OnKeyActivityChanged
                    };

                    await keyListener.ListenToKeyboardActivity(Token.Token);
                }
            );

            _keyListenerThread.Start();
        }

        private static void SetTaskbarIcon()
        {
            const string ICON_ASSEMBLY = "AcamTi.KeyboardShortcutManager.icon.ico";

            Stream s = Assembly.GetExecutingAssembly().GetManifestResourceStream(ICON_ASSEMBLY);

            _icon = new NotifyIcon
            {
                Icon = new Icon(s),
                Visible = true,
                Text = Application.ProductName,
                BalloonTipTitle = "Keyboard Shortcut Manager",
                BalloonTipText = "Now listening to your commands...",
                ContextMenuStrip = new ContextMenuStrip()
            };

            _icon.ContextMenuStrip.Items.Add(
                "Exit",
                null,
                (sender, args) => Application.Exit()
            );

            _icon.BalloonTipClicked += IconOnClick;
            _icon.Click += IconOnClick;

            _icon.ShowBalloonTip(2000);
        }

        private static void IconOnClick(object sender, EventArgs e)
        {
            if (_settingsForm != null &&
                _settingsForm.Visible) return;

            _settingsForm = new SettingsForm();
            _settingsForm.Show();
        }

        private static void OnKeyActivityChanged(Keys[] pressedKeys)
        {
            if (pressedKeys?.Any() ?? false)
                Console.WriteLine($"Key pressed: {string.Join(" + ", pressedKeys)}");
            else
                Console.WriteLine("Key pressed: None");
        }
    }
}

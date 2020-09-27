using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace AcamTi.KeyboardShortcutManager
{
    internal static class Program
    {
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

            SetTaskbarIcon();

            Application.ApplicationExit += ApplicationOnApplicationExit;
            Application.Run();
        }

        private static void ApplicationOnApplicationExit(object sender, EventArgs e)
        {
            _icon.Dispose();
            _icon = null;
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
                "Settings",
                null,
                IconOnClick
            );

            _icon.ContextMenuStrip.Items.Add(
                "Exit",
                null,
                (sender, args) => Application.Exit()
            );

            _icon.ShowBalloonTip(2000);
        }

        private static void IconOnClick(object sender, EventArgs e)
        {
            if (_settingsForm != null &&
                _settingsForm.Visible) return;

            _settingsForm = new SettingsForm();
            _settingsForm.Show();
        }
    }
}

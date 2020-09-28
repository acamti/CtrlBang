using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AcamTi.KeyboardShortcutManager
{
    internal static class Program
    {
        private static SettingsForm _settingsForm;
        private static IconManager _icon;
        private static Settings _settings;

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            _icon = new IconManager();

            _icon.AddMenuItem(
                "Settings",
                null,
                IconOnClick
            );

            _icon.AddMenuItem(
                "Exit",
                null,
                (sender, args) => Application.Exit()
            );

            Application.ApplicationExit += ApplicationOnApplicationExit;

            InitSettings();

            Application.Run(
                new KeyShortcutCommanderForm
                {
                    GetSettings = () => _settings
                }
            );
        }

        private static void InitSettings()
        {
            _settings = new Settings
            {
                KeyShortcutActivator = new List<Keys>
                    { Keys.LWin, Keys.Enter }
            };
        }

        private static void ApplicationOnApplicationExit(object sender, EventArgs e)
        {
            _icon.Dispose();
        }

        private static void IconOnClick(object sender, EventArgs e)
        {
            if (_settingsForm is null ||
                !_settingsForm.Visible)
            {
                _settingsForm = new SettingsForm(_settings)
                {
                    OnSettingsUpdated = setting => _settings = setting
                };
            }

            _settingsForm.Show();
        }
    }
}

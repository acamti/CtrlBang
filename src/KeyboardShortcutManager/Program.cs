using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using AcamTi.KeyboardShortcutManager.Forms;
using AcamTi.KeyboardShortcutManager.KeyLogging;

namespace AcamTi.KeyboardShortcutManager
{
    internal static class Program
    {
        private static SettingsForm _settingsForm;
        private static IconManager _icon;
        private static Settings _settings;
        private static KeyShortcutCommanderForm _keyShortcutCommanderForm;

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SetupIcon();

            Application.ApplicationExit += ApplicationOnApplicationExit;

            InitSettings();

            InitCommander();

            Application.Run();
        }

        private static void InitCommander()
        {
            _keyShortcutCommanderForm = new KeyShortcutCommanderForm
            {
                GetSettings = () => _settings
            };
        }

        private static void SetupIcon()
        {
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

            _icon.SetupClickBehavior(IconOnClick);
        }

        private static void InitSettings()
        {
            if (File.Exists("./settings.json"))
            {
                _settings = JsonSerializer.Deserialize<Settings>(File.ReadAllText("./settings.json"));
                return;
            }

            _settings = new Settings
            {
                KeyShortcutActivator = new List<Keys> { Keys.LWin, Keys.Enter },
                ActionDefinitions = new List<ActionDefinition>()
            };
        }

        private static void ApplicationOnApplicationExit(object sender, EventArgs e)
        {
            _icon.Dispose();
            KeyListener.Stop();
        }

        private static void IconOnClick(object sender, EventArgs e)
        {
            if (_settingsForm is null ||
                !_settingsForm.Visible)
            {
                _settingsForm = new SettingsForm(_settings)
                {
                    OnSettingsUpdated = OnSettingsUpdated
                };
            }

            _settingsForm.Show();
        }

        private static void OnSettingsUpdated(Settings setting)
        {
            _settings = setting;

            File.WriteAllText("./settings.json", JsonSerializer.Serialize(setting));
        }
    }
}

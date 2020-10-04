using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AcamTi.KeyboardShortcutManager.Forms;

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
            _settings = new Settings
            {
                KeyShortcutActivator = new List<Keys>
                    { Keys.LWin, Keys.Enter },
                ActionDefinitions = new List<ActionDefinition>(
                    new[]
                    {
                        new ActionDefinition
                        {
                            Shortcut = new[] { Keys.T },
                            Name = "Windows Terminal",
                            Content = @"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe Start-Process -Verb RunAs wt",
                            Type = ActionDefinition.ActionType.Powershell
                        },
                        new ActionDefinition
                        {
                            Shortcut = new[] { Keys.W, Keys.C },
                            Name = "Chrome",
                            Content = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe",
                            Type = ActionDefinition.ActionType.File
                        },
                        new ActionDefinition
                        {
                            Shortcut = new[] { Keys.B, Keys.T },
                            Name = "Tangerine",
                            Content = "https://www.tangerine.ca/fr",
                            Type = ActionDefinition.ActionType.Url
                        }
                    }
                )
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

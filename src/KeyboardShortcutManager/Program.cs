using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcamTi.KeyboardShortcutManager
{
    internal static class Program
    {
        private static readonly CancellationTokenSource Token = new CancellationTokenSource();

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        /// <param name="args"></param>
        [STAThread]
        private static async Task Main(string[] args)
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var keyListener = new KeyListener
            {
                OnKeyActivityChanged = OnKeyActivityChanged
            };

            Application.ApplicationExit += ApplicationOnApplicationExit;

            await keyListener.ListenToKeyboardActivity(Token.Token);
        }

        private static void OnKeyActivityChanged(Keys[] pressedKeys)
        {
            if (pressedKeys?.Any() ?? false)
                Console.WriteLine($"Key pressed: {string.Join(" + ", pressedKeys)}");
            else
                Console.WriteLine("Key pressed: None");
        }

        private static void ApplicationOnApplicationExit(object sender, EventArgs e)
        {
            Token.Cancel();
        }
    }
}

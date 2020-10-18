using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace AcamTi.CtrlBang
{
    public class IconManager : IDisposable
    {
        private static NotifyIcon _icon;

        public IconManager()
        {
            _icon = new NotifyIcon
            {
                Icon = new Icon(IconStream),
                Visible = true,
                Text = Application.ProductName,
                ContextMenuStrip = new ContextMenuStrip()
            };

            Alert(1000, "Now listening to your commands...", ToolTipIcon.Info);
        }

        private static Stream IconStream =>
            Assembly.GetExecutingAssembly().GetManifestResourceStream("AcamTi.CtrlBang.icon.ico");

        public void Dispose()
        {
            _icon.Dispose();
            _icon = null;
        }

        public static void AddMenuItem(string name, Image img, EventHandler eventHandler)
        {
            _icon.ContextMenuStrip.Items.Add(name, img, eventHandler);
        }

        public static void Alert(int timeout, string message, ToolTipIcon icon)
        {
            _icon.ShowBalloonTip(timeout, "CTRL + Bang!", message, icon);
        }
    }
}

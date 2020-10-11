using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace AcamTi.CtrlBang
{
    public class IconManager : IDisposable
    {
        private NotifyIcon _icon;

        public IconManager()
        {
            _icon = new NotifyIcon
            {
                Icon = new Icon(IconStream),
                Visible = true,
                Text = Application.ProductName,
                BalloonTipTitle = "CTRL Bang!",
                BalloonTipText = "Now listening to your commands...",
                ContextMenuStrip = new ContextMenuStrip()
            };

            _icon.ShowBalloonTip(2000);
        }

        private static Stream IconStream =>
            Assembly.GetExecutingAssembly().GetManifestResourceStream("AcamTi.CtrlBang.icon.ico");

        public void Dispose()
        {
            _icon.Dispose();
            _icon = null;
        }

        public void AddMenuItem(string name, Image img, EventHandler eventHandler)
        {
            _icon.ContextMenuStrip.Items.Add(name, img, eventHandler);
        }
    }
}

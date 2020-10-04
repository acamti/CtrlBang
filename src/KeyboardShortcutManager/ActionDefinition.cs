using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AcamTi.KeyboardShortcutManager
{
    public class ActionDefinition
    {
        public enum ActionType
        {
            File,
            Powershell,
            Url
        }

        public ActionDefinition() => Id = Guid.NewGuid();
        public ActionDefinition(Guid id) => Id = id;
        public Guid Id { get; }
        public IEnumerable<Keys> Shortcut { get; set; } = Enumerable.Empty<Keys>();
        public string Name { get; set; }
        public string Content { get; set; }
        public ActionType Type { get; set; }
    }
}

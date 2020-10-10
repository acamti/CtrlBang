using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management.Automation;
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

        public void Execute()
        {
            switch (Type)
            {
                case ActionType.File:
                {
                    Process.Start(Content);

                    break;
                }
                case ActionType.Powershell:
                {
                    PowerShell.Create().AddScript(Content).Invoke();

                    break;
                }
                case ActionType.Url:
                {
                    Process.Start("Explorer.exe", Content);

                    break;
                }
                default: throw new ArgumentOutOfRangeException();
            }
        }
    }
}

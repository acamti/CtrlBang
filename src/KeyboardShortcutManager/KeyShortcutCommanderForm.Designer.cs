using System.ComponentModel;

namespace AcamTi.KeyboardShortcutManager
{
    partial class KeyShortcutCommanderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblShortcut = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblShortcut
            // 
            this.lblShortcut.Location = new System.Drawing.Point(12, 19);
            this.lblShortcut.Name = "lblShortcut";
            this.lblShortcut.Size = new System.Drawing.Size(227, 23);
            this.lblShortcut.TabIndex = 0;

            // 
            // KeyShortcutCommanderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(251, 70);
            this.ControlBox = false;
            this.Controls.Add(this.lblShortcut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KeyShortcutCommanderForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "KeyShortcutCommander";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KeyShortcutCommander_FormClosing);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblShortcut;

        #endregion
    }
}


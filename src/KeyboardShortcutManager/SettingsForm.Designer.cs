using System.ComponentModel;

namespace AcamTi.KeyboardShortcutManager
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.lblShortcut = new System.Windows.Forms.Label();
            this.btnSetShortcut = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // lblShortcut
            // 
            this.lblShortcut.AutoSize = true;
            this.lblShortcut.Location = new System.Drawing.Point(86, 16);
            this.lblShortcut.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblShortcut.Name = "lblShortcut";
            this.lblShortcut.Size = new System.Drawing.Size(48, 13);
            this.lblShortcut.TabIndex = 1;
            this.lblShortcut.Text = "WIN + Z";
            this.lblShortcut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // btnSetShortcut
            // 
            this.btnSetShortcut.Location = new System.Drawing.Point(4, 13);
            this.btnSetShortcut.Margin = new System.Windows.Forms.Padding(1);
            this.btnSetShortcut.Name = "btnSetShortcut";
            this.btnSetShortcut.Size = new System.Drawing.Size(79, 21);
            this.btnSetShortcut.TabIndex = 2;
            this.btnSetShortcut.Text = "Set shortcut";
            this.btnSetShortcut.UseVisualStyleBackColor = true;
            this.btnSetShortcut.Click += new System.EventHandler(this.btnSetShortcut_Click);

            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 189);
            this.Controls.Add(this.btnSetShortcut);
            this.Controls.Add(this.lblShortcut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblShortcut;
        private System.Windows.Forms.Button btnSetShortcut;

        #endregion
    }
}


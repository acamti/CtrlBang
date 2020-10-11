using System.ComponentModel;

namespace AcamTi.CtrlBang.Forms
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
            this.lblListening = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblListening
            // 
            this.lblListening.Font = new System.Drawing.Font("Inconsolata", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblListening.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblListening.Location = new System.Drawing.Point(0, 30);
            this.lblListening.Name = "lblListening";
            this.lblListening.Size = new System.Drawing.Size(691, 23);
            this.lblListening.TabIndex = 0;
            this.lblListening.Text = "Listening...";
            this.lblListening.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // KeyShortcutCommanderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(690, 79);
            this.ControlBox = false;
            this.Controls.Add(this.lblListening);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KeyShortcutCommanderForm";
            this.Opacity = 0.5D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeyShortcutCommander";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KeyShortcutCommander_FormClosing);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblListening;

        #endregion
    }
}


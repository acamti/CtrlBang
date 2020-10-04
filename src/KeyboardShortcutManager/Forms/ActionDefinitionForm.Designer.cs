using System.ComponentModel;

namespace AcamTi.KeyboardShortcutManager.Forms
{
    partial class ActionDefinitionForm
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
            this.btnSetShortcut = new System.Windows.Forms.Button();
            this.lblShortcut = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rdoFile = new System.Windows.Forms.RadioButton();
            this.rdoPowershell = new System.Windows.Forms.RadioButton();
            this.rdoUrl = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPowershell = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // 
            // btnSetShortcut
            // 
            this.btnSetShortcut.Location = new System.Drawing.Point(16, 33);
            this.btnSetShortcut.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSetShortcut.Name = "btnSetShortcut";
            this.btnSetShortcut.Size = new System.Drawing.Size(248, 44);
            this.btnSetShortcut.TabIndex = 0;
            this.btnSetShortcut.Text = "Set Shortcut";
            this.btnSetShortcut.UseVisualStyleBackColor = true;
            this.btnSetShortcut.Click += new System.EventHandler(this.btnSetShortcut_Click);

            // 
            // lblShortcut
            // 
            this.lblShortcut.Location = new System.Drawing.Point(290, 33);
            this.lblShortcut.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblShortcut.Name = "lblShortcut";
            this.lblShortcut.Size = new System.Drawing.Size(266, 44);
            this.lblShortcut.TabIndex = 1;
            this.lblShortcut.Text = "Undefined";
            this.lblShortcut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";

            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 144);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(551, 38);
            this.txtName.TabIndex = 3;

            // 
            // rdoFile
            // 
            this.rdoFile.AutoSize = true;
            this.rdoFile.Location = new System.Drawing.Point(28, 240);
            this.rdoFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoFile.Name = "rdoFile";
            this.rdoFile.Size = new System.Drawing.Size(99, 36);
            this.rdoFile.TabIndex = 4;
            this.rdoFile.Text = "File";
            this.rdoFile.UseVisualStyleBackColor = true;

            // 
            // rdoPowershell
            // 
            this.rdoPowershell.AutoSize = true;
            this.rdoPowershell.Checked = true;
            this.rdoPowershell.Location = new System.Drawing.Point(153, 240);
            this.rdoPowershell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoPowershell.Name = "rdoPowershell";
            this.rdoPowershell.Size = new System.Drawing.Size(192, 36);
            this.rdoPowershell.TabIndex = 4;
            this.rdoPowershell.TabStop = true;
            this.rdoPowershell.Text = "Powershell";
            this.rdoPowershell.UseVisualStyleBackColor = true;

            // 
            // rdoUrl
            // 
            this.rdoUrl.AutoSize = true;
            this.rdoUrl.Location = new System.Drawing.Point(399, 240);
            this.rdoUrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoUrl.Name = "rdoUrl";
            this.rdoUrl.Size = new System.Drawing.Size(88, 36);
            this.rdoUrl.TabIndex = 4;
            this.rdoUrl.Text = "Url";
            this.rdoUrl.UseVisualStyleBackColor = true;

            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(808, 33);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(177, 44);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1012, 33);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(177, 44);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // 
            // txtPowershell
            // 
            this.txtPowershell.BackColor = System.Drawing.Color.Blue;
            this.txtPowershell.Font = new System.Drawing.Font("Inconsolata", 9F);
            this.txtPowershell.ForeColor = System.Drawing.Color.White;
            this.txtPowershell.Location = new System.Drawing.Point(29, 305);
            this.txtPowershell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPowershell.Multiline = true;
            this.txtPowershell.Name = "txtPowershell";
            this.txtPowershell.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPowershell.Size = new System.Drawing.Size(1177, 297);
            this.txtPowershell.TabIndex = 7;

            // 
            // ActionDefinitionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 609);
            this.Controls.Add(this.txtPowershell);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rdoUrl);
            this.Controls.Add(this.rdoPowershell);
            this.Controls.Add(this.rdoFile);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblShortcut);
            this.Controls.Add(this.btnSetShortcut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActionDefinitionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Action Definition";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ActionDefinitionForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnSetShortcut;
        private System.Windows.Forms.Label lblShortcut;

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton rdoFile;
        private System.Windows.Forms.RadioButton rdoPowershell;
        private System.Windows.Forms.RadioButton rdoUrl;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPowershell;
    }
}


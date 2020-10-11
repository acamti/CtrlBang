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
            this.txtFile = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // 
            // btnSetShortcut
            // 
            this.btnSetShortcut.Location = new System.Drawing.Point(6, 14);
            this.btnSetShortcut.Name = "btnSetShortcut";
            this.btnSetShortcut.Size = new System.Drawing.Size(93, 18);
            this.btnSetShortcut.TabIndex = 0;
            this.btnSetShortcut.Text = "Set Shortcut";
            this.btnSetShortcut.UseVisualStyleBackColor = true;
            this.btnSetShortcut.Click += new System.EventHandler(this.btnSetShortcut_Click);

            // 
            // lblShortcut
            // 
            this.lblShortcut.Location = new System.Drawing.Point(109, 14);
            this.lblShortcut.Name = "lblShortcut";
            this.lblShortcut.Size = new System.Drawing.Size(100, 18);
            this.lblShortcut.TabIndex = 1;
            this.lblShortcut.Text = "Undefined";
            this.lblShortcut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";

            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(45, 60);
            this.txtName.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(209, 20);
            this.txtName.TabIndex = 1;

            // 
            // rdoFile
            // 
            this.rdoFile.AutoSize = true;
            this.rdoFile.Checked = true;
            this.rdoFile.Location = new System.Drawing.Point(10, 101);
            this.rdoFile.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.rdoFile.Name = "rdoFile";
            this.rdoFile.Size = new System.Drawing.Size(64, 32);
            this.rdoFile.TabIndex = 2;
            this.rdoFile.TabStop = true;
            this.rdoFile.Text = "File";
            this.rdoFile.UseVisualStyleBackColor = true;
            this.rdoFile.CheckedChanged += new System.EventHandler(this.RdoTypeChanged);

            // 
            // rdoPowershell
            // 
            this.rdoPowershell.AutoSize = true;
            this.rdoPowershell.Location = new System.Drawing.Point(57, 101);
            this.rdoPowershell.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.rdoPowershell.Name = "rdoPowershell";
            this.rdoPowershell.Size = new System.Drawing.Size(105, 32);
            this.rdoPowershell.TabIndex = 3;
            this.rdoPowershell.Text = "Powershell";
            this.rdoPowershell.UseVisualStyleBackColor = true;
            this.rdoPowershell.CheckedChanged += new System.EventHandler(this.RdoTypeChanged);

            // 
            // rdoUrl
            // 
            this.rdoUrl.AutoSize = true;
            this.rdoUrl.Location = new System.Drawing.Point(150, 101);
            this.rdoUrl.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.rdoUrl.Name = "rdoUrl";
            this.rdoUrl.Size = new System.Drawing.Size(60, 32);
            this.rdoUrl.TabIndex = 4;
            this.rdoUrl.Text = "Url";
            this.rdoUrl.UseVisualStyleBackColor = true;
            this.rdoUrl.CheckedChanged += new System.EventHandler(this.RdoTypeChanged);

            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(303, 14);
            this.btnSave.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 18);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(380, 14);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(66, 18);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // 
            // txtPowershell
            // 
            this.txtPowershell.BackColor = System.Drawing.Color.Blue;
            this.txtPowershell.Font = new System.Drawing.Font("Inconsolata", 9F);
            this.txtPowershell.ForeColor = System.Drawing.Color.White;
            this.txtPowershell.Location = new System.Drawing.Point(11, 128);
            this.txtPowershell.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtPowershell.Multiline = true;
            this.txtPowershell.Name = "txtPowershell";
            this.txtPowershell.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPowershell.Size = new System.Drawing.Size(444, 127);
            this.txtPowershell.TabIndex = 5;
            this.txtPowershell.Visible = false;

            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(11, 128);
            this.txtFile.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(444, 20);
            this.txtFile.TabIndex = 5;

            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(10, 130);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(444, 20);
            this.txtUrl.TabIndex = 5;
            this.txtUrl.Visible = false;

            // 
            // ActionDefinitionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 261);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.txtFile);
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

        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.TextBox txtUrl;
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


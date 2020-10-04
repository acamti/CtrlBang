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
            this.btnSetShortcut.Location = new System.Drawing.Point(17, 44);
            this.btnSetShortcut.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnSetShortcut.Name = "btnSetShortcut";
            this.btnSetShortcut.Size = new System.Drawing.Size(264, 58);
            this.btnSetShortcut.TabIndex = 0;
            this.btnSetShortcut.Text = "Set Shortcut";
            this.btnSetShortcut.UseVisualStyleBackColor = true;
            this.btnSetShortcut.Click += new System.EventHandler(this.btnSetShortcut_Click);
            // 
            // lblShortcut
            // 
            this.lblShortcut.Location = new System.Drawing.Point(308, 44);
            this.lblShortcut.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblShortcut.Name = "lblShortcut";
            this.lblShortcut.Size = new System.Drawing.Size(283, 58);
            this.lblShortcut.TabIndex = 1;
            this.lblShortcut.Text = "Undefined";
            this.lblShortcut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(127, 191);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(585, 47);
            this.txtName.TabIndex = 3;
            // 
            // rdoFile
            // 
            this.rdoFile.AutoSize = true;
            this.rdoFile.Location = new System.Drawing.Point(30, 318);
            this.rdoFile.Name = "rdoFile";
            this.rdoFile.Size = new System.Drawing.Size(100, 45);
            this.rdoFile.TabIndex = 4;
            this.rdoFile.Text = "File";
            this.rdoFile.UseVisualStyleBackColor = true;
            // 
            // rdoPowershell
            // 
            this.rdoPowershell.AutoSize = true;
            this.rdoPowershell.Checked = true;
            this.rdoPowershell.Location = new System.Drawing.Point(163, 318);
            this.rdoPowershell.Name = "rdoPowershell";
            this.rdoPowershell.Size = new System.Drawing.Size(197, 45);
            this.rdoPowershell.TabIndex = 4;
            this.rdoPowershell.TabStop = true;
            this.rdoPowershell.Text = "Powershell";
            this.rdoPowershell.UseVisualStyleBackColor = true;
            // 
            // rdoUrl
            // 
            this.rdoUrl.AutoSize = true;
            this.rdoUrl.Location = new System.Drawing.Point(424, 318);
            this.rdoUrl.Name = "rdoUrl";
            this.rdoUrl.Size = new System.Drawing.Size(93, 45);
            this.rdoUrl.TabIndex = 4;
            this.rdoUrl.Text = "Url";
            this.rdoUrl.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(859, 44);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(188, 58);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1075, 44);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(188, 58);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtPowershell
            // 
            this.txtPowershell.BackColor = System.Drawing.Color.Blue;
            this.txtPowershell.Font = new System.Drawing.Font("Inconsolata", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPowershell.ForeColor = System.Drawing.Color.White;
            this.txtPowershell.Location = new System.Drawing.Point(31, 403);
            this.txtPowershell.Multiline = true;
            this.txtPowershell.Name = "txtPowershell";
            this.txtPowershell.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPowershell.Size = new System.Drawing.Size(1250, 391);
            this.txtPowershell.TabIndex = 7;
            // 
            // ActionDefinitionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 806);
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
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActionDefinitionForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Save";
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


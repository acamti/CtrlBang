using System.ComponentModel;

namespace AcamTi.CtrlBang.Forms
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
            this.lstActionDefinitions = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // lblShortcut
            // 
            this.lblShortcut.AutoSize = true;
            this.lblShortcut.Location = new System.Drawing.Point(299, 48);
            this.lblShortcut.Name = "lblShortcut";
            this.lblShortcut.Size = new System.Drawing.Size(166, 32);
            this.lblShortcut.TabIndex = 1;
            this.lblShortcut.Text = "WIN + Enter\r\n";
            this.lblShortcut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // btnSetShortcut
            // 
            this.btnSetShortcut.Location = new System.Drawing.Point(27, 21);
            this.btnSetShortcut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSetShortcut.Name = "btnSetShortcut";
            this.btnSetShortcut.Size = new System.Drawing.Size(267, 83);
            this.btnSetShortcut.TabIndex = 2;
            this.btnSetShortcut.Text = "Set Master Shortcut";
            this.btnSetShortcut.UseVisualStyleBackColor = true;
            this.btnSetShortcut.Click += new System.EventHandler(this.btnSetShortcut_Click);

            // 
            // lstActionDefinitions
            // 
            this.lstActionDefinitions.Columns.AddRange(
                new System.Windows.Forms.ColumnHeader[]
                {
                    this.columnHeader1, this.columnHeader2, this.columnHeader3
                }
            );

            this.lstActionDefinitions.FullRowSelect = true;
            this.lstActionDefinitions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstActionDefinitions.HideSelection = false;
            this.lstActionDefinitions.LabelWrap = false;
            this.lstActionDefinitions.Location = new System.Drawing.Point(17, 253);
            this.lstActionDefinitions.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lstActionDefinitions.MultiSelect = false;
            this.lstActionDefinitions.Name = "lstActionDefinitions";
            this.lstActionDefinitions.ShowGroups = false;
            this.lstActionDefinitions.Size = new System.Drawing.Size(1382, 610);
            this.lstActionDefinitions.TabIndex = 3;
            this.lstActionDefinitions.UseCompatibleStateImageBehavior = false;
            this.lstActionDefinitions.View = System.Windows.Forms.View.Details;

            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 331;

            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Shortcut";
            this.columnHeader2.Width = 296;

            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Content";
            this.columnHeader3.Width = 697;

            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(1120, 183);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(275, 50);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);

            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(538, 180);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(275, 50);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(13, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1400, 5);
            this.label1.TabIndex = 6;

            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(829, 180);
            this.btnModify.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(275, 50);
            this.btnModify.TabIndex = 7;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);

            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(18, 882);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1388, 2);
            this.label2.TabIndex = 8;

            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1192, 925);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(197, 64);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 1011);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lstActionDefinitions);
            this.Controls.Add(this.btnSetShortcut);
            this.Controls.Add(this.lblShortcut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstActionDefinitions;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lblShortcut;
        private System.Windows.Forms.Button btnSetShortcut;

        #endregion
    }
}


using System.ComponentModel;

namespace AcamTi.KeyboardShortcutManager.Forms
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // lblShortcut
            // 
            this.lblShortcut.AutoSize = true;
            this.lblShortcut.Location = new System.Drawing.Point(112, 20);
            this.lblShortcut.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblShortcut.Name = "lblShortcut";
            this.lblShortcut.Size = new System.Drawing.Size(48, 13);
            this.lblShortcut.TabIndex = 1;
            this.lblShortcut.Text = "WIN + Z";
            this.lblShortcut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // btnSetShortcut
            // 
            this.btnSetShortcut.Location = new System.Drawing.Point(10, 9);
            this.btnSetShortcut.Margin = new System.Windows.Forms.Padding(1);
            this.btnSetShortcut.Name = "btnSetShortcut";
            this.btnSetShortcut.Size = new System.Drawing.Size(100, 35);
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
            this.lstActionDefinitions.Location = new System.Drawing.Point(5, 76);
            this.lstActionDefinitions.MultiSelect = false;
            this.lstActionDefinitions.Name = "lstActionDefinitions";
            this.lstActionDefinitions.ShowGroups = false;
            this.lstActionDefinitions.Size = new System.Drawing.Size(525, 258);
            this.lstActionDefinitions.TabIndex = 3;
            this.lstActionDefinitions.UseCompatibleStateImageBehavior = false;
            this.lstActionDefinitions.View = System.Windows.Forms.View.Details;

            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 143;

            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Shortcut";
            this.columnHeader2.Width = 74;

            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Content";
            this.columnHeader3.Width = 240;

            // 
            // btnRemove
            // 
            this.button1.Location = new System.Drawing.Point(427, 340);
            this.button1.Name = "btnRemove";
            this.button1.Size = new System.Drawing.Size(103, 21);
            this.button1.TabIndex = 4;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;

            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(209, 339);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 21);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(5, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 2);
            this.label1.TabIndex = 6;

            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(318, 339);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(103, 21);
            this.btnModify.TabIndex = 7;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;

            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 372);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstActionDefinitions);
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

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lstActionDefinitions;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lblShortcut;
        private System.Windows.Forms.Button btnSetShortcut;

        #endregion
    }
}


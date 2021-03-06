﻿namespace SqlNotebook {
    partial class ImportPreviewForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this._methodGrp = new System.Windows.Forms.GroupBox();
            this._methodLinkRad = new System.Windows.Forms.RadioButton();
            this._methodCopyRad = new System.Windows.Forms.RadioButton();
            this._tablesGrp = new System.Windows.Forms.GroupBox();
            this._selectNoneBtn = new System.Windows.Forms.Button();
            this._selectAllBtn = new System.Windows.Forms.Button();
            this._listBox = new System.Windows.Forms.CheckedListBox();
            this._renameTableBtn = new System.Windows.Forms.Button();
            this._okBtn = new System.Windows.Forms.Button();
            this._cancelBtn = new System.Windows.Forms.Button();
            this._csvHeaderChk = new System.Windows.Forms.CheckBox();
            this._methodGrp.SuspendLayout();
            this._tablesGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // _methodGrp
            // 
            this._methodGrp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._methodGrp.Controls.Add(this._methodLinkRad);
            this._methodGrp.Controls.Add(this._methodCopyRad);
            this._methodGrp.Location = new System.Drawing.Point(12, 208);
            this._methodGrp.Name = "_methodGrp";
            this._methodGrp.Size = new System.Drawing.Size(281, 79);
            this._methodGrp.TabIndex = 1;
            this._methodGrp.TabStop = false;
            this._methodGrp.Text = "Method";
            // 
            // _methodLinkRad
            // 
            this._methodLinkRad.AutoSize = true;
            this._methodLinkRad.Checked = true;
            this._methodLinkRad.Location = new System.Drawing.Point(6, 22);
            this._methodLinkRad.Name = "_methodLinkRad";
            this._methodLinkRad.Size = new System.Drawing.Size(242, 19);
            this._methodLinkRad.TabIndex = 0;
            this._methodLinkRad.TabStop = true;
            this._methodLinkRad.Text = "Create a read-only &link to the source data";
            this._methodLinkRad.UseVisualStyleBackColor = true;
            // 
            // _methodCopyRad
            // 
            this._methodCopyRad.AutoSize = true;
            this._methodCopyRad.Location = new System.Drawing.Point(6, 47);
            this._methodCopyRad.Name = "_methodCopyRad";
            this._methodCopyRad.Size = new System.Drawing.Size(249, 19);
            this._methodCopyRad.TabIndex = 1;
            this._methodCopyRad.TabStop = true;
            this._methodCopyRad.Text = "&Copy all source data into the notebook file";
            this._methodCopyRad.UseVisualStyleBackColor = true;
            // 
            // _tablesGrp
            // 
            this._tablesGrp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tablesGrp.Controls.Add(this._selectNoneBtn);
            this._tablesGrp.Controls.Add(this._selectAllBtn);
            this._tablesGrp.Controls.Add(this._listBox);
            this._tablesGrp.Controls.Add(this._renameTableBtn);
            this._tablesGrp.Location = new System.Drawing.Point(12, 37);
            this._tablesGrp.Name = "_tablesGrp";
            this._tablesGrp.Size = new System.Drawing.Size(281, 165);
            this._tablesGrp.TabIndex = 0;
            this._tablesGrp.TabStop = false;
            this._tablesGrp.Text = "Tables to import";
            // 
            // _selectNoneBtn
            // 
            this._selectNoneBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._selectNoneBtn.Location = new System.Drawing.Point(187, 95);
            this._selectNoneBtn.Name = "_selectNoneBtn";
            this._selectNoneBtn.Size = new System.Drawing.Size(88, 26);
            this._selectNoneBtn.TabIndex = 12;
            this._selectNoneBtn.Text = "Select &none";
            this._selectNoneBtn.UseVisualStyleBackColor = true;
            this._selectNoneBtn.Click += new System.EventHandler(this.SelectNoneBtn_Click);
            // 
            // _selectAllBtn
            // 
            this._selectAllBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._selectAllBtn.Location = new System.Drawing.Point(187, 63);
            this._selectAllBtn.Name = "_selectAllBtn";
            this._selectAllBtn.Size = new System.Drawing.Size(88, 26);
            this._selectAllBtn.TabIndex = 11;
            this._selectAllBtn.Text = "Select &all";
            this._selectAllBtn.UseVisualStyleBackColor = true;
            this._selectAllBtn.Click += new System.EventHandler(this.SelectAllBtn_Click);
            // 
            // _listBox
            // 
            this._listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._listBox.IntegralHeight = false;
            this._listBox.Location = new System.Drawing.Point(6, 22);
            this._listBox.Name = "_listBox";
            this._listBox.Size = new System.Drawing.Size(175, 134);
            this._listBox.TabIndex = 6;
            this._listBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // _renameTableBtn
            // 
            this._renameTableBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._renameTableBtn.Location = new System.Drawing.Point(187, 22);
            this._renameTableBtn.Name = "_renameTableBtn";
            this._renameTableBtn.Size = new System.Drawing.Size(88, 26);
            this._renameTableBtn.TabIndex = 7;
            this._renameTableBtn.Text = "&Rename...";
            this._renameTableBtn.UseVisualStyleBackColor = true;
            this._renameTableBtn.Click += new System.EventHandler(this.RenameTableBtn_Click);
            // 
            // _okBtn
            // 
            this._okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._okBtn.Location = new System.Drawing.Point(111, 302);
            this._okBtn.Name = "_okBtn";
            this._okBtn.Size = new System.Drawing.Size(88, 26);
            this._okBtn.TabIndex = 3;
            this._okBtn.Text = "Import";
            this._okBtn.UseVisualStyleBackColor = true;
            this._okBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // _cancelBtn
            // 
            this._cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelBtn.Location = new System.Drawing.Point(205, 302);
            this._cancelBtn.Name = "_cancelBtn";
            this._cancelBtn.Size = new System.Drawing.Size(88, 26);
            this._cancelBtn.TabIndex = 4;
            this._cancelBtn.Text = "Cancel";
            this._cancelBtn.UseVisualStyleBackColor = true;
            // 
            // _csvHeaderChk
            // 
            this._csvHeaderChk.AutoSize = true;
            this._csvHeaderChk.Checked = true;
            this._csvHeaderChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this._csvHeaderChk.Location = new System.Drawing.Point(12, 12);
            this._csvHeaderChk.Name = "_csvHeaderChk";
            this._csvHeaderChk.Size = new System.Drawing.Size(159, 19);
            this._csvHeaderChk.TabIndex = 5;
            this._csvHeaderChk.Text = "This file has a &header row";
            this._csvHeaderChk.UseVisualStyleBackColor = true;
            // 
            // ImportPreviewForm
            // 
            this.AcceptButton = this._okBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._cancelBtn;
            this.ClientSize = new System.Drawing.Size(305, 340);
            this.Controls.Add(this._csvHeaderChk);
            this.Controls.Add(this._methodGrp);
            this.Controls.Add(this._tablesGrp);
            this.Controls.Add(this._cancelBtn);
            this.Controls.Add(this._okBtn);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(321, 379);
            this.Name = "ImportPreviewForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import";
            this._methodGrp.ResumeLayout(false);
            this._methodGrp.PerformLayout();
            this._tablesGrp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button _okBtn;
        private System.Windows.Forms.Button _cancelBtn;
        private System.Windows.Forms.CheckedListBox _listBox;
        private System.Windows.Forms.Button _renameTableBtn;
        private System.Windows.Forms.RadioButton _methodLinkRad;
        private System.Windows.Forms.RadioButton _methodCopyRad;
        private System.Windows.Forms.Button _selectNoneBtn;
        private System.Windows.Forms.Button _selectAllBtn;
        private System.Windows.Forms.CheckBox _csvHeaderChk;
        private System.Windows.Forms.GroupBox _tablesGrp;
        private System.Windows.Forms.GroupBox _methodGrp;
    }
}
﻿namespace WinNetMeter.UserControls
{
    partial class AppUpdater
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.BtnCheckUpdates = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Title.Location = new System.Drawing.Point(6, 6);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(174, 25);
            this.Title.TabIndex = 0;
            this.Title.Text = "Check for Updates";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(8, 39);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(84, 13);
            this.Description.TabIndex = 1;
            this.Description.Text = "Get new version";
            // 
            // BtnCheckUpdates
            // 
            this.BtnCheckUpdates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCheckUpdates.Location = new System.Drawing.Point(5, 67);
            this.BtnCheckUpdates.Name = "BtnCheckUpdates";
            this.BtnCheckUpdates.Size = new System.Drawing.Size(117, 28);
            this.BtnCheckUpdates.TabIndex = 34;
            this.BtnCheckUpdates.Text = "Check for Updates";
            this.BtnCheckUpdates.UseVisualStyleBackColor = true;
            this.BtnCheckUpdates.Click += new System.EventHandler(this.BtnCheckUpdates_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCancel.Location = new System.Drawing.Point(128, 67);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(116, 26);
            this.BtnCancel.TabIndex = 35;
            this.BtnCancel.Text = "Cancel Update";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // AppUpdater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnCheckUpdates);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Title);
            this.Name = "AppUpdater";
            this.Size = new System.Drawing.Size(250, 98);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Button BtnCheckUpdates;
        private System.Windows.Forms.Button BtnCancel;
    }
}
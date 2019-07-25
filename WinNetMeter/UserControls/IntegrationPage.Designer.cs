﻿namespace WinNetMeter.UserControls
{
    partial class IntegrationPage
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
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape7 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label12 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.BtnUninstall = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.BtnShow = new System.Windows.Forms.Button();
            this.BtnHide = new System.Windows.Forms.Button();
            this.LinkRefresh = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 10;
            this.lineShape4.X2 = 10;
            this.lineShape4.Y1 = 3;
            this.lineShape4.Y2 = 482;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape7,
            this.lineShape4});
            this.shapeContainer1.Size = new System.Drawing.Size(568, 485);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape7
            // 
            this.lineShape7.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape7.Name = "lineShape7";
            this.lineShape7.X1 = 21;
            this.lineShape7.X2 = 559;
            this.lineShape7.Y1 = 60;
            this.lineShape7.Y2 = 60;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(29, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 25);
            this.label12.TabIndex = 45;
            this.label12.Text = "Integration";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label21.Location = new System.Drawing.Point(29, 219);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(135, 25);
            this.label21.TabIndex = 51;
            this.label21.Text = "Uninstall Shell";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label17.Location = new System.Drawing.Point(29, 68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(163, 25);
            this.label17.TabIndex = 50;
            this.label17.Text = "Re-Register Shell";
            // 
            // BtnUninstall
            // 
            this.BtnUninstall.BackColor = System.Drawing.Color.Transparent;
            this.BtnUninstall.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnUninstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUninstall.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUninstall.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnUninstall.Location = new System.Drawing.Point(34, 295);
            this.BtnUninstall.Name = "BtnUninstall";
            this.BtnUninstall.Size = new System.Drawing.Size(130, 34);
            this.BtnUninstall.TabIndex = 49;
            this.BtnUninstall.Text = "Uninstall Shell";
            this.BtnUninstall.UseVisualStyleBackColor = false;
            this.BtnUninstall.Click += new System.EventHandler(this.BtnUninstall_Click);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(31, 251);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(412, 35);
            this.label13.TabIndex = 48;
            this.label13.Text = "If you want update or uninstall WinNetMeter, you can Uninstall Shell before, \r\nth" +
    "en replace with new Version.";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(33, 101);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(410, 62);
            this.label18.TabIndex = 47;
            this.label18.Text = "If WinNetMeter is not working properly on the TaskBar, \r\nYou can try Re-Register " +
    "Shell. Before click Re-Register, please\r\nremove WinNetMeter from toolbar on the " +
    "TaskBar for better troubleshooting";
            // 
            // BtnRegister
            // 
            this.BtnRegister.BackColor = System.Drawing.Color.Transparent;
            this.BtnRegister.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegister.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegister.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnRegister.Location = new System.Drawing.Point(36, 165);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(128, 35);
            this.BtnRegister.TabIndex = 46;
            this.BtnRegister.Text = "Re-Register Shell";
            this.BtnRegister.UseVisualStyleBackColor = false;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(29, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 52;
            this.label1.Text = "Shell Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 53;
            this.label2.Text = "Status :";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(74, 380);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(63, 15);
            this.lblStatus.TabIndex = 54;
            this.lblStatus.Text = "Not Active";
            // 
            // BtnShow
            // 
            this.BtnShow.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnShow.FlatAppearance.BorderSize = 0;
            this.BtnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnShow.Location = new System.Drawing.Point(34, 408);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(130, 35);
            this.BtnShow.TabIndex = 55;
            this.BtnShow.Text = "Show Shell";
            this.BtnShow.UseVisualStyleBackColor = false;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // BtnHide
            // 
            this.BtnHide.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.BtnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHide.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnHide.Location = new System.Drawing.Point(175, 407);
            this.BtnHide.Name = "BtnHide";
            this.BtnHide.Size = new System.Drawing.Size(129, 36);
            this.BtnHide.TabIndex = 56;
            this.BtnHide.Text = "Hide Shell";
            this.BtnHide.UseVisualStyleBackColor = true;
            this.BtnHide.Click += new System.EventHandler(this.BtnHide_Click);
            // 
            // LinkRefresh
            // 
            this.LinkRefresh.AutoSize = true;
            this.LinkRefresh.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkRefresh.Location = new System.Drawing.Point(141, 360);
            this.LinkRefresh.Name = "LinkRefresh";
            this.LinkRefresh.Size = new System.Drawing.Size(46, 13);
            this.LinkRefresh.TabIndex = 57;
            this.LinkRefresh.TabStop = true;
            this.LinkRefresh.Text = "Refresh";
            this.LinkRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkRefresh_LinkClicked);
            // 
            // IntegrationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.LinkRefresh);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.BtnHide);
            this.Controls.Add(this.BtnShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.BtnUninstall);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "IntegrationPage";
            this.Size = new System.Drawing.Size(568, 485);
            this.Load += new System.EventHandler(this.IntegrationPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label label12;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape7;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button BtnUninstall;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.Button BtnHide;
        private System.Windows.Forms.LinkLabel LinkRefresh;
    }
}

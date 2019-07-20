﻿using System;
using System.Drawing;
using System.Windows.Forms;
using WinNetMeter.Core;
using WinNetMeter.Helper;

namespace WinNetMeter
{
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
            CleaningOnStartup();
        }

        #region custom

        private void BtnGeneral_Click(object sender, EventArgs e)
        {
            PnlSelector.Location = new Point(0, BtnGeneral.Location.Y);
            setSelected(BtnGeneral, BtnCustomization, BtnDatabase, BtnIntegrate, BtnAbout);
            tabControl1.SelectedTab = tabPage1;
        }

        private void BtnIntegrate_Click(object sender, EventArgs e)
        {
            PnlSelector.Location = new Point(0, BtnIntegrate.Location.Y);
            setSelected(BtnIntegrate, BtnDatabase, BtnGeneral, BtnCustomization, BtnAbout);
            tabControl1.SelectedTab = tabPage4;
        }

        private void BtnCustomization_Click(object sender, EventArgs e)
        {
            PnlSelector.Location = new Point(0, BtnCustomization.Location.Y);
            setSelected(BtnCustomization, BtnGeneral, BtnDatabase, BtnIntegrate, BtnAbout);
            tabControl1.SelectedTab = tabPage2;
        }

        private void setSelected(Button selectedBtn, Button btn1, Button btn2, Button btn3, Button btn4)
        {
            selectedBtn.BackColor = ColorTranslator.FromHtml("#F0F0F0");
            btn1.BackColor = Color.Transparent;
            btn2.BackColor = Color.Transparent;
            btn3.BackColor = Color.Transparent;
            btn4.BackColor = Color.Transparent;
        }

        private void BtnDatabase_Click(object sender, EventArgs e)
        {
            PnlSelector.Location = new Point(0, BtnDatabase.Location.Y);
            setSelected(BtnDatabase, BtnIntegrate, BtnGeneral, BtnCustomization, BtnAbout);
            tabControl1.SelectedTab = tabPage3;
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            PnlSelector.Location = new Point(0, BtnAbout.Location.Y);
            setSelected(BtnAbout, BtnGeneral, BtnCustomization, BtnDatabase, BtnIntegrate);
            tabControl1.SelectedTab = tabPage5;
        }

        #endregion custom

        private void Main_Load(object sender, EventArgs e)
        {
            var args = Environment.GetCommandLineArgs();
            try
            {
                if (args[1] == "-about")
                {
                    BtnAbout.PerformClick();
                }
            }
            catch { }
        }
        private void CleaningOnStartup()
        {
            panel1.Width = 240;
            Integration integration = new Integration();
            integration.MakeUninstaller();

            FileHelper.DeleteAllIn(Environment.CurrentDirectory, "*.old");
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
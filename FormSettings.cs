using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cronometru4
{
    public partial class FormSettings : System.Windows.Forms.Form
    {
        public  int designTimer= Properties.Settings.Default.AppTimerSetting;
    private  Form form ;
        FormaEmail formaEmail = new FormaEmail();
        public Color designBackground = Properties.Settings.Default.AppColorBackground1;//Pentru UnitTest
        public Color designBackgroundBtn = Properties.Settings.Default.AppColor;//Pentru UnitTest

        public static int tipCronometru =Properties.Settings.Default.AppTimerSetting;//Pentru UnitTest
        public FormSettings(Form MainForm)
        {
            InitializeComponent();
            form = MainForm;
            if (Properties.Settings.Default.AppTimerSetting == 1)
                rdBtnFormat0.Checked = true;
            else
                rdBtnFormat1.Checked = true;
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            Properties.Settings.Default.AppTimerSetting = 1;
          
            Properties.Settings.Default.Save();
          
        }

        private void rdBtnFormat1_CheckedChanged(object sender, EventArgs e)
        {

            
            Properties.Settings.Default.AppTimerSetting = 0;
            
            Properties.Settings.Default.Save();
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void btnColor_Click(object sender, EventArgs e)
        {



            form.culoareBacKground = Color.FromArgb(153, 153, 235);
            form.culoareButoane = Color.FromArgb(212, 182, 101);
            Properties.Settings.Default.AppColor = form.culoareButoane;
            Properties.Settings.Default.AppColorBackground1 = form.culoareBacKground;
            Properties.Settings.Default.Save();
            form.SetareCuloare0();
            SeteazaCuloare();


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            
            


        


        }

        private void FormSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            
           



        }
        public void SeteazaCuloare()
        {
           
            btnLightMode.BackColor = form.culoareButoane;
            btnDarkMode.BackColor = form.culoareButoane;
            BackColor = form.culoareBacKground;


        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            SeteazaCuloare();
        }

        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            form.culoareBacKground = Color.FromArgb(64, 64, 64);
            form.culoareButoane = Color.FromArgb(68, 68 ,132);
            Properties.Settings.Default.AppColor = form.culoareButoane;           
            Properties.Settings.Default.AppColorBackground1 = form.culoareBacKground;
            Properties.Settings.Default.Save();
            form.SetareCuloare0();
            SeteazaCuloare();
        }
    }
}

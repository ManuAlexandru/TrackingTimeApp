using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Cronometru4
{
    public partial class FormaEmail : System.Windows.Forms.Form
    {
        Form form1=new Form();
        public FormaEmail()
        {
            InitializeComponent();
            


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var smptClient = new SmtpClient("smtp.gmail.com");
            
            smptClient.Credentials = new NetworkCredential("zona.testare@gmail.com","Malboro123");
            smptClient.Port = 587;
            smptClient.EnableSsl = true;


            
            
            
            if (Regex.IsMatch(txtEmail.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                var mail = new MailMessage();
                mail.To.Add(txtEmail.Text.Trim());
                mail.From = new MailAddress("zona.testare@gmail.com");
                mail.Subject = txtSubject.Text;
                mail.Body = txtText.Text;
                mail.Priority = MailPriority.High;


                try
                {

                    smptClient.Send(mail);

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            else
                MessageBox.Show("Email introdus gresit.");
            txtText.Clear();
            txtSubject.Clear();
            txtEmail.Clear();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void SetareCuloare1()
        {
            btnSend.BackColor = form1.culoareButoane;
            BackColor = form1.culoareBacKground;
        
        }
       

        private void FormaEmail_Load(object sender, EventArgs e)
        {
            form1.culoareButoane= Properties.Settings.Default.AppColor;
            form1.culoareBacKground = Properties.Settings.Default.AppColorBackground1;
            SetareCuloare1();

        }
        


    }
}

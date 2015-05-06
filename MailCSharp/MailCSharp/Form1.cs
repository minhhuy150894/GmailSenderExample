using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net.Mime;
namespace MailCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient(smtp.Text, 587);
                client.EnableSsl = true;
                client.Timeout = 30000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential(username.Text, password.Text);
                MailMessage msg = new MailMessage();
                msg.To.Add(to.Text);
                msg.From = new MailAddress(from.Text);
                msg.Subject = subject.Text;
                msg.Body = messages.Text;
                client.Send(msg);
                MessageBox.Show("Successfully Sent Message!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/settings/security/lesssecureapps");
        }

        private void viewTipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tips frm = new Tips();
            frm.TopMost = true;
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Default SMTP Server for Gmail is: smtp.gmail.com", "What's is SMTP Server?");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        Boolean flag;
        int x, y;
        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            x = e.X;
            y = e.Y;
        }

        private void menuStrip1_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag)
            {
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }
        Boolean flag2;
        int x2, y2;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            flag2 = true;
            x2 = e.X;
            y2 = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            flag2 = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag2)
            {
                this.SetDesktopLocation(Cursor.Position.X - x2, Cursor.Position.Y - y2);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("G-Sender \na simple C# project \nby Nguyen Minh Huy\nEmail: minhhuy150894@gmail.com", "About");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MailCSharp
{
    public partial class Tips : Form
    {
        public Tips()
        {
            InitializeComponent();
        }
        Boolean flag;
        int x, y;

        private void button1_Click(object sender, EventArgs e)
        {
            Tips.ActiveForm.Close();
        }

        private void Tips_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            x = e.X;
            y = e.Y;
        }

        private void Tips_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void Tips_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag)
            {
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }
    }
}

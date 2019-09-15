using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATTENDANCE_MANAGEMENT_SYSTEM_REQUIREMENT
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void username_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (username.Text == "User Name")
            {
                username.Text = "";
            }

        }

        private void username_KeyUp(object sender, KeyEventArgs e)
        {

            if (username.Text == "")
            {
                username.Text = "User Name";
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (Password.Text == "********Password******")
            {
                Password.Text = "";
            }

          
        }

        private void Password_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Password_KeyUp(object sender, KeyEventArgs e)
        {
            if (Password.Text == "")
            {
                Password.Text = "********Password******";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

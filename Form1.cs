using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Market_management_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("please enter all fields.", "validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Hardcoded credentials
            string correctUsername = "admin";
            string correctPassword = "password123";

            // Check credentials
            if (textBox1.Text == correctUsername && textBox2.Text == correctPassword)
            {
                Market mt = new Market();
                mt.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

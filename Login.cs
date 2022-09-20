using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xanax
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void TxtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtUser_Click(object sender, EventArgs e)
        {
            TxtUser.Clear();
            TxtUser.ForeColor = Color.White;
        }

        private void TxtPass_Click(object sender, EventArgs e)
        {
            TxtPass.Clear();
            TxtPass.ForeColor = Color.White;
            TxtPass.PasswordChar = '•';
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtUser.Text == "pkdorxfree" && TxtPass.Text == "free")
            {
                Form1 se_form = new Form1();
                se_form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User ou password invalido");
            }
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

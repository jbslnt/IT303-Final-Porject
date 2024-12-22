using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApplication
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            txtfldUsername.KeyDown += new KeyEventHandler(OnKeyDownHandler);
            txtfldPassword.KeyDown += new KeyEventHandler(OnKeyDownHandler);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            panel1_Login.Visible = false;
            panel2_Login.Visible = false;
            wrongLabel.Visible  = false;
        }

        private void cmbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbUserType.SelectedIndex == 0)
            {
                panel1_Login.Visible = false;
                panel2_Login.Visible = true;
            }
            else if(cmbUserType.SelectedIndex == 1)
            {
                panel1_Login.Visible = true;
                panel2_Login.Visible = false;
            }
            

        }

        private void chkbx_Password_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbx_Password.Checked == true)
            {
                txtfldPassword.PasswordChar = '\0';
                chkbx_Password.Text = "Hide Password";
            }
            else
            {
                txtfldPassword.PasswordChar = '*';
                chkbx_Password.Text = "Show Password";
            }
        }


        private void btn_InstructorLogin_Click(object sender, EventArgs e)
        {
            if (txtfldUsername.Text == "meow" && txtfldPassword.Text == "meow")
            {
                wrongLabel.Visible = false;

                Instructor instructorForm = new Instructor();
                instructorForm.Show();
                MessageBox.Show("Instructor form should now be visible.");

                this.Hide();
            }
            else
            {
                wrongLabel.Visible = true;
            }
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_InstructorLogin_Click(sender, e); 
                e.SuppressKeyPress = true; 
            }
        }


        private void linkLabelSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
        }
    }
}

using QuizApplication.Instructor_UC;
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
    public partial class Instructor : Form
    {
        public Instructor()
        {
            InitializeComponent();
        }

        private void Instructor_Load(object sender, EventArgs e)
        {
           addNewQuestion1.Visible = false;
           updateQuestion1.Visible = false;
            viewAndDelete1.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addNewQuestion1.Visible = true;
            addNewQuestion1.BringToFront();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateQuestion1.Visible = true;
            updateQuestion1.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();

            loginForm.Show();

            this.Close(); 
        }

        private void btnViewDelete_Click(object sender, EventArgs e)
        {
            viewAndDelete1.Visible = true;
            viewAndDelete1.BringToFront();
        }
    }
}

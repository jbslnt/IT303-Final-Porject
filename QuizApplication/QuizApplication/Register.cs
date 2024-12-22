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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            panel1_Register.Visible = false;
        }

        private void cmbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUserType.SelectedIndex == 0)
            {
                panel1_Register.Visible = true;
                panel2_Register.Visible = false;

            }
            else if (cmbUserType.SelectedIndex == 1)
            {
                panel1_Register.Visible = false;
                panel2_Register.Visible = true;
                
            }
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApplication.Instructor_UC
{
    public partial class AddNewQuestion : UserControl
    {

        functions fn = new functions();
        String query;
        DataSet dataSet;
        Int64 questionNo = 1;


        public AddNewQuestion()
        {
            InitializeComponent();
        }

        private void AddNewQuestion_Load(object sender, EventArgs e)
        {
            query = "SELECT MAX(QSet) FROM Questions"; 
            dataSet = fn.getData(query);

            if (dataSet.Tables[0].Rows.Count != 0 && dataSet.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 id = Int64.Parse(dataSet.Tables[0].Rows[0][0].ToString());
                txtSet.Text = (id + 1).ToString();
            }
            else
            {
                txtSet.Text = "1";
            }

            qNumber.Text = questionNo.ToString(); 
            lblNoSet.Visible = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            String QSet = txtSet.Text;
            String QNumber = questionNo.ToString();
            String Question = txtQuestion.Text;
            String OptionA = txtOptionA.Text;
            String OptionB = txtOptionB.Text;
            String OptionC = txtOptionC.Text;
            String OptionD = txtOptionD.Text;
            String Answer = txtAnswer.Text;


            query = "INSERT INTO Questions (QSet, QNumber, Question, OptionA, OptionB, OptionC, OptionD, Answer) values ('"+QSet+ "', '"+QNumber+"', '"+Question+"', '"+OptionA+ "', '"+OptionB+ "', '"+OptionC+ "', '"+OptionD+"', '"+Answer+"')";
            fn.setData(query, "Question Added.");

            //clearAll();
            questionNo++;
            qNumber.Text = questionNo.ToString();

        }

        public void clearAll()
        {
            txtQuestion.Clear();
            txtOptionA.Clear();
            txtOptionB.Clear();
            txtOptionC.Clear();
            txtOptionD.Clear();
            txtAnswer.Clear();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Unsaved Data Will be Lost", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                clearAll();
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Set will be Changed.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                txtSet.Text = (Int64.Parse(txtSet.Text.ToString())+1).ToString();
                qNumber.Text = "1";
            }

        }

        private void txtSet_TextChanged(object sender, EventArgs e)
        {
            if (txtSet.Text != "")
            {
                clearAll();
                query = "SELECT QNumber from Questions WHERE QSet = '" + txtSet.Text + "'";
                dataSet = fn.getData(query);

                if (dataSet.Tables[0].Rows.Count != 0 && dataSet.Tables[0].Rows[0][0].ToString() != "")
                {
                    qNumber.Text = (dataSet.Tables[0].Rows.Count + 1).ToString();
                    questionNo = Int64.Parse(qNumber.Text.ToString());
                    lblNoSet.Visible = false;  
                }
                else
                {
                    qNumber.Text = "1";
                    questionNo = Int64.Parse(qNumber.Text.ToString());
                    lblNoSet.Visible = true;  
                }
            }
            else
            {
                lblNoSet.Visible = false;  
            }
        }

    }
}

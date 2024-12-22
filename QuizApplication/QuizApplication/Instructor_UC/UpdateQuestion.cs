using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuizApplication.Instructor_UC
{
    public partial class UpdateQuestion : UserControl
    {
        functions fn = new functions();
        String query;

        public UpdateQuestion()
        {
            InitializeComponent();
        }

        private void UpdateQuestion_Load(object sender, EventArgs e)
        {
            LoadQuestionSets(); 
        }

        private void cmbSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbQNumber.Items.Clear();
            query = "SELECT QNumber FROM Questions WHERE QSet = '" + cmbSet.Text + "'";
            DataSet dataSet = fn.getData(query);

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                cmbQNumber.Items.Add(row["QNumber"].ToString());
            }
        }

        private void cmbQNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = $"SELECT Question, OptionA, OptionB, OptionC, OptionD, Answer FROM Questions WHERE QSet = '{cmbSet.Text}' AND QNumber = '{cmbQNumber.Text}'";
            DataSet dataSet = fn.getData(query);

            if (dataSet.Tables[0].Rows.Count > 0)
            {
                txtQuestion.Text = dataSet.Tables[0].Rows[0]["Question"].ToString();
                txtOptionA.Text = dataSet.Tables[0].Rows[0]["OptionA"].ToString();
                txtOptionB.Text = dataSet.Tables[0].Rows[0]["OptionB"].ToString();
                txtOptionC.Text = dataSet.Tables[0].Rows[0]["OptionC"].ToString();
                txtOptionD.Text = dataSet.Tables[0].Rows[0]["OptionD"].ToString();
                txtAnswer.Text = dataSet.Tables[0].Rows[0]["Answer"].ToString();
            }
            else
            {
                MessageBox.Show("No data found for the selected question!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            txtQuestion.Clear();
            txtOptionA.Clear();
            txtOptionB.Clear();
            txtOptionC.Clear();
            txtOptionD.Clear();
            txtAnswer.Clear();
            cmbSet.SelectedIndex = -1;
            cmbQNumber.SelectedIndex = -1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbQNumber.SelectedIndex != -1)
            {
                String QSet = cmbSet.Text.Trim();
                String QNumber = cmbQNumber.SelectedItem.ToString().Trim();
                String Question = txtQuestion.Text.Trim();
                String OptionA = txtOptionA.Text.Trim();
                String OptionB = txtOptionB.Text.Trim();
                String OptionC = txtOptionC.Text.Trim();
                String OptionD = txtOptionD.Text.Trim();
                String Answer = txtAnswer.Text.Trim();

                query = "UPDATE Questions " +
                        "SET Question = @Question, OptionA = @OptionA, OptionB = @OptionB, " +
                        "OptionC = @OptionC, OptionD = @OptionD, Answer = @Answer " +
                        "WHERE QSet = @QSet AND QNumber = @QNumber";

                using (SqlConnection conn = fn.getConnection())
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Question", Question);
                            cmd.Parameters.AddWithValue("@OptionA", OptionA);
                            cmd.Parameters.AddWithValue("@OptionB", OptionB);
                            cmd.Parameters.AddWithValue("@OptionC", OptionC);
                            cmd.Parameters.AddWithValue("@OptionD", OptionD);
                            cmd.Parameters.AddWithValue("@Answer", Answer);
                            cmd.Parameters.AddWithValue("@QSet", QSet);
                            cmd.Parameters.AddWithValue("@QNumber", QNumber);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show($"Question Number: {QNumber}\nQuestion Set: {QSet}\nwas successfully updated.",
                                                "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No matching question found to update.",
                                                "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a Question First.", "Message !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clearAll(); 
            LoadQuestionSets(); 
            MessageBox.Show("Form has been refreshed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadQuestionSets()
        {
            try
            {
                cmbSet.Items.Clear(); 
                query = "SELECT DISTINCT QSet FROM Questions"; 
                DataSet dataSet = fn.getData(query);

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    cmbSet.Items.Add(row["QSet"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while refreshing question sets: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

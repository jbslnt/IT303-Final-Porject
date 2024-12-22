using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApplication.Instructor_UC
{
    public partial class ViewAndDelete : UserControl
    {
        functions fn = new functions();
        String query;


        public ViewAndDelete()
        {
            InitializeComponent();
        }

        private void ViewAndDelete_Load(object sender, EventArgs e)
        {
            cmbSet.Items.Clear();
            cmbSet.Items.Add("All Questions");
            query = "SELECT DISTINCT QSet FROM Questions";
            DataSet dataSet = fn.getData(query);

            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                cmbSet.Items.Add(dataSet.Tables[0].Rows[i][0].ToString());
            }
        }

        private void cmbSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSet.SelectedIndex != -1) 
            {
                string query;

                if (cmbSet.Text == "All Questions")
                {
                    query = "SELECT ID, QSet, QNumber, Question, OptionA, OptionB, OptionC, OptionD, Answer FROM Questions";
                }
                else
                {
                    query = "SELECT ID, QSet, QNumber, Question, OptionA, OptionB, OptionC, OptionD, Answer FROM Questions WHERE QSet = @QSet";
                }

                try
                {
                    using (SqlConnection conn = fn.getConnection())
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            if (cmbSet.Text != "All Questions")
                            {
                                cmd.Parameters.AddWithValue("@QSet", cmbSet.Text);
                            }

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataSet dataSet = new DataSet();
                            adapter.Fill(dataSet);

                            dataGridViewDelete.DataSource = dataSet.Tables[0];
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a valid set from the dropdown.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewDelete.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Are you sure you want to delete this question?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int selectedRowIndex = dataGridViewDelete.SelectedRows[0].Index;
                    int questionID = Convert.ToInt32(dataGridViewDelete.Rows[selectedRowIndex].Cells["ID"].Value); 

                    string query = "DELETE FROM Questions WHERE ID = @ID";

                    try
                    {
                        using (SqlConnection conn = fn.getConnection())
                        {
                            conn.Open();
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@ID", questionID); 

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Question deleted successfully.", "Deletion Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    cmbSet_SelectedIndexChanged(sender, e);
                                }
                                else
                                {
                                    MessageBox.Show("No matching question found to delete.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
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
                MessageBox.Show("Please select a question to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       

    }
}

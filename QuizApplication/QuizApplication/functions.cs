using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApplication
{
    internal class functions
    {
        public SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-L26QNKV;database = QwizzlerDB;integrated security =TRUE ";
            return con;
        }

        public DataSet getData(string query)
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand(query, conn); 
            SqlDataAdapter adapter = new SqlDataAdapter(cmd); 
            DataSet dataSet = new DataSet();

            try
            {
                conn.Open();
                adapter.Fill(dataSet);
            }
            finally
            {
                conn.Close(); 
            }

            return dataSet;
        }

        public void setData(string query, string msg)
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand(query, conn); 
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public SqlDataReader getForCombo(String query)
        {
            SqlConnection conn = getConnection(); 
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd = new SqlCommand(query, conn);
            SqlDataReader dataReader = cmd.ExecuteReader();
            return dataReader;

        }

    }
}

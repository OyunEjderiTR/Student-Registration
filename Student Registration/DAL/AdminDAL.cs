using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Registration.DAL
{
    internal class AdminDAL
    {
        SqlConnection connection = new SqlConnection(dbConnection.dbConnect);


        #region SelectData
        public DataTable LoginData(string username, string password)
        {
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM admin WHERE username=@username AND password=@password";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                connection.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        #endregion
    }
}

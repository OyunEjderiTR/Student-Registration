using Student_Registration.BLL;
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
    internal class StudentsDAL
    {
        SqlConnection connection = new SqlConnection(dbConnection.dbConnect);


        #region SelectData
        public DataTable SelectData()
        {
            DataTable dt = new DataTable();
            
            try
            {
                string sql = "SELECT * FROM students";
                SqlCommand command = new SqlCommand(sql, connection);
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

        #region InsertData
        public bool InsertData(StudentsBLL student)
        {
            try
            {
                string sql = "INSERT INTO students(name,phone,blood,gender,email,dob,description,createdBy) VALUES(@name,@phone,@blood,@gender,@email,@dob,@description,@createdBy)";
                SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@name", student.name);
                command.Parameters.AddWithValue("@phone", student.phone);
                command.Parameters.AddWithValue("@blood", student.blood);
                command.Parameters.AddWithValue("@gender", student.gender);
                command.Parameters.AddWithValue("@email", student.email);
                command.Parameters.AddWithValue("@dob", student.dob);
                command.Parameters.AddWithValue("@description", student.description);
                command.Parameters.AddWithValue("@createdBy", loginPage.userId);

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }

            return true;
        }
        #endregion

        #region UpdateData
        public bool UpdateData(StudentsBLL student)
        {
            try
            {
                string sql = "UPDATE students Set name=@name, phone=@phone,blood=@blood, gender=@gender, email=@email, dob=@dob, description=@description, updatedBy=@updatedBy WHERE id=@id ";
                SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@name", student.name);
                command.Parameters.AddWithValue("@phone", student.phone);
                command.Parameters.AddWithValue("@blood", student.blood);
                command.Parameters.AddWithValue("@gender", student.gender);
                command.Parameters.AddWithValue("@email", student.email);
                command.Parameters.AddWithValue("@dob", student.dob);
                command.Parameters.AddWithValue("@description", student.description);
                command.Parameters.AddWithValue("@updatedBy", loginPage.userId);

                command.Parameters.AddWithValue("@id", student.id);

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }

            return true;
        }
        #endregion
    }
}

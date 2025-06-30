using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Registration
{
    internal class dbConnection
    {
        public static string dbConnect = "Data Source=UCHIHAITACHI\\SQLEXPRESS;Initial Catalog=student;Integrated Security=True;Encrypt=False";
    }
}

using Student_Registration.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_Registration
{
    public partial class loginPage : DevExpress.XtraEditors.XtraForm
    {
        public loginPage()
        {
            InitializeComponent();
        }

        AdminDAL adminDAL = new AdminDAL();
        public static string userId = "0"; 

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if(textUsername.Text != "" && textPassword.Text != "") 
            {
                DataTable adminData = adminDAL.LoginData(textUsername.Text, textPassword.Text);

                if (adminData.Rows.Count > 0)
                {
                    userId = adminData.Rows[0][0].ToString();
                    this.Hide();
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Please Enter Valid Password or Username.");
                }
            }
            else 
            {
                MessageBox.Show("Please Enter Password and Username.");
            }
                
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

using DevExpress.XtraEditors;
using Student_Registration.BLL;
using Student_Registration.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Registration
{
    public partial class StudentForm : DevExpress.XtraEditors.XtraForm
    {
        public StudentForm()
        {
            InitializeComponent();
        }
        StudentsDAL studentsDAL = new StudentsDAL();
        StudentsBLL studentsBLL = new StudentsBLL();
        private void StudentForm_Load(object sender, EventArgs e)
        {
            dgvStudent.DataSource = studentsDAL.SelectData();
        }

        void Clear()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            cmbBlood.Text = "";
            cmbGender.Text = "";
            txtEmail.Text = "";
            txtDescription.Text = "";
            dtDob.Text = "";
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (studentName.Text !="" && Phone.Text != "" && Blood.Text != "" && Email.Text != "" && Gender.Text != "" && Description.Text != "" && DOB.Text != "")
            {
                studentsBLL.name = txtName.Text;
                studentsBLL.phone = txtPhone.Text;
                studentsBLL.blood = cmbBlood.Text;
                studentsBLL.gender = cmbGender.Text;
                studentsBLL.email = txtEmail.Text;
                studentsBLL.description = txtDescription.Text;
                studentsBLL.dob = dtDob.Text;

                if (studentsDAL.InsertData(studentsBLL))
                {
                    MessageBox.Show("Data inserted Succesfully.");
                    dgvStudent.DataSource = studentsDAL.SelectData();
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("Please fill all the values");
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                if (studentName.Text != "" && Phone.Text != "" && Blood.Text != "" && Email.Text != "" && Gender.Text != "" && Description.Text != "" && DOB.Text != "")
                {
                    studentsBLL.id = int.Parse(txtId.Text);
                    studentsBLL.name = txtName.Text;
                    studentsBLL.phone = txtPhone.Text;
                    studentsBLL.blood = cmbBlood.Text;
                    studentsBLL.gender = cmbGender.Text;
                    studentsBLL.email = txtEmail.Text;
                    studentsBLL.description = txtDescription.Text;
                    studentsBLL.dob = dtDob.Text;

                    if (studentsDAL.UpdateData(studentsBLL))
                    {
                        MessageBox.Show("Data inserted Succesfully.");
                        dgvStudent.DataSource = studentsDAL.SelectData();
                        Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Please fill all the values");
                }
            }
            else
            {
                MessageBox.Show("Please select the record first.");
            }
        }

        private void gridStudent_DoubleClick(object sender, EventArgs e)
        {
            DataRow row = gridStudent.GetDataRow(gridStudent.GetSelectedRows()[0]);
            if (row == null || row[0].ToString() == "")
                return;

            tabControl.SelectedTabPage = addStudent;

            txtId.Text = row[0].ToString();
            txtName.Text = row[1].ToString();
            txtPhone.Text = row[2].ToString();
            cmbBlood.Text = row[3].ToString();
            cmbGender.Text = row[4].ToString();
            txtEmail.Text = row[5].ToString();
            dtDob.Text = row[6].ToString();
            txtDescription.Text = row[7].ToString();
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            dgvStudent.ShowPrintPreview();
        }
    }
}
using DevExpress.XtraBars;
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
    public partial class Dashboard : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThemeForm theme = new ThemeForm();
            theme.MdiParent = this;
            theme.Show();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            AboutForm about = new AboutForm();
            about.MdiParent = this;
            about.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            StudentForm student = new StudentForm();
            student.MdiParent = this;
            student.Show();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            AdminsForm admins = new AdminsForm();
            admins.MdiParent = this;
            admins.Show();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
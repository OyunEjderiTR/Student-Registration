using DevExpress.Skins;
using DevExpress.XtraEditors;
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
    public partial class ThemeForm : DevExpress.XtraEditors.XtraForm
    {
        public ThemeForm()
        {
            InitializeComponent();
        }

        private void ThemeForm_Load(object sender, EventArgs e)
        {
            foreach (SkinContainer cn in SkinManager.Default.Skins)
            {
                skinCmb.Properties.Items.Add(cn.SkinName);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(skinCmb.Text);
        }
    }
}
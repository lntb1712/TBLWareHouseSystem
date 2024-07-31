using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TBLWareHouseSystem.GUI.UserControl;

namespace TBLWareHouseSystem.GUI
{
    public partial class Main : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        ucUserGroups ucUserGroup=new ucUserGroups();
        ucUsers ucUser=new ucUsers();
        public Main()
        {
            InitializeComponent();
            ucUser.Hide();
            ucUserGroup.Hide();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            MainContainer.Controls.Clear();
            ucUser.Show();
            MainContainer.Controls.Add(ucUser);

        }

        private void btnUserGroups_Click(object sender, EventArgs e)
        {
            MainContainer.Controls.Clear();
            ucUserGroup.Show();
            MainContainer.Controls.Add(ucUserGroup);    
        }
    }
}

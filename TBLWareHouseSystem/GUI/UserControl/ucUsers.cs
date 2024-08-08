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
using TBLWareHouseSystem.DAO;
using TBLWareHouseSystem.Models;

namespace TBLWareHouseSystem.GUI.UserControl
{
    public partial class ucUsers : DevExpress.XtraEditors.XtraUserControl
    {
        UsersDAO usersDAO= new UsersDAO();
        UserGroupsDAO userGroupsDAO= new UserGroupsDAO();
        public ucUsers()
        {
            InitializeComponent();
        }

        private void ucUsers_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadDataComboBox();
        }
        private void LoadData()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("UserID",typeof(string));
            dataTable.Columns.Add("UserPassword", typeof(string));
            dataTable.Columns.Add("FullName", typeof(string));
            dataTable.Columns.Add("GroupID", typeof(string));
            dataTable.Columns.Add("UpdateTime", typeof(string));
            dataTable.Columns.Add("UpdateBy", typeof(string));
            dataTable.Columns.Add("Resign", typeof(bool));

            foreach(var item in usersDAO.getAllAccountList())
            {
                dataTable.Rows.Add(new object[]
                {
                    item.UserID,
                    item.UserPassword,
                    item.Fullname,
                    item.GroupID,
                    item.UpdateTime,
                    item.UpdateBy,
                    item.Resign,
                });
            }

            gridUser.DataSource= dataTable;
        }
        private void LoadDataComboBox()
        {
            foreach(var AC in userGroupsDAO.getAllGroupManagement())
            {
                cboGroupID.Properties.Items.Add( AC.GroupID );
            }
        }
    }
}

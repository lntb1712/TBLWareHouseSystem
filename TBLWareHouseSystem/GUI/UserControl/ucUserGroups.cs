using DevExpress.DataAccess.Sql;
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
    public partial class ucUserGroups : DevExpress.XtraEditors.XtraUserControl
    {
        UserGroupsDAO userGroupsDAO= new UserGroupsDAO();
        GroupFunctionsDAO groupFunctionsDAO= new GroupFunctionsDAO();
        string GroupID = string.Empty;
        string FullName= string.Empty;
        public ucUserGroups(string GroupID,string FullName)
        {
            InitializeComponent();
            this.GroupID = GroupID;
            this.FullName = FullName;
        }

        private void ucUserGroups_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadDataGroupFunction(GroupID);

        }
        private void LoadData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("colGroupID",typeof(string));
            dt.Columns.Add("colGroupName", typeof(string));
            dt.Columns.Add("colGroupDes", typeof(string));
            dt.Columns.Add("colUpdateTime", typeof(DateTime));
            dt.Columns.Add("colUpdateBy", typeof(string));
            foreach (var item in userGroupsDAO.getAllGroupManagement())
            {
                dt.Rows.Add(new object[]
                {
                    item.GroupID,
                    item.GroupName,
                    item.GroupDescription,
                    item.UpdateTime,
                    item.UpdateBy,
                });
            }
            gridGroup.DataSource= dt;
           
        }
        private void LoadDataGroupFunction(string GroupID)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("FunctionID",typeof(string));
            dt.Columns.Add("FunctionName",typeof (string));
            dt.Columns.Add("Device", typeof(string));
            dt.Columns.Add("IsEnable", typeof(bool));

            foreach(var item in groupFunctionsDAO.getAllGroupFunction(GroupID))
            {
                dt.Rows.Add(new object[]
                {
                    item.FunctionID,
                    item.FunctionName,
                    item.Device,
                    item.IsEnable,
                });
            }
            gridFunctions.DataSource= dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Models.GroupManagement groupManagement = new Models.GroupManagement();
           
            string GroupID=txtGroupID.Text.Trim();
            string GroupName=txtGroupName.Text.Trim();
            string GroupDes=txtGroupDes.Text.Trim();

            groupManagement.GroupID = GroupID;
            groupManagement.GroupName = GroupName;
            groupManagement.GroupDescription = GroupDes;
            groupManagement.UpdateBy=this.FullName;


            int result = userGroupsDAO.InsertGroupManagement(groupManagement);
            if (result > 0)
            {
                MessageBox.Show("Insert Successfullly!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                LoadData();
                txtGroupID.Text = string.Empty;
                txtGroupName.Text = string.Empty;
                txtGroupDes.Text = string.Empty;
                return;
            }
            else
            {
                MessageBox.Show("Insert Fail!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadData();
                txtGroupID.Text = string.Empty;
                txtGroupName.Text = string.Empty;
                txtGroupDes.Text = string.Empty;
                return;
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string GroupID= txtGroupID.Text.Trim();
            if (GroupID.Equals(""))
            {
                MessageBox.Show("Please Choose GroupID !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int result = groupFunctionsDAO.DeleteGroupFunction(GroupID);
                if (result > 0)
                {
                    int resultGroupManagement = userGroupsDAO.DeleteGroupManagement(GroupID);
                    if (resultGroupManagement > 0)
                    {
                        MessageBox.Show("Delete Successfully !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        LoadDataGroupFunction(this.GroupID);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Delete Fail !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LoadData();
                        LoadDataGroupFunction(this.GroupID);
                        return;
                    }    
                }
                else
                {
                    int resultGroupManagement = userGroupsDAO.DeleteGroupManagement(GroupID);
                    if (resultGroupManagement > 0)
                    {
                        MessageBox.Show("Delete Successfully !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        LoadDataGroupFunction(this.GroupID);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Delete Fail !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LoadData();
                        LoadDataGroupFunction(this.GroupID);
                        return;
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void gridGroupManagement_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            var rowId = gridGroupManagement.FocusedRowHandle;
            txtGroupID.Text=gridGroupManagement.GetRowCellValue(rowId,"Group ID").ToString().Trim();

        }

        private void gridFunctions_Click(object sender, EventArgs e)
        {

        }
    }
}

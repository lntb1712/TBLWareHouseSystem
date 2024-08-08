using DevExpress.Utils.Controls;
using DevExpress.Utils.Extensions;
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
using TBLWareHouseSystem.Models;
using static DevExpress.Xpo.Helpers.AssociatedCollectionCriteriaHelper;

namespace TBLWareHouseSystem.GUI
{
    public partial class Main : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {


        string UserID = string.Empty;
        string UserPassword = string.Empty;
        string Fullname = string.Empty;
        string GroupID = string.Empty;
        bool? Resign = false;

        ucUserGroups ucUserGroup;
        ucUsers ucUser = new ucUsers();
        ucStockInManagement ucStockIn = new ucStockInManagement();
        ucStockOutManagement ucStockOut = new ucStockOutManagement();
        ucMovement ucMove = new ucMovement();
        ucInventory ucInven = new ucInventory();
        ucCustomers ucCustomer = new ucCustomers();
        ucSupplier ucSuppliers = new ucSupplier();
        ucStockTaking ucStockTake = new ucStockTaking();
        ucChangePassword ucChangePass = new ucChangePassword();
        public Main(string UserID, string UserPassword, string Fullname, string GroupID, bool? Resign)
        {
            InitializeComponent();

            this.UserID = UserID;
            this.UserPassword = UserPassword;
            this.Fullname = Fullname;
            this.GroupID = GroupID;
            this.Resign = Resign;

            ucUserGroup = new ucUserGroups(this.GroupID,this.Fullname);

            ucUser.Hide();
            ucUserGroup.Hide();
            ucStockIn.Hide();
            ucStockOut.Hide();
            ucMove.Hide();
            ucInven.Hide();
            ucCustomer.Hide();
            ucSuppliers.Hide();
            ucStockTake.Hide();
            ucChangePass.Hide();
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

        private void btnStockIn_Click(object sender, EventArgs e)
        {
            MainContainer.Controls.Clear();
            ucStockIn.Show();
            MainContainer.Controls.Add(ucStockIn);
        }

        private void btnStockOut_Click(object sender, EventArgs e)
        {
            MainContainer.Controls.Clear();
            ucStockOut.Show();
            MainContainer.Controls.Add(ucStockOut);
        }

        private void btnMovements_Click(object sender, EventArgs e)
        {
            MainContainer.Controls.Clear();
            ucMove.Show();
            MainContainer.Controls.Add(ucMove);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            MainContainer.Controls.Clear();
            ucInven.Show();
            MainContainer.Controls.Add(ucInven);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            MainContainer.Controls.Clear();
            ucCustomer.Show();
            MainContainer.Controls.Add(ucCustomer);
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            MainContainer.Controls.Clear();
            ucSuppliers.Show();
            MainContainer.Controls.Add(ucSuppliers);
        }

        private void btnStockTaking_Click(object sender, EventArgs e)
        {
            MainContainer.Controls.Clear();
            ucStockTake.Show();
            MainContainer.Controls.Add(ucStockTake);
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            MainContainer.Controls.Clear();
            ucChangePass.Show();
            MainContainer.Controls.Add(ucChangePass);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            txtActual.Caption = Fullname.ToString();
            TBLWareHouseSystemEntities entities = new TBLWareHouseSystemEntities();
            List<GetGroupFunctionsList_Result> list = entities.GetGroupFunctionsList(this.GroupID).ToList();

            foreach (var item in list)
            {
                string FunctionID = item.FunctionID;
                menu.ForEachElement((el) =>
                {
                    if (el.Name.Equals(FunctionID))
                    {
                        if (item.IsEnable == true)
                        {
                            el.Enabled = true;
                        }
                        else
                        {
                            el.Enabled = false;
                        }
                    }
                });
            }
        }
    }
}

using DevExpress.DataAccess.DataFederation;
using DevExpress.Utils.About;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity.Infrastructure.Design;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TBLWareHouseSystem.Models;
using TBLWareHouseSystem.Properties;
using static DevExpress.XtraEditors.Mask.MaskSettings;
using DevExpress.DataAccess.UI.Sql;
using System.Data.Entity;
using DevExpress.Xpo.Logger.Transport;
using DevExpress.XtraDiagram.Base;
using DevExpress.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using TBLWareHouseSystem.DAO;
namespace TBLWareHouseSystem.GUI
{
    public partial class Settings : DevExpress.XtraEditors.XtraForm
    {
        ConnectDAO connectDAO= new ConnectDAO();
        public Settings()
        {
            InitializeComponent();
            string[] list = connectDAO.ReadFile();
            txtIPAddress.Text=list[0];
            txtPort.Text = list[1];
            txtDatabaseName.Text = list[2];
            txtUser.Text = list[3];
            txtPassword.Text = list[4];
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            string ipAddress = txtIPAddress.Text.Trim();
            if (ipAddress.Equals(""))
            {
                MessageBox.Show("Empty IP Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string Port= txtPort.Text.Trim();
            if (Port.Equals(""))
            {
                MessageBox.Show("Empty Port", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string DBName= txtDatabaseName.Text.Trim();
            if (DBName.Equals(""))
            {
                MessageBox.Show("Empty Database Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string User=txtUser.Text.Trim();
            if (User.Equals(""))
            {
                MessageBox.Show("Empty User", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string Password= txtPassword.Text.Trim();
            if (Password.Equals(""))
            {
                MessageBox.Show("Empty Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            string connectString= "data source ="+ipAddress+","+Port+";initial catalog="+DBName+"; user id ="+User+"; password ="+Password;

            SqlConnection conn = new SqlConnection(connectString);
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    XtraMessageBox.Show("Connect Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                XtraMessageBox.Show("Connect Fail!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
                throw;
            }
            finally { conn.Close(); }
           

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string ipAddress = txtIPAddress.Text.Trim();
            if (ipAddress.Equals(""))
            {
                MessageBox.Show("Empty IP Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string Port = txtPort.Text.Trim();
            if (Port.Equals(""))
            {
                MessageBox.Show("Empty Port", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string DBName = txtDatabaseName.Text.Trim();
            if (DBName.Equals(""))
            {
                MessageBox.Show("Empty Database Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string User = txtUser.Text.Trim();
            if (User.Equals(""))
            {
                MessageBox.Show("Empty User", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string Password = txtPassword.Text.Trim();
            if (Password.Equals(""))
            {
                MessageBox.Show("Empty Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectString = "data source =" + ipAddress + "," + Port + ";initial catalog=" + DBName + "; user id =" + User + "; password =" + Password;
            SqlConnection conn = new SqlConnection(connectString);
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    connectDAO.WriteFile(ipAddress, Port,DBName,User,Password);
                    XtraMessageBox.Show("Save Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                XtraMessageBox.Show("Save Fail!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
                throw;
            }
            finally { conn.Close(); }

        }
        
       
    }
}
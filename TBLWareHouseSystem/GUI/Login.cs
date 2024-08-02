using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TBLWareHouseSystem.DAO;
using TBLWareHouseSystem.GUI;
using TBLWareHouseSystem.Models;

namespace TBLWareHouseSystem
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        ConnectDAO connectDAO= new ConnectDAO();
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Click(object sender, EventArgs e)
        {
            string AccountUserName = txtLogin.Text.Trim();
            if (AccountUserName.Equals(""))
            {
                MessageBox.Show("Please enter user id!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string AccountPass = txtPassword.Text.Trim();
            if (AccountPass.Equals(""))
            {
                MessageBox.Show("Please enter password!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TBLWareHouseSystemEntities entities = new TBLWareHouseSystemEntities();
            AccountLogin_Result result= entities.AccountLogin(AccountUserName, AccountPass).FirstOrDefault();

            if (result!= null)
            {
                Main main= new Main(result.UserID,result.UserPassword,result.Fullname,result.GroupID,result.Resign);
                this.Hide();
                main.ShowDialog();

            }
            else
            {
                MessageBox.Show("User Name or Password is incorrect!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Text = string.Empty;
                txtPassword.Text = string.Empty;
                return;
            }

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Settings settings= new Settings();
            this.Hide();
            settings.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            string[] list = connectDAO.ReadFile();
            string connectionString = "data source=" + list[0] + "," + list[1] + ";initial catalog=" + list[2] + ";user id=" + list[3] + ";password=" + list[4];
            SqlConnection checkConnection = new SqlConnection(connectionString);
            try
            {
                checkConnection.Open();
                if (checkConnection.State == ConnectionState.Open)
                {
                    MessageBox.Show("Connect Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connect Fail! Please check Setting Database System !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                throw;
            }
            finally
            {
                checkConnection.Close();
            }
        }

        private void cboHidePassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = cboHidePassword.Checked ? '*':'\0';
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (cboHidePassword.Checked)
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}

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

namespace TBLWareHouseSystem.GUI.UserControl
{
    public partial class ucUsers : DevExpress.XtraEditors.XtraUserControl
    {
        public ucUsers()
        {
            InitializeComponent();
        }

        private void ucUsers_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            //var query = 
            //from GM in 
        }
    }
}

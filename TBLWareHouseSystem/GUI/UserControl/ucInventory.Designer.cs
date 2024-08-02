namespace TBLWareHouseSystem.GUI.UserControl
{
    partial class ucInventory
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cboCustomerID = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridInventory = new DevExpress.XtraGrid.GridControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtStockOutID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtStockOutQuantityTotal = new DevExpress.XtraEditors.TextEdit();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCustomerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockOutID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockOutQuantityTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(722, 207);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(127, 30);
            this.labelControl4.TabIndex = 57;
            this.labelControl4.Text = "Location ID";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(722, 130);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(93, 30);
            this.labelControl5.TabIndex = 58;
            this.labelControl5.Text = "Quantity";
            // 
            // cboCustomerID
            // 
            this.cboCustomerID.Location = new System.Drawing.Point(891, 204);
            this.cboCustomerID.Name = "cboCustomerID";
            this.cboCustomerID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.cboCustomerID.Properties.Appearance.Options.UseFont = true;
            this.cboCustomerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCustomerID.Size = new System.Drawing.Size(332, 36);
            this.cboCustomerID.TabIndex = 59;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridInventory;
            this.gridView1.Name = "gridView1";
            // 
            // gridInventory
            // 
            this.gridInventory.Location = new System.Drawing.Point(25, 278);
            this.gridInventory.MainView = this.gridView1;
            this.gridInventory.Name = "gridInventory";
            this.gridInventory.Size = new System.Drawing.Size(1375, 579);
            this.gridInventory.TabIndex = 56;
            this.gridInventory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(38, 134);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(119, 30);
            this.labelControl2.TabIndex = 49;
            this.labelControl2.Text = "Product ID";
            // 
            // txtStockOutID
            // 
            this.txtStockOutID.Location = new System.Drawing.Point(207, 131);
            this.txtStockOutID.Name = "txtStockOutID";
            this.txtStockOutID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtStockOutID.Properties.Appearance.Options.UseFont = true;
            this.txtStockOutID.Size = new System.Drawing.Size(417, 36);
            this.txtStockOutID.TabIndex = 50;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(38, 204);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(124, 30);
            this.labelControl3.TabIndex = 51;
            this.labelControl3.Text = "Product No";
            // 
            // txtStockOutQuantityTotal
            // 
            this.txtStockOutQuantityTotal.Location = new System.Drawing.Point(207, 203);
            this.txtStockOutQuantityTotal.Name = "txtStockOutQuantityTotal";
            this.txtStockOutQuantityTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtStockOutQuantityTotal.Properties.Appearance.Options.UseFont = true;
            this.txtStockOutQuantityTotal.Size = new System.Drawing.Size(417, 36);
            this.txtStockOutQuantityTotal.TabIndex = 52;
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Location = new System.Drawing.Point(38, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 48);
            this.btnAdd.TabIndex = 53;
            this.btnAdd.Text = "Search ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(630, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(138, 40);
            this.labelControl1.TabIndex = 48;
            this.labelControl1.Text = "Inventory";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(891, 124);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(332, 36);
            this.textEdit1.TabIndex = 60;
            // 
            // ucInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.gridInventory);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtStockOutQuantityTotal);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtStockOutID);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cboCustomerID);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Name = "ucInventory";
            this.Size = new System.Drawing.Size(1428, 862);
            ((System.ComponentModel.ISupportInitialize)(this.cboCustomerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockOutID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockOutQuantityTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit cboCustomerID;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridInventory;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtStockOutID;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtStockOutQuantityTotal;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}

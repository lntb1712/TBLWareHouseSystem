namespace TBLWareHouseSystem.GUI.UserControl
{
    partial class ucStockOutManagement
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
            this.gridStockOut = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dateStockOut = new DevExpress.XtraEditors.DateEdit();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtStockOutQuantityTotal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtStockOutID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cboCustomerID = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridStockOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStockOut.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStockOut.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockOutQuantityTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockOutID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCustomerID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridStockOut
            // 
            this.gridStockOut.Location = new System.Drawing.Point(12, 280);
            this.gridStockOut.MainView = this.gridView1;
            this.gridStockOut.Name = "gridStockOut";
            this.gridStockOut.Size = new System.Drawing.Size(1375, 579);
            this.gridStockOut.TabIndex = 43;
            this.gridStockOut.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridStockOut;
            this.gridView1.Name = "gridView1";
            // 
            // dateStockOut
            // 
            this.dateStockOut.EditValue = null;
            this.dateStockOut.Location = new System.Drawing.Point(878, 133);
            this.dateStockOut.Name = "dateStockOut";
            this.dateStockOut.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.dateStockOut.Properties.Appearance.Options.UseFont = true;
            this.dateStockOut.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStockOut.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStockOut.Size = new System.Drawing.Size(332, 36);
            this.dateStockOut.TabIndex = 47;
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.Location = new System.Drawing.Point(319, 8);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(114, 48);
            this.btnEdit.TabIndex = 42;
            this.btnEdit.Text = "Edit";
            // 
            // btnRemove
            // 
            this.btnRemove.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnRemove.Appearance.Options.UseFont = true;
            this.btnRemove.Location = new System.Drawing.Point(175, 8);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(105, 48);
            this.btnRemove.TabIndex = 41;
            this.btnRemove.Text = "Remove";
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Location = new System.Drawing.Point(36, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 48);
            this.btnAdd.TabIndex = 40;
            this.btnAdd.Text = "Add";
            // 
            // txtStockOutQuantityTotal
            // 
            this.txtStockOutQuantityTotal.Location = new System.Drawing.Point(194, 205);
            this.txtStockOutQuantityTotal.Name = "txtStockOutQuantityTotal";
            this.txtStockOutQuantityTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtStockOutQuantityTotal.Properties.Appearance.Options.UseFont = true;
            this.txtStockOutQuantityTotal.Size = new System.Drawing.Size(417, 36);
            this.txtStockOutQuantityTotal.TabIndex = 39;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(25, 206);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(157, 30);
            this.labelControl3.TabIndex = 38;
            this.labelControl3.Text = "Quantity Total";
            // 
            // txtStockOutID
            // 
            this.txtStockOutID.Location = new System.Drawing.Point(194, 133);
            this.txtStockOutID.Name = "txtStockOutID";
            this.txtStockOutID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtStockOutID.Properties.Appearance.Options.UseFont = true;
            this.txtStockOutID.Size = new System.Drawing.Size(417, 36);
            this.txtStockOutID.TabIndex = 37;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(25, 136);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(142, 30);
            this.labelControl2.TabIndex = 36;
            this.labelControl2.Text = "Stock Out ID";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(545, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(336, 40);
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "Stock Out Management";
            // 
            // cboCustomerID
            // 
            this.cboCustomerID.Location = new System.Drawing.Point(878, 206);
            this.cboCustomerID.Name = "cboCustomerID";
            this.cboCustomerID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.cboCustomerID.Properties.Appearance.Options.UseFont = true;
            this.cboCustomerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCustomerID.Size = new System.Drawing.Size(332, 36);
            this.cboCustomerID.TabIndex = 46;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(709, 132);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(167, 30);
            this.labelControl5.TabIndex = 45;
            this.labelControl5.Text = "Stock Out Date";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(709, 209);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(150, 30);
            this.labelControl4.TabIndex = 44;
            this.labelControl4.Text = "Customers ID";
            // 
            // ucStockOutManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridStockOut);
            this.Controls.Add(this.dateStockOut);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtStockOutQuantityTotal);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtStockOutID);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cboCustomerID);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Name = "ucStockOutManagement";
            this.Size = new System.Drawing.Size(1424, 862);
            ((System.ComponentModel.ISupportInitialize)(this.gridStockOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStockOut.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStockOut.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockOutQuantityTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockOutID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCustomerID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridStockOut;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.DateEdit dateStockOut;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.TextEdit txtStockOutQuantityTotal;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtStockOutID;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cboCustomerID;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}

namespace TBLWareHouseSystem.GUI.UserControl
{
    partial class ucSupplier
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
            this.gridSuppliers = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtSupplierNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtSupplierAddress = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtSupplierName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSupplierID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplierNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplierAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplierName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplierID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridSuppliers
            // 
            this.gridSuppliers.Location = new System.Drawing.Point(25, 278);
            this.gridSuppliers.MainView = this.gridView1;
            this.gridSuppliers.Name = "gridSuppliers";
            this.gridSuppliers.Size = new System.Drawing.Size(1375, 579);
            this.gridSuppliers.TabIndex = 69;
            this.gridSuppliers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridSuppliers;
            this.gridView1.Name = "gridView1";
            // 
            // txtSupplierNumber
            // 
            this.txtSupplierNumber.Location = new System.Drawing.Point(929, 203);
            this.txtSupplierNumber.Name = "txtSupplierNumber";
            this.txtSupplierNumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtSupplierNumber.Properties.Appearance.Options.UseFont = true;
            this.txtSupplierNumber.Size = new System.Drawing.Size(417, 36);
            this.txtSupplierNumber.TabIndex = 73;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(736, 204);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(186, 30);
            this.labelControl4.TabIndex = 72;
            this.labelControl4.Text = "Supplier Number";
            // 
            // txtSupplierAddress
            // 
            this.txtSupplierAddress.Location = new System.Drawing.Point(929, 131);
            this.txtSupplierAddress.Name = "txtSupplierAddress";
            this.txtSupplierAddress.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtSupplierAddress.Properties.Appearance.Options.UseFont = true;
            this.txtSupplierAddress.Size = new System.Drawing.Size(417, 36);
            this.txtSupplierAddress.TabIndex = 71;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(736, 134);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(185, 30);
            this.labelControl5.TabIndex = 70;
            this.labelControl5.Text = "Supplier Address";
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.Location = new System.Drawing.Point(332, 6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(114, 48);
            this.btnEdit.TabIndex = 68;
            this.btnEdit.Text = "Edit";
            // 
            // btnRemove
            // 
            this.btnRemove.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnRemove.Appearance.Options.UseFont = true;
            this.btnRemove.Location = new System.Drawing.Point(188, 6);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(105, 48);
            this.btnRemove.TabIndex = 67;
            this.btnRemove.Text = "Remove";
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Location = new System.Drawing.Point(49, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 48);
            this.btnAdd.TabIndex = 66;
            this.btnAdd.Text = "Add";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(207, 203);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtSupplierName.Properties.Appearance.Options.UseFont = true;
            this.txtSupplierName.Size = new System.Drawing.Size(417, 36);
            this.txtSupplierName.TabIndex = 65;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(38, 204);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(162, 30);
            this.labelControl3.TabIndex = 64;
            this.labelControl3.Text = "Supplier Name";
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Location = new System.Drawing.Point(207, 131);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtSupplierID.Properties.Appearance.Options.UseFont = true;
            this.txtSupplierID.Size = new System.Drawing.Size(417, 36);
            this.txtSupplierID.TabIndex = 63;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(38, 134);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(124, 30);
            this.labelControl2.TabIndex = 62;
            this.labelControl2.Text = "Supplier ID";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(558, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(313, 40);
            this.labelControl1.TabIndex = 61;
            this.labelControl1.Text = "Supplier Management";
            // 
            // ucSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridSuppliers);
            this.Controls.Add(this.txtSupplierNumber);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtSupplierAddress);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtSupplierID);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "ucSupplier";
            this.Size = new System.Drawing.Size(1424, 862);
            ((System.ComponentModel.ISupportInitialize)(this.gridSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplierNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplierAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplierName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplierID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridSuppliers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtSupplierNumber;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtSupplierAddress;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.TextEdit txtSupplierName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtSupplierID;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}

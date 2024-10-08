﻿namespace TBLWareHouseSystem.GUI.UserControl
{
    partial class ucStockInManagement
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
            this.gridStockIn = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtStockInQuantityTotal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtStockInID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cboSupplierID = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dateStockIn = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStockIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockInQuantityTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockInID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSupplierID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStockIn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStockIn.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridStockIn
            // 
            this.gridStockIn.Location = new System.Drawing.Point(25, 278);
            this.gridStockIn.MainView = this.gridView1;
            this.gridStockIn.Name = "gridStockIn";
            this.gridStockIn.Size = new System.Drawing.Size(1375, 581);
            this.gridStockIn.TabIndex = 29;
            this.gridStockIn.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridStockIn.Click += new System.EventHandler(this.gridUser_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridStockIn;
            this.gridView1.Name = "gridView1";
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.Location = new System.Drawing.Point(319, 8);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(114, 48);
            this.btnEdit.TabIndex = 28;
            this.btnEdit.Text = "Edit";
            // 
            // btnRemove
            // 
            this.btnRemove.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnRemove.Appearance.Options.UseFont = true;
            this.btnRemove.Location = new System.Drawing.Point(175, 8);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(105, 48);
            this.btnRemove.TabIndex = 27;
            this.btnRemove.Text = "Remove";
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Location = new System.Drawing.Point(36, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 48);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Add";
            // 
            // txtStockInQuantityTotal
            // 
            this.txtStockInQuantityTotal.Location = new System.Drawing.Point(194, 205);
            this.txtStockInQuantityTotal.Name = "txtStockInQuantityTotal";
            this.txtStockInQuantityTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtStockInQuantityTotal.Properties.Appearance.Options.UseFont = true;
            this.txtStockInQuantityTotal.Size = new System.Drawing.Size(417, 36);
            this.txtStockInQuantityTotal.TabIndex = 24;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(25, 206);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(157, 30);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "Quantity Total";
            // 
            // txtStockInID
            // 
            this.txtStockInID.Location = new System.Drawing.Point(194, 133);
            this.txtStockInID.Name = "txtStockInID";
            this.txtStockInID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtStockInID.Properties.Appearance.Options.UseFont = true;
            this.txtStockInID.Size = new System.Drawing.Size(417, 36);
            this.txtStockInID.TabIndex = 22;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(25, 136);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(125, 30);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Stock In ID";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(545, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(314, 40);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Stock In Management";
            // 
            // cboSupplierID
            // 
            this.cboSupplierID.Location = new System.Drawing.Point(878, 206);
            this.cboSupplierID.Name = "cboSupplierID";
            this.cboSupplierID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.cboSupplierID.Properties.Appearance.Options.UseFont = true;
            this.cboSupplierID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSupplierID.Size = new System.Drawing.Size(332, 36);
            this.cboSupplierID.TabIndex = 33;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(709, 132);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(150, 30);
            this.labelControl5.TabIndex = 31;
            this.labelControl5.Text = "Stock In Date";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(709, 209);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(124, 30);
            this.labelControl4.TabIndex = 30;
            this.labelControl4.Text = "Supplier ID";
            // 
            // dateStockIn
            // 
            this.dateStockIn.EditValue = null;
            this.dateStockIn.Location = new System.Drawing.Point(878, 133);
            this.dateStockIn.Name = "dateStockIn";
            this.dateStockIn.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.dateStockIn.Properties.Appearance.Options.UseFont = true;
            this.dateStockIn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStockIn.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStockIn.Size = new System.Drawing.Size(332, 36);
            this.dateStockIn.TabIndex = 34;
            // 
            // ucStockInManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateStockIn);
            this.Controls.Add(this.gridStockIn);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtStockInQuantityTotal);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtStockInID);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cboSupplierID);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Name = "ucStockInManagement";
            this.Size = new System.Drawing.Size(1424, 862);
            ((System.ComponentModel.ISupportInitialize)(this.gridStockIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockInQuantityTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockInID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSupplierID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStockIn.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStockIn.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridStockIn;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.TextEdit txtStockInQuantityTotal;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtStockInID;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cboSupplierID;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit dateStockIn;
    }
}

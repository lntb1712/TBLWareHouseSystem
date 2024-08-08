namespace TBLWareHouseSystem.GUI.UserControl
{
    partial class ucUserGroups
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
            this.components = new System.ComponentModel.Container();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtGroupName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtGroupID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupFunctionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLWareHouseSystemDataSet = new TBLWareHouseSystem.TBLWareHouseSystemDataSet();
            this.txtGroupDes = new DevExpress.XtraEditors.TextEdit();
            this.groupFunctionsTableAdapter = new TBLWareHouseSystem.TBLWareHouseSystemDataSetTableAdapters.GroupFunctionsTableAdapter();
            this.gridFunctions = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridGroup = new DevExpress.XtraGrid.GridControl();
            this.gridGroupManagement = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGroupID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupDes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdateBy = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupFunctionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLWareHouseSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupDes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFunctions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupManagement)).BeginInit();
            this.SuspendLayout();
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
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
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
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(194, 173);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtGroupName.Properties.Appearance.Options.UseFont = true;
            this.txtGroupName.Size = new System.Drawing.Size(1169, 36);
            this.txtGroupName.TabIndex = 24;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(25, 174);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(140, 30);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "Group Name";
            // 
            // txtGroupID
            // 
            this.txtGroupID.Location = new System.Drawing.Point(194, 101);
            this.txtGroupID.Name = "txtGroupID";
            this.txtGroupID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtGroupID.Properties.Appearance.Options.UseFont = true;
            this.txtGroupID.Size = new System.Drawing.Size(1169, 36);
            this.txtGroupID.TabIndex = 22;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(25, 104);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(102, 30);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Group ID";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(508, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(375, 40);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "User Groups Management";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(28, 243);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(117, 30);
            this.labelControl4.TabIndex = 30;
            this.labelControl4.Text = "Group Des";
            // 
            // groupFunctionsBindingSource
            // 
            this.groupFunctionsBindingSource.DataMember = "GroupFunctions";
            this.groupFunctionsBindingSource.DataSource = this.tBLWareHouseSystemDataSet;
            // 
            // tBLWareHouseSystemDataSet
            // 
            this.tBLWareHouseSystemDataSet.DataSetName = "TBLWareHouseSystemDataSet";
            this.tBLWareHouseSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtGroupDes
            // 
            this.txtGroupDes.Location = new System.Drawing.Point(194, 240);
            this.txtGroupDes.Name = "txtGroupDes";
            this.txtGroupDes.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtGroupDes.Properties.Appearance.Options.UseFont = true;
            this.txtGroupDes.Size = new System.Drawing.Size(1169, 36);
            this.txtGroupDes.TabIndex = 35;
            // 
            // groupFunctionsTableAdapter
            // 
            this.groupFunctionsTableAdapter.ClearBeforeFill = true;
            // 
            // gridFunctions
            // 
            this.gridFunctions.Location = new System.Drawing.Point(25, 573);
            this.gridFunctions.MainView = this.gridView2;
            this.gridFunctions.Name = "gridFunctions";
            this.gridFunctions.Size = new System.Drawing.Size(1338, 274);
            this.gridFunctions.TabIndex = 36;
            this.gridFunctions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridFunctions.Click += new System.EventHandler(this.gridFunctions_Click);
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridFunctions;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsEditForm.EditFormColumnCount = 4;
            // 
            // gridGroup
            // 
            this.gridGroup.Location = new System.Drawing.Point(43, 294);
            this.gridGroup.MainView = this.gridGroupManagement;
            this.gridGroup.Name = "gridGroup";
            this.gridGroup.Size = new System.Drawing.Size(1338, 274);
            this.gridGroup.TabIndex = 37;
            this.gridGroup.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridGroupManagement});
            // 
            // gridGroupManagement
            // 
            this.gridGroupManagement.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGroupID,
            this.colGroupName,
            this.colGroupDes,
            this.colUpdateTime,
            this.colUpdateBy});
            this.gridGroupManagement.GridControl = this.gridGroup;
            this.gridGroupManagement.Name = "gridGroupManagement";
            this.gridGroupManagement.OptionsEditForm.EditFormColumnCount = 4;
            // 
            // colGroupID
            // 
            this.colGroupID.Caption = "Group ID";
            this.colGroupID.FieldName = "colGroupID";
            this.colGroupID.MinWidth = 25;
            this.colGroupID.Name = "colGroupID";
            this.colGroupID.UnboundDataType = typeof(string);
            this.colGroupID.Visible = true;
            this.colGroupID.VisibleIndex = 0;
            this.colGroupID.Width = 94;
            // 
            // colGroupName
            // 
            this.colGroupName.Caption = "Group Name";
            this.colGroupName.FieldName = "colGroupName";
            this.colGroupName.MinWidth = 25;
            this.colGroupName.Name = "colGroupName";
            this.colGroupName.UnboundDataType = typeof(string);
            this.colGroupName.Visible = true;
            this.colGroupName.VisibleIndex = 1;
            this.colGroupName.Width = 94;
            // 
            // colGroupDes
            // 
            this.colGroupDes.Caption = "Group Description";
            this.colGroupDes.FieldName = "colGroupDes";
            this.colGroupDes.MinWidth = 25;
            this.colGroupDes.Name = "colGroupDes";
            this.colGroupDes.UnboundDataType = typeof(string);
            this.colGroupDes.Visible = true;
            this.colGroupDes.VisibleIndex = 2;
            this.colGroupDes.Width = 94;
            // 
            // colUpdateTime
            // 
            this.colUpdateTime.Caption = "Update Time";
            this.colUpdateTime.FieldName = "colUpdateTime";
            this.colUpdateTime.MinWidth = 25;
            this.colUpdateTime.Name = "colUpdateTime";
            this.colUpdateTime.UnboundDataType = typeof(System.DateTime);
            this.colUpdateTime.Visible = true;
            this.colUpdateTime.VisibleIndex = 3;
            this.colUpdateTime.Width = 94;
            // 
            // colUpdateBy
            // 
            this.colUpdateBy.Caption = "Update By";
            this.colUpdateBy.FieldName = "colUpdateBy";
            this.colUpdateBy.MinWidth = 25;
            this.colUpdateBy.Name = "colUpdateBy";
            this.colUpdateBy.UnboundDataType = typeof(string);
            this.colUpdateBy.Visible = true;
            this.colUpdateBy.VisibleIndex = 4;
            this.colUpdateBy.Width = 94;
            // 
            // ucUserGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridGroup);
            this.Controls.Add(this.gridFunctions);
            this.Controls.Add(this.txtGroupDes);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtGroupID);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl4);
            this.Name = "ucUserGroups";
            this.Size = new System.Drawing.Size(1424, 862);
            this.Load += new System.EventHandler(this.ucUserGroups_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupFunctionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLWareHouseSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupDes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFunctions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupManagement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.TextEdit txtGroupName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtGroupID;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtGroupDes;
        private System.Windows.Forms.BindingSource groupFunctionsBindingSource;
        private TBLWareHouseSystemDataSet tBLWareHouseSystemDataSet;
        private TBLWareHouseSystemDataSetTableAdapters.GroupFunctionsTableAdapter groupFunctionsTableAdapter;
        private DevExpress.XtraGrid.GridControl gridFunctions;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gridGroup;
        private DevExpress.XtraGrid.Views.Grid.GridView gridGroupManagement;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupID;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupName;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupDes;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdateTime;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdateBy;
    }
}

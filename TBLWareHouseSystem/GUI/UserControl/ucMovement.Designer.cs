namespace TBLWareHouseSystem.GUI.UserControl
{
    partial class ucMovement
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
            this.gridMovement = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtProductID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cboFromLocationID = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtProductNo = new DevExpress.XtraEditors.TextEdit();
            this.cboToLocationID = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtQuantityToMove = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridMovement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFromLocationID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboToLocationID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantityToMove.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridMovement
            // 
            this.gridMovement.Location = new System.Drawing.Point(25, 344);
            this.gridMovement.MainView = this.gridView1;
            this.gridMovement.Name = "gridMovement";
            this.gridMovement.Size = new System.Drawing.Size(1375, 513);
            this.gridMovement.TabIndex = 56;
            this.gridMovement.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridMovement;
            this.gridView1.Name = "gridView1";
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.Location = new System.Drawing.Point(332, 6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(114, 48);
            this.btnEdit.TabIndex = 55;
            this.btnEdit.Text = "Edit";
            // 
            // btnRemove
            // 
            this.btnRemove.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnRemove.Appearance.Options.UseFont = true;
            this.btnRemove.Location = new System.Drawing.Point(188, 6);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(105, 48);
            this.btnRemove.TabIndex = 54;
            this.btnRemove.Text = "Remove";
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Location = new System.Drawing.Point(49, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 48);
            this.btnAdd.TabIndex = 53;
            this.btnAdd.Text = "Add";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(207, 203);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtProductID.Properties.Appearance.Options.UseFont = true;
            this.txtProductID.Size = new System.Drawing.Size(417, 36);
            this.txtProductID.TabIndex = 52;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(38, 204);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(119, 30);
            this.labelControl3.TabIndex = 51;
            this.labelControl3.Text = "Product ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(207, 131);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtID.Properties.Appearance.Options.UseFont = true;
            this.txtID.Size = new System.Drawing.Size(417, 36);
            this.txtID.TabIndex = 50;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(38, 134);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 30);
            this.labelControl2.TabIndex = 49;
            this.labelControl2.Text = "ID";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(625, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(150, 40);
            this.labelControl1.TabIndex = 48;
            this.labelControl1.Text = "Movement";
            // 
            // cboFromLocationID
            // 
            this.cboFromLocationID.Location = new System.Drawing.Point(912, 131);
            this.cboFromLocationID.Name = "cboFromLocationID";
            this.cboFromLocationID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.cboFromLocationID.Properties.Appearance.Options.UseFont = true;
            this.cboFromLocationID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboFromLocationID.Size = new System.Drawing.Size(332, 36);
            this.cboFromLocationID.TabIndex = 59;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(712, 134);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(192, 30);
            this.labelControl4.TabIndex = 57;
            this.labelControl4.Text = "From Location ID";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(38, 273);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(124, 30);
            this.labelControl5.TabIndex = 61;
            this.labelControl5.Text = "Product No";
            // 
            // txtProductNo
            // 
            this.txtProductNo.Location = new System.Drawing.Point(207, 270);
            this.txtProductNo.Name = "txtProductNo";
            this.txtProductNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtProductNo.Properties.Appearance.Options.UseFont = true;
            this.txtProductNo.Size = new System.Drawing.Size(417, 36);
            this.txtProductNo.TabIndex = 62;
            // 
            // cboToLocationID
            // 
            this.cboToLocationID.Location = new System.Drawing.Point(912, 201);
            this.cboToLocationID.Name = "cboToLocationID";
            this.cboToLocationID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.cboToLocationID.Properties.Appearance.Options.UseFont = true;
            this.cboToLocationID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboToLocationID.Size = new System.Drawing.Size(332, 36);
            this.cboToLocationID.TabIndex = 64;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(712, 204);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(164, 30);
            this.labelControl6.TabIndex = 63;
            this.labelControl6.Text = "To Location ID";
            // 
            // txtQuantityToMove
            // 
            this.txtQuantityToMove.Location = new System.Drawing.Point(912, 270);
            this.txtQuantityToMove.Name = "txtQuantityToMove";
            this.txtQuantityToMove.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtQuantityToMove.Properties.Appearance.Options.UseFont = true;
            this.txtQuantityToMove.Size = new System.Drawing.Size(332, 36);
            this.txtQuantityToMove.TabIndex = 66;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(712, 273);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(189, 30);
            this.labelControl7.TabIndex = 65;
            this.labelControl7.Text = "Quantity to Move";
            // 
            // ucMovement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtQuantityToMove);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.cboToLocationID);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtProductNo);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.gridMovement);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cboFromLocationID);
            this.Controls.Add(this.labelControl4);
            this.Name = "ucMovement";
            this.Size = new System.Drawing.Size(1424, 862);
            ((System.ComponentModel.ISupportInitialize)(this.gridMovement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFromLocationID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboToLocationID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantityToMove.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridMovement;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.TextEdit txtProductID;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cboFromLocationID;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtProductNo;
        private DevExpress.XtraEditors.ComboBoxEdit cboToLocationID;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtQuantityToMove;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}

namespace TBLWareHouseSystem.GUI
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menu = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.btnSystem = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnUsers = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnUserGroups = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnOperations = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnStockIn = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnStockOut = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnMovements = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnInventory = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnLogistic = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnCustomer = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnSupplier = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnStockTaking = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnChangePass = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barListItem1 = new DevExpress.XtraBars.BarListItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.txtActualUser = new DevExpress.XtraBars.BarStaticItem();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.barMdiChildrenListItem1 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.txtActual = new DevExpress.XtraBars.BarStaticItem();
            this.barEditItem3 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.MainContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnChangePassword = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnStockTake = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator2 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.btnLogisticManagement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnSuppliersManagement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnCustomerManagement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator3 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlSeparator4 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnMovement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnStockOutManagement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnStockInManagement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.btnSystemManagement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnUserManagement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnUserGroupsManagement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnSystem,
            this.btnOperations,
            this.btnLogistic,
            this.btnStockTaking,
            this.btnChangePass});
            this.menu.Location = new System.Drawing.Point(0, 39);
            this.menu.Name = "menu";
            this.menu.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.menu.Size = new System.Drawing.Size(380, 708);
            this.menu.TabIndex = 1;
            this.menu.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // btnSystem
            // 
            this.btnSystem.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnUsers,
            this.btnUserGroups});
            this.btnSystem.Expanded = true;
            this.btnSystem.ImageOptions.Image = global::TBLWareHouseSystem.Properties.Resources.technology_32x32;
            this.btnSystem.Name = "btnSystem";
            this.btnSystem.Text = "System Management";
            // 
            // btnUsers
            // 
            this.btnUsers.ImageOptions.Image = global::TBLWareHouseSystem.Properties.Resources.customer_32x32;
            this.btnUsers.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnUsers.Text = "Users Management";
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnUserGroups
            // 
            this.btnUserGroups.ImageOptions.Image = global::TBLWareHouseSystem.Properties.Resources.usergroup_32x32;
            this.btnUserGroups.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.btnUserGroups.Name = "btnUserGroups";
            this.btnUserGroups.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnUserGroups.Text = "User Groups Management";
            this.btnUserGroups.Click += new System.EventHandler(this.btnUserGroups_Click);
            // 
            // btnOperations
            // 
            this.btnOperations.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnStockIn,
            this.btnStockOut,
            this.btnMovements,
            this.btnInventory});
            this.btnOperations.Expanded = true;
            this.btnOperations.ImageOptions.Image = global::TBLWareHouseSystem.Properties.Resources.project_32x32;
            this.btnOperations.Name = "btnOperations";
            this.btnOperations.Text = "Operations Management";
            // 
            // btnStockIn
            // 
            this.btnStockIn.ImageOptions.Image = global::TBLWareHouseSystem.Properties.Resources.redo_32x322;
            this.btnStockIn.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.btnStockIn.Name = "btnStockIn";
            this.btnStockIn.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnStockIn.Text = "Stock In Management";
            this.btnStockIn.Click += new System.EventHandler(this.btnStockIn_Click);
            // 
            // btnStockOut
            // 
            this.btnStockOut.ImageOptions.Image = global::TBLWareHouseSystem.Properties.Resources.undo_32x32;
            this.btnStockOut.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.btnStockOut.Name = "btnStockOut";
            this.btnStockOut.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnStockOut.Text = "Stock Out Management";
            this.btnStockOut.Click += new System.EventHandler(this.btnStockOut_Click);
            // 
            // btnMovements
            // 
            this.btnMovements.ImageOptions.Image = global::TBLWareHouseSystem.Properties.Resources.refresh_32x32;
            this.btnMovements.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.btnMovements.Name = "btnMovements";
            this.btnMovements.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnMovements.Text = "Movement";
            this.btnMovements.Click += new System.EventHandler(this.btnMovements_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.ImageOptions.Image = global::TBLWareHouseSystem.Properties.Resources.home_32x32;
            this.btnInventory.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnLogistic
            // 
            this.btnLogistic.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnCustomer,
            this.btnSupplier});
            this.btnLogistic.Expanded = true;
            this.btnLogistic.ImageOptions.Image = global::TBLWareHouseSystem.Properties.Resources.chartsrotate_32x32;
            this.btnLogistic.Name = "btnLogistic";
            this.btnLogistic.Text = "Logistic Management";
            // 
            // btnCustomer
            // 
            this.btnCustomer.ImageOptions.Image = global::TBLWareHouseSystem.Properties.Resources.buy_32x32;
            this.btnCustomer.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnCustomer.Text = "Customers Management";
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.ImageOptions.Image = global::TBLWareHouseSystem.Properties.Resources.newsales_32x32;
            this.btnSupplier.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnSupplier.Text = "Suppliers Management";
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnStockTaking
            // 
            this.btnStockTaking.ImageOptions.Image = global::TBLWareHouseSystem.Properties.Resources.check;
            this.btnStockTaking.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.btnStockTaking.Name = "btnStockTaking";
            this.btnStockTaking.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnStockTaking.Text = "Stock Taking";
            this.btnStockTaking.Click += new System.EventHandler(this.btnStockTaking_Click);
            // 
            // btnChangePass
            // 
            this.btnChangePass.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePass.ImageOptions.Image")));
            this.btnChangePass.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnChangePass.Text = "Change Password";
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barListItem1,
            this.barEditItem1,
            this.txtActualUser,
            this.barEditItem2,
            this.barMdiChildrenListItem1,
            this.txtActual,
            this.barEditItem3});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit1,
            this.repositoryItemPictureEdit1,
            this.repositoryItemTextEdit1});
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1292, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.txtActual);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barListItem1
            // 
            this.barListItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barListItem1.Caption = "barListItem1";
            this.barListItem1.Id = 1;
            this.barListItem1.Name = "barListItem1";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barEditItem1.Caption = "admin";
            this.barEditItem1.Edit = this.repositoryItemHyperLinkEdit1;
            this.barEditItem1.Id = 2;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.AutoHeight = false;
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            // 
            // txtActualUser
            // 
            this.txtActualUser.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.txtActualUser.Id = 3;
            this.txtActualUser.Name = "txtActualUser";
            this.txtActualUser.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.txtActualUser.Tag = "";
            // 
            // barEditItem2
            // 
            this.barEditItem2.Edit = this.repositoryItemPictureEdit1;
            this.barEditItem2.Id = 4;
            this.barEditItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barEditItem2.ImageOptions.Image")));
            this.barEditItem2.Name = "barEditItem2";
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // barMdiChildrenListItem1
            // 
            this.barMdiChildrenListItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barMdiChildrenListItem1.Caption = "barMdiChildrenListItem1";
            this.barMdiChildrenListItem1.Id = 5;
            this.barMdiChildrenListItem1.Name = "barMdiChildrenListItem1";
            // 
            // txtActual
            // 
            this.txtActual.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.txtActual.Id = 6;
            this.txtActual.Name = "txtActual";
            // 
            // barEditItem3
            // 
            this.barEditItem3.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barEditItem3.Caption = "barEditItem3";
            this.barEditItem3.Edit = this.repositoryItemTextEdit1;
            this.barEditItem3.Id = 7;
            this.barEditItem3.Name = "barEditItem3";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barListItem1,
            this.barEditItem1,
            this.txtActualUser,
            this.barEditItem2,
            this.barMdiChildrenListItem1,
            this.txtActual,
            this.barEditItem3});
            this.fluentFormDefaultManager1.MaxItemId = 8;
            this.fluentFormDefaultManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit1,
            this.repositoryItemPictureEdit1,
            this.repositoryItemTextEdit1});
            // 
            // MainContainer
            // 
            this.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContainer.Location = new System.Drawing.Point(380, 39);
            this.MainContainer.Name = "MainContainer";
            this.MainContainer.Size = new System.Drawing.Size(912, 708);
            this.MainContainer.TabIndex = 0;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "TBLWarehouseSystem";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnChangePassword.Text = "Change Password";
            // 
            // btnStockTake
            // 
            this.btnStockTake.Name = "btnStockTake";
            this.btnStockTake.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnStockTake.Text = "Stock Take";
            // 
            // accordionControlSeparator2
            // 
            this.accordionControlSeparator2.Name = "accordionControlSeparator2";
            // 
            // btnLogisticManagement
            // 
            this.btnLogisticManagement.Name = "btnLogisticManagement";
            this.btnLogisticManagement.Text = "Logistic Management";
            // 
            // btnSuppliersManagement
            // 
            this.btnSuppliersManagement.Name = "btnSuppliersManagement";
            this.btnSuppliersManagement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnSuppliersManagement.Text = "Suppliers Management";
            // 
            // btnCustomerManagement
            // 
            this.btnCustomerManagement.Name = "btnCustomerManagement";
            this.btnCustomerManagement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnCustomerManagement.Text = "Customers Management";
            // 
            // accordionControlSeparator3
            // 
            this.accordionControlSeparator3.Name = "accordionControlSeparator3";
            // 
            // accordionControlSeparator4
            // 
            this.accordionControlSeparator4.Name = "accordionControlSeparator4";
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Text = "OperationManagement";
            // 
            // btnMovement
            // 
            this.btnMovement.Name = "btnMovement";
            this.btnMovement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnMovement.Text = "Movement";
            // 
            // btnStockOutManagement
            // 
            this.btnStockOutManagement.Name = "btnStockOutManagement";
            this.btnStockOutManagement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnStockOutManagement.Text = "Stock Out Management";
            // 
            // btnStockInManagement
            // 
            this.btnStockInManagement.Name = "btnStockInManagement";
            this.btnStockInManagement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnStockInManagement.Text = "Stock In Management";
            // 
            // accordionControlSeparator1
            // 
            this.accordionControlSeparator1.Name = "accordionControlSeparator1";
            // 
            // btnSystemManagement
            // 
            this.btnSystemManagement.Expanded = true;
            this.btnSystemManagement.Name = "btnSystemManagement";
            this.btnSystemManagement.Text = "System Management";
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnUserManagement.Text = "Users Management";
            // 
            // btnUserGroupsManagement
            // 
            this.btnUserGroupsManagement.Name = "btnUserGroupsManagement";
            this.btnUserGroupsManagement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnUserGroupsManagement.Text = "User Groups Management";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 747);
            this.ControlContainer = this.MainContainer;
            this.Controls.Add(this.MainContainer);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "Main";
            this.NavigationControl = this.menu;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.AccordionControl menu;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer MainContainer;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarListItem barListItem1;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private DevExpress.XtraBars.BarStaticItem txtActualUser;
        private DevExpress.XtraBars.BarEditItem barEditItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnChangePassword;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnStockTake;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnLogisticManagement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnSuppliersManagement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnCustomerManagement;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator3;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnMovement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnStockOutManagement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnStockInManagement;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnSystemManagement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnUserManagement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnUserGroupsManagement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnSystem;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnOperations;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnLogistic;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnUsers;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnUserGroups;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnStockIn;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnStockOut;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnMovements;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnCustomer;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnSupplier;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnChangePass;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnStockTaking;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnInventory;
        private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem1;
        private DevExpress.XtraBars.BarStaticItem txtActual;
        private DevExpress.XtraBars.BarEditItem barEditItem3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}
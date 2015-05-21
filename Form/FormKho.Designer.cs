namespace DeTai
{
    partial class FormKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKho));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.navbarImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.navbarImageCollectionLarge = new DevExpress.Utils.ImageCollection(this.components);
            this.btnCheckThietBi = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnReport = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.btnThemLTB = new DevExpress.XtraNavBar.NavBarItem();
            this.btnXemLTB = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnThemNSX = new DevExpress.XtraNavBar.NavBarItem();
            this.btnXemNSX = new DevExpress.XtraNavBar.NavBarItem();
            this.u = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnThemTB = new DevExpress.XtraNavBar.NavBarItem();
            this.btnXemThietBi = new DevExpress.XtraNavBar.NavBarItem();
            this.mailGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnTaiKhoan = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup4 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.splitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControlRight = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnLogout = new DevExpress.XtraEditors.SimpleButton();
            this.btnChange = new DevExpress.XtraEditors.SimpleButton();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.panelMain = new DevExpress.XtraEditors.PanelControl();
            this.gridMain = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtpage = new DevExpress.XtraEditors.TextEdit();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnRe = new DevExpress.XtraEditors.SimpleButton();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.navBarItem7 = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollectionLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
            this.splitContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlRight)).BeginInit();
            this.splitContainerControlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Caramel";
            // 
            // navbarImageCollection
            // 
            this.navbarImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("navbarImageCollection.ImageStream")));
            this.navbarImageCollection.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // navbarImageCollectionLarge
            // 
            this.navbarImageCollectionLarge.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("navbarImageCollectionLarge.ImageStream")));
            this.navbarImageCollectionLarge.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnCheckThietBi
            // 
            this.btnCheckThietBi.Caption = "Thiết bị";
            this.btnCheckThietBi.Name = "btnCheckThietBi";
            this.btnCheckThietBi.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnCheckThietBi.SmallImage")));
            this.btnCheckThietBi.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnCheckThietBi_LinkClicked);
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "Thống kê";
            this.navBarGroup3.Expanded = true;
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnCheckThietBi),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnReport)});
            this.navBarGroup3.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup3.LargeImage")));
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // btnReport
            // 
            this.btnReport.Caption = "report";
            this.btnReport.Name = "btnReport";
            this.btnReport.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnReport.SmallImage")));
            this.btnReport.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnReport_LinkClicked);
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "Thêm";
            this.navBarItem4.Name = "navBarItem4";
            this.navBarItem4.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem4.SmallImage")));
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "Xem";
            this.navBarItem3.Name = "navBarItem3";
            this.navBarItem3.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem3.SmallImage")));
            // 
            // btnThemLTB
            // 
            this.btnThemLTB.Caption = "Thêm";
            this.btnThemLTB.Name = "btnThemLTB";
            this.btnThemLTB.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnThemLTB.SmallImage")));
            this.btnThemLTB.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnThemLTB_LinkClicked);
            // 
            // btnXemLTB
            // 
            this.btnXemLTB.Caption = "Xem";
            this.btnXemLTB.Name = "btnXemLTB";
            this.btnXemLTB.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnXemLTB.SmallImage")));
            this.btnXemLTB.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnXemLTB_LinkClicked);
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Loại thiết bị";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnXemLTB),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnThemLTB)});
            this.navBarGroup1.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup1.LargeImage")));
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // btnThemNSX
            // 
            this.btnThemNSX.Caption = "Thêm";
            this.btnThemNSX.Name = "btnThemNSX";
            this.btnThemNSX.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnThemNSX.SmallImage")));
            this.btnThemNSX.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnThemNSX_LinkClicked);
            // 
            // btnXemNSX
            // 
            this.btnXemNSX.Caption = "Xem";
            this.btnXemNSX.Name = "btnXemNSX";
            this.btnXemNSX.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnXemNSX.SmallImage")));
            this.btnXemNSX.SmallImageIndex = 4;
            this.btnXemNSX.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnXemNSX_LinkClicked);
            // 
            // u
            // 
            this.u.Caption = "Nhà sản xuất";
            this.u.Expanded = true;
            this.u.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnXemNSX),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnThemNSX)});
            this.u.LargeImage = ((System.Drawing.Image)(resources.GetObject("u.LargeImage")));
            this.u.LargeImageIndex = 1;
            this.u.Name = "u";
            // 
            // btnThemTB
            // 
            this.btnThemTB.Caption = "Thêm";
            this.btnThemTB.Name = "btnThemTB";
            this.btnThemTB.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnThemTB.SmallImage")));
            this.btnThemTB.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnThemTB_LinkClicked);
            // 
            // btnXemThietBi
            // 
            this.btnXemThietBi.Caption = "Xem";
            this.btnXemThietBi.Name = "btnXemThietBi";
            this.btnXemThietBi.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnXemThietBi.SmallImage")));
            this.btnXemThietBi.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnXemThietBi_LinkClicked);
            // 
            // mailGroup
            // 
            this.mailGroup.Caption = "Thiết bị";
            this.mailGroup.Expanded = true;
            this.mailGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnXemThietBi),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnThemTB)});
            this.mailGroup.LargeImage = ((System.Drawing.Image)(resources.GetObject("mailGroup.LargeImage")));
            this.mailGroup.LargeImageIndex = 0;
            this.mailGroup.Name = "mailGroup";
            // 
            // navBarControl
            // 
            this.navBarControl.ActiveGroup = this.mailGroup;
            this.navBarControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.mailGroup,
            this.u,
            this.navBarGroup1,
            this.navBarGroup3,
            this.navBarGroup2,
            this.navBarGroup4});
            this.navBarControl.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.btnXemThietBi,
            this.btnThemTB,
            this.btnXemNSX,
            this.btnThemNSX,
            this.btnXemLTB,
            this.btnThemLTB,
            this.navBarItem3,
            this.navBarItem4,
            this.btnCheckThietBi,
            this.btnTaiKhoan,
            this.navBarItem1,
            this.btnReport});
            this.navBarControl.LargeImages = this.navbarImageCollectionLarge;
            this.navBarControl.Location = new System.Drawing.Point(0, 0);
            this.navBarControl.Name = "navBarControl";
            this.navBarControl.OptionsNavPane.ExpandedWidth = 173;
            this.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.ExplorerBar;
            this.navBarControl.Size = new System.Drawing.Size(173, 688);
            this.navBarControl.SmallImages = this.navbarImageCollection;
            this.navBarControl.StoreDefaultPaintStyleName = true;
            this.navBarControl.TabIndex = 0;
            this.navBarControl.Text = "navBarControl1";
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Tài khoản";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnTaiKhoan)});
            this.navBarGroup2.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup2.LargeImage")));
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Caption = "Đổi password";
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnTaiKhoan.SmallImage")));
            this.btnTaiKhoan.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnTaiKhoan_LinkClicked);
            // 
            // navBarGroup4
            // 
            this.navBarGroup4.Caption = "Report";
            this.navBarGroup4.Expanded = true;
            this.navBarGroup4.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1)});
            this.navBarGroup4.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup4.LargeImage")));
            this.navBarGroup4.Name = "navBarGroup4";
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "navBarItem1";
            this.navBarItem1.Name = "navBarItem1";
            // 
            // splitContainerControl
            // 
            this.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl.Name = "splitContainerControl";
            this.splitContainerControl.Padding = new System.Windows.Forms.Padding(6);
            this.splitContainerControl.Panel1.Controls.Add(this.navBarControl);
            this.splitContainerControl.Panel1.Text = "Panel1";
            this.splitContainerControl.Panel2.Controls.Add(this.splitContainerControlRight);
            this.splitContainerControl.Panel2.Text = "Panel2";
            this.splitContainerControl.Size = new System.Drawing.Size(1100, 700);
            this.splitContainerControl.SplitterPosition = 173;
            this.splitContainerControl.TabIndex = 1;
            this.splitContainerControl.Text = "splitContainerControl1";
            // 
            // splitContainerControlRight
            // 
            this.splitContainerControlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControlRight.Horizontal = false;
            this.splitContainerControlRight.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControlRight.Name = "splitContainerControlRight";
            this.splitContainerControlRight.Panel1.Controls.Add(this.btnLogout);
            this.splitContainerControlRight.Panel1.Controls.Add(this.btnChange);
            this.splitContainerControlRight.Panel1.Controls.Add(this.btnReset);
            this.splitContainerControlRight.Panel1.Controls.Add(this.btnDelete);
            this.splitContainerControlRight.Panel1.Controls.Add(this.btnSave);
            this.splitContainerControlRight.Panel1.Controls.Add(this.txtSearch);
            this.splitContainerControlRight.Panel1.Controls.Add(this.btnSearch);
            this.splitContainerControlRight.Panel1.Text = "Control";
            this.splitContainerControlRight.Panel2.Controls.Add(this.panelMain);
            this.splitContainerControlRight.Panel2.Text = "Panel2";
            this.splitContainerControlRight.Size = new System.Drawing.Size(909, 688);
            this.splitContainerControlRight.SplitterPosition = 45;
            this.splitContainerControlRight.TabIndex = 1;
            this.splitContainerControlRight.Text = "splitContainerControl1";
            // 
            // btnLogout
            // 
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(344, 6);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(81, 33);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnChange
            // 
            this.btnChange.Image = ((System.Drawing.Image)(resources.GetObject("btnChange.Image")));
            this.btnChange.Location = new System.Drawing.Point(179, 6);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 33);
            this.btnChange.TabIndex = 9;
            this.btnChange.Text = "Edit";
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnReset
            // 
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(95, 6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(78, 33);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(260, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 33);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(17, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 33);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(652, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(182, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSearch.Location = new System.Drawing.Point(840, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(33, 33);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.gridMain);
            this.panelMain.Controls.Add(this.txtpage);
            this.panelMain.Controls.Add(this.btnNext);
            this.panelMain.Controls.Add(this.btnRe);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(909, 637);
            this.panelMain.TabIndex = 1;
            // 
            // gridMain
            // 
            this.gridMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridMain.Location = new System.Drawing.Point(2, 33);
            this.gridMain.MainView = this.gridView;
            this.gridMain.Name = "gridMain";
            this.gridMain.Size = new System.Drawing.Size(905, 602);
            this.gridMain.TabIndex = 4;
            this.gridMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            this.gridMain.DoubleClick += new System.EventHandler(this.gridMain_DoubleClick);
            this.gridMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridMain_KeyDown);
            // 
            // gridView
            // 
            this.gridView.GridControl = this.gridMain;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsBehavior.Editable = false;
            // 
            // txtpage
            // 
            this.txtpage.EditValue = ((short)(1));
            this.txtpage.Location = new System.Drawing.Point(67, 7);
            this.txtpage.Name = "txtpage";
            this.txtpage.Size = new System.Drawing.Size(40, 20);
            this.txtpage.TabIndex = 7;
            // 
            // btnNext
            // 
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnNext.Location = new System.Drawing.Point(113, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(25, 25);
            this.btnNext.TabIndex = 6;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnRe
            // 
            this.btnRe.Image = ((System.Drawing.Image)(resources.GetObject("btnRe.Image")));
            this.btnRe.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnRe.Location = new System.Drawing.Point(36, 4);
            this.btnRe.Name = "btnRe";
            this.btnRe.Size = new System.Drawing.Size(25, 25);
            this.btnRe.TabIndex = 5;
            this.btnRe.Click += new System.EventHandler(this.btnRe_Click);
            // 
            // popupMenu1
            // 
            this.popupMenu1.Name = "popupMenu1";
            // 
            // navBarItem7
            // 
            this.navBarItem7.Caption = "Thêm";
            this.navBarItem7.Name = "navBarItem7";
            this.navBarItem7.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem7.SmallImage")));
            // 
            // FormKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.splitContainerControl);
            this.Name = "FormKho";
            this.Text = "FormKho";
            this.Load += new System.EventHandler(this.FormKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollectionLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
            this.splitContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlRight)).EndInit();
            this.splitContainerControlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).EndInit();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.Utils.ImageCollection navbarImageCollection;
        private DevExpress.Utils.ImageCollection navbarImageCollectionLarge;
        private DevExpress.XtraNavBar.NavBarItem btnCheckThietBi;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarItem btnThemLTB;
        private DevExpress.XtraNavBar.NavBarItem btnXemLTB;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem btnThemNSX;
        private DevExpress.XtraNavBar.NavBarItem btnXemNSX;
        private DevExpress.XtraNavBar.NavBarGroup u;
        private DevExpress.XtraNavBar.NavBarItem btnThemTB;
        private DevExpress.XtraNavBar.NavBarItem btnXemThietBi;
        private DevExpress.XtraNavBar.NavBarGroup mailGroup;
        private DevExpress.XtraNavBar.NavBarControl navBarControl;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem7;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControlRight;
        private DevExpress.XtraEditors.SimpleButton btnChange;
        private DevExpress.XtraEditors.SimpleButton btnReset;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.PanelControl panelMain;
        private DevExpress.XtraGrid.GridControl gridMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraEditors.TextEdit txtpage;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnRe;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem btnTaiKhoan;
        private DevExpress.XtraEditors.SimpleButton btnLogout;
        private DevExpress.XtraNavBar.NavBarItem btnReport;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup4;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
    }
}
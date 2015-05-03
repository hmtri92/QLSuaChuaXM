namespace DeTai
{
    partial class FormAddmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddmin));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControlRight = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnChange = new DevExpress.XtraEditors.SimpleButton();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.panelMain = new DevExpress.XtraEditors.PanelControl();
            this.gridMain = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtpage = new DevExpress.XtraEditors.TextEdit();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnRe = new DevExpress.XtraEditors.SimpleButton();
            this.navbarImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.navbarImageCollectionLarge = new DevExpress.Utils.ImageCollection(this.components);
            this.navBarItem6 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.btnThemNhomTho = new DevExpress.XtraNavBar.NavBarItem();
            this.btnXemNhomTho = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnThemNV = new DevExpress.XtraNavBar.NavBarItem();
            this.xemNhanVien = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.txtThemQuyen = new DevExpress.XtraNavBar.NavBarItem();
            this.btnXemQuyen = new DevExpress.XtraNavBar.NavBarItem();
            this.organizerGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.txtThemTaiKhoan = new DevExpress.XtraNavBar.NavBarItem();
            this.btnXemTaiKhoan = new DevExpress.XtraNavBar.NavBarItem();
            this.mailGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.splitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlRight)).BeginInit();
            this.splitContainerControlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollectionLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
            this.splitContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Caramel";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(652, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(182, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
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
            // splitContainerControlRight
            // 
            this.splitContainerControlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControlRight.Horizontal = false;
            this.splitContainerControlRight.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControlRight.Name = "splitContainerControlRight";
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
            this.splitContainerControlRight.TabIndex = 0;
            this.splitContainerControlRight.Text = "splitContainerControl1";
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
            // navBarItem6
            // 
            this.navBarItem6.Caption = "Thêm";
            this.navBarItem6.Name = "navBarItem6";
            this.navBarItem6.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem6.SmallImage")));
            // 
            // navBarItem5
            // 
            this.navBarItem5.Caption = "Xem";
            this.navBarItem5.Name = "navBarItem5";
            this.navBarItem5.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem5.SmallImage")));
            // 
            // btnThemNhomTho
            // 
            this.btnThemNhomTho.Caption = "Thêm";
            this.btnThemNhomTho.Name = "btnThemNhomTho";
            this.btnThemNhomTho.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnThemNhomTho.SmallImage")));
            this.btnThemNhomTho.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnThemNhomTho_LinkClicked);
            // 
            // btnXemNhomTho
            // 
            this.btnXemNhomTho.Caption = "Xem";
            this.btnXemNhomTho.Name = "btnXemNhomTho";
            this.btnXemNhomTho.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnXemNhomTho.SmallImage")));
            this.btnXemNhomTho.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnXemNhomTho_LinkClicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Nhóm thợ";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnXemNhomTho),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnThemNhomTho)});
            this.navBarGroup2.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup2.LargeImage")));
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // btnThemNV
            // 
            this.btnThemNV.Caption = "Thêm";
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnThemNV.SmallImage")));
            this.btnThemNV.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnThemNV_LinkClicked);
            // 
            // xemNhanVien
            // 
            this.xemNhanVien.Caption = "Xem";
            this.xemNhanVien.Name = "xemNhanVien";
            this.xemNhanVien.SmallImage = ((System.Drawing.Image)(resources.GetObject("xemNhanVien.SmallImage")));
            this.xemNhanVien.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.xemNhanVien_LinkClicked);
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Nhân viên";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.xemNhanVien),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnThemNV)});
            this.navBarGroup1.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup1.LargeImage")));
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // txtThemQuyen
            // 
            this.txtThemQuyen.Caption = "Thêm";
            this.txtThemQuyen.Name = "txtThemQuyen";
            this.txtThemQuyen.SmallImage = ((System.Drawing.Image)(resources.GetObject("txtThemQuyen.SmallImage")));
            this.txtThemQuyen.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.txtThemQuyen_LinkClicked);
            // 
            // btnXemQuyen
            // 
            this.btnXemQuyen.Caption = "Xem";
            this.btnXemQuyen.Name = "btnXemQuyen";
            this.btnXemQuyen.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnXemQuyen.SmallImage")));
            this.btnXemQuyen.SmallImageIndex = 4;
            this.btnXemQuyen.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnXemQuyen_LinkClicked);
            // 
            // organizerGroup
            // 
            this.organizerGroup.Caption = "Quyền truy cập";
            this.organizerGroup.Expanded = true;
            this.organizerGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnXemQuyen),
            new DevExpress.XtraNavBar.NavBarItemLink(this.txtThemQuyen)});
            this.organizerGroup.LargeImage = ((System.Drawing.Image)(resources.GetObject("organizerGroup.LargeImage")));
            this.organizerGroup.LargeImageIndex = 1;
            this.organizerGroup.Name = "organizerGroup";
            this.organizerGroup.Visible = false;
            // 
            // txtThemTaiKhoan
            // 
            this.txtThemTaiKhoan.Caption = "Thêm";
            this.txtThemTaiKhoan.Name = "txtThemTaiKhoan";
            this.txtThemTaiKhoan.SmallImage = ((System.Drawing.Image)(resources.GetObject("txtThemTaiKhoan.SmallImage")));
            this.txtThemTaiKhoan.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.txtThemTaiKhoan_LinkClicked);
            // 
            // btnXemTaiKhoan
            // 
            this.btnXemTaiKhoan.Caption = "Xem";
            this.btnXemTaiKhoan.Name = "btnXemTaiKhoan";
            this.btnXemTaiKhoan.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnXemTaiKhoan.SmallImage")));
            this.btnXemTaiKhoan.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnXemTaiKhoan_LinkClicked);
            // 
            // mailGroup
            // 
            this.mailGroup.Caption = "Tài khoản";
            this.mailGroup.Expanded = true;
            this.mailGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnXemTaiKhoan),
            new DevExpress.XtraNavBar.NavBarItemLink(this.txtThemTaiKhoan)});
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
            this.organizerGroup,
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3});
            this.navBarControl.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.btnXemTaiKhoan,
            this.txtThemTaiKhoan,
            this.btnXemQuyen,
            this.txtThemQuyen,
            this.xemNhanVien,
            this.btnThemNV,
            this.btnXemNhomTho,
            this.btnThemNhomTho,
            this.navBarItem5,
            this.navBarItem6});
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
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "Thống kê";
            this.navBarGroup3.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup3.LargeImage")));
            this.navBarGroup3.Name = "navBarGroup3";
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
            // popupMenu1
            // 
            this.popupMenu1.Name = "popupMenu1";
            // 
            // FormAddmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.splitContainerControl);
            this.Name = "FormAddmin";
            this.Text = "Addmin";
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlRight)).EndInit();
            this.splitContainerControlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).EndInit();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollectionLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
            this.splitContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControlRight;
        private DevExpress.Utils.ImageCollection navbarImageCollection;
        private DevExpress.Utils.ImageCollection navbarImageCollectionLarge;
        private DevExpress.XtraNavBar.NavBarItem navBarItem6;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraNavBar.NavBarItem btnThemNhomTho;
        private DevExpress.XtraNavBar.NavBarItem btnXemNhomTho;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem btnThemNV;
        private DevExpress.XtraNavBar.NavBarItem xemNhanVien;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem txtThemQuyen;
        private DevExpress.XtraNavBar.NavBarItem btnXemQuyen;
        private DevExpress.XtraNavBar.NavBarGroup organizerGroup;
        private DevExpress.XtraNavBar.NavBarItem txtThemTaiKhoan;
        private DevExpress.XtraNavBar.NavBarItem btnXemTaiKhoan;
        private DevExpress.XtraNavBar.NavBarGroup mailGroup;
        private DevExpress.XtraNavBar.NavBarControl navBarControl;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraEditors.SimpleButton btnChange;
        private DevExpress.XtraEditors.SimpleButton btnReset;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.PanelControl panelMain;
        private DevExpress.XtraGrid.GridControl gridMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraEditors.TextEdit txtpage;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnRe;
    }
}
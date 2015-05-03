namespace DeTai
{
    partial class FormKeToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKeToan));
            this.splitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.HoaDonGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnXemHoaDon = new DevExpress.XtraNavBar.NavBarItem();
            this.btnThemHoaDon = new DevExpress.XtraNavBar.NavBarItem();
            this.KhachHangGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnTimKhach = new DevExpress.XtraNavBar.NavBarItem();
            this.btnThemKH = new DevExpress.XtraNavBar.NavBarItem();
            this.XeGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnXemXe = new DevExpress.XtraNavBar.NavBarItem();
            this.btnThemXe = new DevExpress.XtraNavBar.NavBarItem();
            this.LoaiXeGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnXemLXe = new DevExpress.XtraNavBar.NavBarItem();
            this.btnThemLXe = new DevExpress.XtraNavBar.NavBarItem();
            this.CongViecGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnXemCV = new DevExpress.XtraNavBar.NavBarItem();
            this.btnThemCV = new DevExpress.XtraNavBar.NavBarItem();
            this.tasksItem = new DevExpress.XtraNavBar.NavBarItem();
            this.navbarImageCollectionLarge = new DevExpress.Utils.ImageCollection(this.components);
            this.navbarImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.splitContainerControlRight = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnChange = new DevExpress.XtraEditors.SimpleButton();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.panelMain = new DevExpress.XtraEditors.PanelControl();
            this.gridMain = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtpage = new DevExpress.XtraEditors.TextEdit();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnRe = new DevExpress.XtraEditors.SimpleButton();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.TaiKhoanGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnChangePass = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
            this.splitContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollectionLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollection)).BeginInit();
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
            // splitContainerControl
            // 
            resources.ApplyResources(this.splitContainerControl, "splitContainerControl");
            this.splitContainerControl.Name = "splitContainerControl";
            this.splitContainerControl.Panel1.Controls.Add(this.navBarControl);
            resources.ApplyResources(this.splitContainerControl.Panel1, "splitContainerControl.Panel1");
            this.splitContainerControl.Panel2.Controls.Add(this.splitContainerControlRight);
            resources.ApplyResources(this.splitContainerControl.Panel2, "splitContainerControl.Panel2");
            this.splitContainerControl.SplitterPosition = 173;
            // 
            // navBarControl
            // 
            this.navBarControl.ActiveGroup = this.TaiKhoanGroup;
            resources.ApplyResources(this.navBarControl, "navBarControl");
            this.navBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.HoaDonGroup,
            this.KhachHangGroup,
            this.XeGroup,
            this.LoaiXeGroup,
            this.CongViecGroup,
            this.TaiKhoanGroup});
            this.navBarControl.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.btnXemHoaDon,
            this.btnThemHoaDon,
            this.tasksItem,
            this.btnTimKhach,
            this.btnThemKH,
            this.btnXemXe,
            this.btnThemXe,
            this.btnXemLXe,
            this.btnThemLXe,
            this.btnXemCV,
            this.btnThemCV,
            this.btnChangePass});
            this.navBarControl.LargeImages = this.navbarImageCollectionLarge;
            this.navBarControl.Name = "navBarControl";
            this.navBarControl.OptionsNavPane.ExpandedWidth = ((int)(resources.GetObject("resource.ExpandedWidth")));
            this.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.ExplorerBar;
            this.navBarControl.SmallImages = this.navbarImageCollection;
            this.navBarControl.StoreDefaultPaintStyleName = true;
            // 
            // HoaDonGroup
            // 
            resources.ApplyResources(this.HoaDonGroup, "HoaDonGroup");
            this.HoaDonGroup.Expanded = true;
            this.HoaDonGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnXemHoaDon),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnThemHoaDon)});
            this.HoaDonGroup.Name = "HoaDonGroup";
            // 
            // btnXemHoaDon
            // 
            resources.ApplyResources(this.btnXemHoaDon, "btnXemHoaDon");
            this.btnXemHoaDon.Name = "btnXemHoaDon";
            this.btnXemHoaDon.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnXemHoaDon_LinkClicked);
            // 
            // btnThemHoaDon
            // 
            resources.ApplyResources(this.btnThemHoaDon, "btnThemHoaDon");
            this.btnThemHoaDon.Name = "btnThemHoaDon";
            this.btnThemHoaDon.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnThemHoaDon_LinkClicked);
            // 
            // KhachHangGroup
            // 
            resources.ApplyResources(this.KhachHangGroup, "KhachHangGroup");
            this.KhachHangGroup.Expanded = true;
            this.KhachHangGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnTimKhach),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnThemKH)});
            this.KhachHangGroup.Name = "KhachHangGroup";
            // 
            // btnTimKhach
            // 
            resources.ApplyResources(this.btnTimKhach, "btnTimKhach");
            this.btnTimKhach.Name = "btnTimKhach";
            this.btnTimKhach.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnTimKhach_LinkClicked);
            // 
            // btnThemKH
            // 
            resources.ApplyResources(this.btnThemKH, "btnThemKH");
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnThemKH_LinkClicked);
            // 
            // XeGroup
            // 
            resources.ApplyResources(this.XeGroup, "XeGroup");
            this.XeGroup.Expanded = true;
            this.XeGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnXemXe),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnThemXe)});
            this.XeGroup.Name = "XeGroup";
            // 
            // btnXemXe
            // 
            resources.ApplyResources(this.btnXemXe, "btnXemXe");
            this.btnXemXe.Name = "btnXemXe";
            this.btnXemXe.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnXemXe_LinkClicked);
            // 
            // btnThemXe
            // 
            resources.ApplyResources(this.btnThemXe, "btnThemXe");
            this.btnThemXe.Name = "btnThemXe";
            this.btnThemXe.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnThemXe_LinkClicked);
            // 
            // LoaiXeGroup
            // 
            resources.ApplyResources(this.LoaiXeGroup, "LoaiXeGroup");
            this.LoaiXeGroup.Expanded = true;
            this.LoaiXeGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnXemLXe),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnThemLXe)});
            this.LoaiXeGroup.Name = "LoaiXeGroup";
            // 
            // btnXemLXe
            // 
            resources.ApplyResources(this.btnXemLXe, "btnXemLXe");
            this.btnXemLXe.Name = "btnXemLXe";
            this.btnXemLXe.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnXemLXe_LinkClicked);
            // 
            // btnThemLXe
            // 
            resources.ApplyResources(this.btnThemLXe, "btnThemLXe");
            this.btnThemLXe.Name = "btnThemLXe";
            this.btnThemLXe.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnThemLXe_LinkClicked);
            // 
            // CongViecGroup
            // 
            resources.ApplyResources(this.CongViecGroup, "CongViecGroup");
            this.CongViecGroup.Expanded = true;
            this.CongViecGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnXemCV),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnThemCV)});
            this.CongViecGroup.Name = "CongViecGroup";
            // 
            // btnXemCV
            // 
            resources.ApplyResources(this.btnXemCV, "btnXemCV");
            this.btnXemCV.Name = "btnXemCV";
            this.btnXemCV.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnXemCV_LinkClicked);
            // 
            // btnThemCV
            // 
            resources.ApplyResources(this.btnThemCV, "btnThemCV");
            this.btnThemCV.Name = "btnThemCV";
            this.btnThemCV.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnThemCV_LinkClicked);
            // 
            // tasksItem
            // 
            resources.ApplyResources(this.tasksItem, "tasksItem");
            this.tasksItem.Name = "tasksItem";
            // 
            // navbarImageCollectionLarge
            // 
            this.navbarImageCollectionLarge.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("navbarImageCollectionLarge.ImageStream")));
            resources.ApplyResources(this.navbarImageCollectionLarge, "navbarImageCollectionLarge");
            this.navbarImageCollectionLarge.Images.SetKeyName(0, "Mail_16x16.png");
            this.navbarImageCollectionLarge.Images.SetKeyName(1, "Organizer_16x16.png");
            // 
            // navbarImageCollection
            // 
            this.navbarImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("navbarImageCollection.ImageStream")));
            resources.ApplyResources(this.navbarImageCollection, "navbarImageCollection");
            this.navbarImageCollection.Images.SetKeyName(0, "Inbox_16x16.png");
            this.navbarImageCollection.Images.SetKeyName(1, "Outbox_16x16.png");
            this.navbarImageCollection.Images.SetKeyName(2, "Drafts_16x16.png");
            this.navbarImageCollection.Images.SetKeyName(3, "Trash_16x16.png");
            this.navbarImageCollection.Images.SetKeyName(4, "Calendar_16x16.png");
            this.navbarImageCollection.Images.SetKeyName(5, "Tasks_16x16.png");
            // 
            // splitContainerControlRight
            // 
            resources.ApplyResources(this.splitContainerControlRight, "splitContainerControlRight");
            this.splitContainerControlRight.Horizontal = false;
            this.splitContainerControlRight.Name = "splitContainerControlRight";
            this.splitContainerControlRight.Panel1.Controls.Add(this.btnChange);
            this.splitContainerControlRight.Panel1.Controls.Add(this.btnReset);
            this.splitContainerControlRight.Panel1.Controls.Add(this.btnDelete);
            this.splitContainerControlRight.Panel1.Controls.Add(this.txtSearch);
            this.splitContainerControlRight.Panel1.Controls.Add(this.btnSearch);
            this.splitContainerControlRight.Panel1.Controls.Add(this.btnSave);
            resources.ApplyResources(this.splitContainerControlRight.Panel1, "splitContainerControlRight.Panel1");
            this.splitContainerControlRight.Panel2.Controls.Add(this.panelMain);
            resources.ApplyResources(this.splitContainerControlRight.Panel2, "splitContainerControlRight.Panel2");
            this.splitContainerControlRight.SplitterPosition = 45;
            // 
            // btnChange
            // 
            this.btnChange.Image = ((System.Drawing.Image)(resources.GetObject("btnChange.Image")));
            resources.ApplyResources(this.btnChange, "btnChange");
            this.btnChange.Name = "btnChange";
            this.btnChange.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnReset
            // 
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.Name = "btnReset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSearch
            // 
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.gridMain);
            this.panelMain.Controls.Add(this.txtpage);
            this.panelMain.Controls.Add(this.btnNext);
            this.panelMain.Controls.Add(this.btnRe);
            resources.ApplyResources(this.panelMain, "panelMain");
            this.panelMain.Name = "panelMain";
            // 
            // gridMain
            // 
            resources.ApplyResources(this.gridMain, "gridMain");
            this.gridMain.MainView = this.gridView;
            this.gridMain.Name = "gridMain";
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
            resources.ApplyResources(this.txtpage, "txtpage");
            this.txtpage.Name = "txtpage";
            this.txtpage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpage_KeyDown);
            // 
            // btnNext
            // 
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            resources.ApplyResources(this.btnNext, "btnNext");
            this.btnNext.Name = "btnNext";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnRe
            // 
            this.btnRe.Image = ((System.Drawing.Image)(resources.GetObject("btnRe.Image")));
            this.btnRe.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            resources.ApplyResources(this.btnRe, "btnRe");
            this.btnRe.Name = "btnRe";
            this.btnRe.Click += new System.EventHandler(this.btnRe_Click);
            // 
            // popupMenu1
            // 
            this.popupMenu1.Name = "popupMenu1";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Caramel";
            // 
            // TaiKhoanGroup
            // 
            resources.ApplyResources(this.TaiKhoanGroup, "TaiKhoanGroup");
            this.TaiKhoanGroup.Expanded = true;
            this.TaiKhoanGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnChangePass)});
            this.TaiKhoanGroup.Name = "TaiKhoanGroup";
            // 
            // btnChangePass
            // 
            resources.ApplyResources(this.btnChangePass, "btnChangePass");
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnChangePass_LinkClicked);
            // 
            // FormKeToan
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl);
            this.LookAndFeel.SkinName = "Caramel";
            this.Name = "FormKeToan";
            this.Load += new System.EventHandler(this.FormKeToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
            this.splitContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollectionLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollection)).EndInit();
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

        private void draftsItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl;
        private DevExpress.XtraNavBar.NavBarControl navBarControl;
        private DevExpress.XtraNavBar.NavBarGroup HoaDonGroup;
        private DevExpress.XtraNavBar.NavBarItem btnXemHoaDon;
        private DevExpress.XtraNavBar.NavBarItem btnThemHoaDon;
        private DevExpress.XtraNavBar.NavBarItem tasksItem;
        private DevExpress.Utils.ImageCollection navbarImageCollection;
        private DevExpress.Utils.ImageCollection navbarImageCollectionLarge;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControlRight;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraNavBar.NavBarGroup KhachHangGroup;
        private DevExpress.XtraNavBar.NavBarItem btnTimKhach;
        private DevExpress.XtraNavBar.NavBarItem btnThemKH;
        private DevExpress.XtraNavBar.NavBarGroup XeGroup;
        private DevExpress.XtraNavBar.NavBarItem btnXemXe;
        private DevExpress.XtraNavBar.NavBarItem btnThemXe;
        private DevExpress.XtraNavBar.NavBarGroup LoaiXeGroup;
        private DevExpress.XtraNavBar.NavBarItem btnXemLXe;
        private DevExpress.XtraNavBar.NavBarItem btnThemLXe;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.PanelControl panelMain;
        private DevExpress.XtraGrid.GridControl gridMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraEditors.TextEdit txtpage;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnRe;
        private DevExpress.XtraEditors.SimpleButton btnReset;
        private DevExpress.XtraEditors.SimpleButton btnChange;
        private DevExpress.XtraNavBar.NavBarGroup CongViecGroup;
        private DevExpress.XtraNavBar.NavBarItem btnXemCV;
        private DevExpress.XtraNavBar.NavBarItem btnThemCV;
        private DevExpress.XtraNavBar.NavBarGroup TaiKhoanGroup;
        private DevExpress.XtraNavBar.NavBarItem btnChangePass;

    }
}

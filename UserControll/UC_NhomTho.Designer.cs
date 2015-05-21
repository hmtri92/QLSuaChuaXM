namespace DeTai
{
    partial class UC_NhomTho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_NhomTho));
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtFullName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCheckMaNhom = new DevExpress.XtraEditors.SimpleButton();
            this.txtMa = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.NhomTruongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridThanhVien = new DevExpress.XtraGrid.GridControl();
            this.thoNhomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhomThoeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewThanhVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaTho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SearchLookUpEditTho = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.SearchLookUpEditNhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnResetCV = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddCongViec = new DevExpress.XtraEditors.SimpleButton();
            this.lookNhomTruong = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhomTruongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridThanhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoNhomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomThoeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewThanhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchLookUpEditTho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchLookUpEditNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookNhomTruong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(150, 205);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(98, 20);
            this.labelControl5.TabIndex = 46;
            this.labelControl5.Text = "Trưởng nhóm:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(285, 165);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Properties.Appearance.Options.UseFont = true;
            this.txtFullName.Size = new System.Drawing.Size(425, 26);
            this.txtFullName.TabIndex = 2;
            this.txtFullName.Click += new System.EventHandler(this.texbox_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(150, 170);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 20);
            this.labelControl2.TabIndex = 44;
            this.labelControl2.Text = "Tên nhóm:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(150, 239);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 20);
            this.labelControl1.TabIndex = 51;
            this.labelControl1.Text = "Thành viên:";
            // 
            // btnCheckMaNhom
            // 
            this.btnCheckMaNhom.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckMaNhom.Image")));
            this.btnCheckMaNhom.Location = new System.Drawing.Point(716, 121);
            this.btnCheckMaNhom.Name = "btnCheckMaNhom";
            this.btnCheckMaNhom.Size = new System.Drawing.Size(25, 25);
            this.btnCheckMaNhom.TabIndex = 1;
            this.btnCheckMaNhom.ToolTip = "Kiểm tra mã hợp lệ";
            this.btnCheckMaNhom.Click += new System.EventHandler(this.btnCheckMaNhom_Click);
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(283, 121);
            this.txtMa.Name = "txtMa";
            this.txtMa.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.Properties.Appearance.Options.UseFont = true;
            this.txtMa.Size = new System.Drawing.Size(427, 26);
            this.txtMa.TabIndex = 0;
            this.txtMa.Click += new System.EventHandler(this.texbox_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(148, 126);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 20);
            this.labelControl3.TabIndex = 73;
            this.labelControl3.Text = "Mã nhóm:";
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTitle.Location = new System.Drawing.Point(150, 57);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(140, 33);
            this.lblTitle.TabIndex = 75;
            this.lblTitle.Text = "Nhóm Thợ";
            // 
            // NhomTruongBindingSource
            // 
            this.NhomTruongBindingSource.DataSource = typeof(DeTai.NhanVien);
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataSource = typeof(DeTai.NhanVien);
            // 
            // gridThanhVien
            // 
            this.gridThanhVien.DataSource = this.thoNhomsBindingSource;
            this.gridThanhVien.Location = new System.Drawing.Point(288, 278);
            this.gridThanhVien.MainView = this.gridViewThanhVien;
            this.gridThanhVien.Name = "gridThanhVien";
            this.gridThanhVien.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.SearchLookUpEditTho});
            this.gridThanhVien.Size = new System.Drawing.Size(422, 217);
            this.gridThanhVien.TabIndex = 5;
            this.gridThanhVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewThanhVien});
            // 
            // thoNhomsBindingSource
            // 
            this.thoNhomsBindingSource.DataMember = "Tho_Nhoms";
            this.thoNhomsBindingSource.DataSource = this.nhomThoeBindingSource;
            // 
            // nhomThoeBindingSource
            // 
            this.nhomThoeBindingSource.DataSource = typeof(DeTai.NhomThoe);
            // 
            // gridViewThanhVien
            // 
            this.gridViewThanhVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaTho,
            this.colDelete});
            this.gridViewThanhVien.GridControl = this.gridThanhVien;
            this.gridViewThanhVien.Name = "gridViewThanhVien";
            // 
            // colMaTho
            // 
            this.colMaTho.Caption = "Thợ";
            this.colMaTho.ColumnEdit = this.SearchLookUpEditTho;
            this.colMaTho.FieldName = "MaTho";
            this.colMaTho.Name = "colMaTho";
            this.colMaTho.Visible = true;
            this.colMaTho.VisibleIndex = 0;
            this.colMaTho.Width = 248;
            // 
            // SearchLookUpEditTho
            // 
            this.SearchLookUpEditTho.AutoHeight = false;
            this.SearchLookUpEditTho.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SearchLookUpEditTho.DataSource = this.nhanVienBindingSource;
            this.SearchLookUpEditTho.DisplayMember = "TenNV";
            this.SearchLookUpEditTho.Name = "SearchLookUpEditTho";
            this.SearchLookUpEditTho.ValueMember = "MaNV";
            this.SearchLookUpEditTho.View = this.SearchLookUpEditNhanVien;
            // 
            // SearchLookUpEditNhanVien
            // 
            this.SearchLookUpEditNhanVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNV,
            this.colHoTen});
            this.SearchLookUpEditNhanVien.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.SearchLookUpEditNhanVien.Name = "SearchLookUpEditNhanVien";
            this.SearchLookUpEditNhanVien.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.SearchLookUpEditNhanVien.OptionsView.ShowGroupPanel = false;
            // 
            // colMaNV
            // 
            this.colMaNV.Caption = "Mã Thợ";
            this.colMaNV.FieldName = "MaNV";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Visible = true;
            this.colMaNV.VisibleIndex = 0;
            // 
            // colHoTen
            // 
            this.colHoTen.Caption = "Họ tên";
            this.colHoTen.FieldName = "TenNV";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Visible = true;
            this.colHoTen.VisibleIndex = 1;
            // 
            // colDelete
            // 
            this.colDelete.Caption = "Delete";
            this.colDelete.FieldName = "deleted";
            this.colDelete.Name = "colDelete";
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 1;
            // 
            // btnResetCV
            // 
            this.btnResetCV.Location = new System.Drawing.Point(669, 249);
            this.btnResetCV.Name = "btnResetCV";
            this.btnResetCV.Size = new System.Drawing.Size(41, 23);
            this.btnResetCV.TabIndex = 6;
            this.btnResetCV.Text = "Reset";
            // 
            // btnAddCongViec
            // 
            this.btnAddCongViec.Location = new System.Drawing.Point(616, 249);
            this.btnAddCongViec.Name = "btnAddCongViec";
            this.btnAddCongViec.Size = new System.Drawing.Size(47, 23);
            this.btnAddCongViec.TabIndex = 4;
            this.btnAddCongViec.Text = "Add";
            this.btnAddCongViec.Click += new System.EventHandler(this.btnAddCongViec_Click);
            // 
            // lookNhomTruong
            // 
            this.lookNhomTruong.Location = new System.Drawing.Point(285, 204);
            this.lookNhomTruong.Name = "lookNhomTruong";
            this.lookNhomTruong.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookNhomTruong.Properties.Appearance.Options.UseFont = true;
            this.lookNhomTruong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookNhomTruong.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaNV", "Mã", 71, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenNV", "Họ tên", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NamSinh", "Năm sinh", 79, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GioiTinh", "Nữ", 72, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookNhomTruong.Properties.DataSource = this.NhomTruongBindingSource;
            this.lookNhomTruong.Properties.DisplayMember = "TenNV";
            this.lookNhomTruong.Properties.NullText = "";
            this.lookNhomTruong.Properties.PopupSizeable = false;
            this.lookNhomTruong.Properties.ValueMember = "MaNV";
            this.lookNhomTruong.Size = new System.Drawing.Size(425, 26);
            this.lookNhomTruong.TabIndex = 3;
            this.lookNhomTruong.Click += new System.EventHandler(this.texbox_Click);
            // 
            // UC_NhomTho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnResetCV);
            this.Controls.Add(this.btnAddCongViec);
            this.Controls.Add(this.gridThanhVien);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnCheckMaNhom);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lookNhomTruong);
            this.Name = "UC_NhomTho";
            this.Size = new System.Drawing.Size(1000, 522);
            this.Load += new System.EventHandler(this.UC_NhomTho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhomTruongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridThanhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoNhomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomThoeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewThanhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchLookUpEditTho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchLookUpEditNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookNhomTruong.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtFullName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCheckMaNhom;
        private DevExpress.XtraEditors.TextEdit txtMa;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblTitle;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private System.Windows.Forms.BindingSource NhomTruongBindingSource;
        private DevExpress.XtraGrid.GridControl gridThanhVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewThanhVien;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTho;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit SearchLookUpEditTho;
        private DevExpress.XtraGrid.Views.Grid.GridView SearchLookUpEditNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private DevExpress.XtraEditors.SimpleButton btnResetCV;
        private DevExpress.XtraEditors.SimpleButton btnAddCongViec;
        private System.Windows.Forms.BindingSource thoNhomsBindingSource;
        private System.Windows.Forms.BindingSource nhomThoeBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraEditors.LookUpEdit lookNhomTruong;
    }
}

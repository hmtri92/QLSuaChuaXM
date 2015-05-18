namespace DeTai
{
    partial class UC_TaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_TaiKhoan));
            this.txtrePass = new DevExpress.XtraEditors.TextEdit();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblUserName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.rdoStay = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.btnCheckMaCV = new DevExpress.XtraEditors.SimpleButton();
            this.lookRole = new DevExpress.XtraEditors.GridLookUpEdit();
            this.quyenTruyCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenQuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.picWarningPassword = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtrePass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoStay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookRole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quyenTruyCapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWarningPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtrePass
            // 
            this.txtrePass.Location = new System.Drawing.Point(327, 178);
            this.txtrePass.Name = "txtrePass";
            this.txtrePass.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrePass.Properties.Appearance.Options.UseFont = true;
            this.txtrePass.Properties.PasswordChar = '*';
            this.txtrePass.Size = new System.Drawing.Size(418, 26);
            this.txtrePass.TabIndex = 2;
            this.txtrePass.Click += new System.EventHandler(this.texbox_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(327, 135);
            this.txtPass.Name = "txtPass";
            this.txtPass.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Properties.Appearance.Options.UseFont = true;
            this.txtPass.Properties.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(418, 26);
            this.txtPass.TabIndex = 1;
            this.txtPass.Click += new System.EventHandler(this.texbox_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(327, 94);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Properties.Appearance.Options.UseFont = true;
            this.txtUserName.Size = new System.Drawing.Size(418, 26);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Click += new System.EventHandler(this.texbox_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(186, 184);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(134, 20);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Nhập lại PassWord";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(186, 141);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(73, 20);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "PassWord";
            // 
            // lblUserName
            // 
            this.lblUserName.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(186, 100);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(78, 20);
            this.lblUserName.TabIndex = 14;
            this.lblUserName.Text = "User name";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(186, 263);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 20);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Trạng thái";
            // 
            // rdoStay
            // 
            this.rdoStay.Location = new System.Drawing.Point(326, 263);
            this.rdoStay.Name = "rdoStay";
            this.rdoStay.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoStay.Properties.Appearance.Options.UseFont = true;
            this.rdoStay.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Mở"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Khóa")});
            this.rdoStay.Size = new System.Drawing.Size(418, 27);
            this.rdoStay.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(186, 223);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 20);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "Quyền";
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTitle.Location = new System.Drawing.Point(186, 44);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(132, 33);
            this.lblTitle.TabIndex = 33;
            this.lblTitle.Text = "Tài khoản";
            // 
            // btnCheckMaCV
            // 
            this.btnCheckMaCV.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckMaCV.Image")));
            this.btnCheckMaCV.Location = new System.Drawing.Point(751, 95);
            this.btnCheckMaCV.Name = "btnCheckMaCV";
            this.btnCheckMaCV.Size = new System.Drawing.Size(25, 25);
            this.btnCheckMaCV.TabIndex = 71;
            this.btnCheckMaCV.Click += new System.EventHandler(this.btnCheckMaCV_Click);
            // 
            // lookRole
            // 
            this.lookRole.Location = new System.Drawing.Point(327, 219);
            this.lookRole.Name = "lookRole";
            this.lookRole.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookRole.Properties.Appearance.Options.UseFont = true;
            this.lookRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookRole.Properties.DataSource = this.quyenTruyCapBindingSource;
            this.lookRole.Properties.DisplayMember = "TenQuyen";
            this.lookRole.Properties.ValueMember = "MaQuyen";
            this.lookRole.Properties.View = this.gridLookUpEdit1View;
            this.lookRole.Size = new System.Drawing.Size(417, 26);
            this.lookRole.TabIndex = 3;
            this.lookRole.Click += new System.EventHandler(this.texbox_Click);
            // 
            // quyenTruyCapBindingSource
            // 
            this.quyenTruyCapBindingSource.DataSource = typeof(DeTai.QuyenTruyCap);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenQuyen,
            this.colNotes});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colTenQuyen
            // 
            this.colTenQuyen.Caption = "Tên tài khoản";
            this.colTenQuyen.FieldName = "TenQuyen";
            this.colTenQuyen.Name = "colTenQuyen";
            this.colTenQuyen.Visible = true;
            this.colTenQuyen.VisibleIndex = 0;
            // 
            // colNotes
            // 
            this.colNotes.Caption = "Ghi chú";
            this.colNotes.FieldName = "GhiChu";
            this.colNotes.Name = "colNotes";
            this.colNotes.Visible = true;
            this.colNotes.VisibleIndex = 1;
            // 
            // picWarningPassword
            // 
            this.picWarningPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picWarningPassword.EditValue = ((object)(resources.GetObject("picWarningPassword.EditValue")));
            this.picWarningPassword.Location = new System.Drawing.Point(751, 177);
            this.picWarningPassword.Name = "picWarningPassword";
            this.picWarningPassword.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picWarningPassword.Properties.Appearance.Options.UseBackColor = true;
            this.picWarningPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picWarningPassword.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picWarningPassword.Size = new System.Drawing.Size(25, 27);
            this.picWarningPassword.TabIndex = 72;
            this.picWarningPassword.Visible = false;
            // 
            // UC_TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picWarningPassword);
            this.Controls.Add(this.btnCheckMaCV);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.rdoStay);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtrePass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lookRole);
            this.Name = "UC_TaiKhoan";
            this.Size = new System.Drawing.Size(1000, 348);
            this.Load += new System.EventHandler(this.UC_TaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtrePass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoStay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookRole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quyenTruyCapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWarningPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtrePass;
        private DevExpress.XtraEditors.TextEdit txtPass;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblUserName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.RadioGroup rdoStay;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.BindingSource quyenTruyCapBindingSource;
        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.SimpleButton btnCheckMaCV;
        private DevExpress.XtraEditors.GridLookUpEdit lookRole;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colTenQuyen;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private DevExpress.XtraEditors.PictureEdit picWarningPassword;
    }
}

namespace DeTai
{
    partial class UC_CongViec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CongViec));
            this.txtTienCong = new DevExpress.XtraEditors.TextEdit();
            this.txtMaCV = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMoTa = new DevExpress.XtraEditors.MemoEdit();
            this.txtTenCV = new DevExpress.XtraEditors.TextEdit();
            this.btnCheckMaCV = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienCong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTienCong
            // 
            this.txtTienCong.EditValue = 0D;
            this.txtTienCong.Location = new System.Drawing.Point(281, 169);
            this.txtTienCong.Name = "txtTienCong";
            this.txtTienCong.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienCong.Properties.Appearance.Options.UseFont = true;
            this.txtTienCong.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTienCong.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTienCong.Properties.Mask.EditMask = "n";
            this.txtTienCong.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTienCong.Size = new System.Drawing.Size(444, 26);
            this.txtTienCong.TabIndex = 2;
            this.txtTienCong.Click += new System.EventHandler(this.texBox_Click);
            // 
            // txtMaCV
            // 
            this.txtMaCV.Location = new System.Drawing.Point(282, 92);
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCV.Properties.Appearance.Options.UseFont = true;
            this.txtMaCV.Size = new System.Drawing.Size(444, 26);
            this.txtMaCV.TabIndex = 0;
            this.txtMaCV.Click += new System.EventHandler(this.texBox_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(166, 176);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(69, 20);
            this.labelControl8.TabIndex = 66;
            this.labelControl8.Text = "Tiền công";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(167, 139);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(97, 20);
            this.labelControl7.TabIndex = 65;
            this.labelControl7.Text = "Tên công việc";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(167, 99);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(92, 20);
            this.labelControl6.TabIndex = 64;
            this.labelControl6.Text = "Mã công việc";
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTitle.Location = new System.Drawing.Point(166, 48);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(185, 29);
            this.lblTitle.TabIndex = 63;
            this.lblTitle.Text = "Thêm công việc";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(167, 216);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 20);
            this.labelControl1.TabIndex = 67;
            this.labelControl1.Text = "Mô tả";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(276, 212);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Properties.Appearance.Options.UseFont = true;
            this.txtMoTa.Size = new System.Drawing.Size(481, 212);
            this.txtMoTa.TabIndex = 3;
            this.txtMoTa.Click += new System.EventHandler(this.texBox_Click);
            // 
            // txtTenCV
            // 
            this.txtTenCV.Location = new System.Drawing.Point(282, 133);
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenCV.Properties.Appearance.Options.UseFont = true;
            this.txtTenCV.Size = new System.Drawing.Size(444, 26);
            this.txtTenCV.TabIndex = 1;
            this.txtTenCV.Click += new System.EventHandler(this.texBox_Click);
            // 
            // btnCheckMaCV
            // 
            this.btnCheckMaCV.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckMaCV.Image")));
            this.btnCheckMaCV.Location = new System.Drawing.Point(732, 94);
            this.btnCheckMaCV.Name = "btnCheckMaCV";
            this.btnCheckMaCV.Size = new System.Drawing.Size(25, 25);
            this.btnCheckMaCV.TabIndex = 70;
            this.btnCheckMaCV.Click += new System.EventHandler(this.btnCheckMaCV_Click);
            // 
            // UC_CongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCheckMaCV);
            this.Controls.Add(this.txtTenCV);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtTienCong);
            this.Controls.Add(this.txtMaCV);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.lblTitle);
            this.Name = "UC_CongViec";
            this.Size = new System.Drawing.Size(1000, 470);
            ((System.ComponentModel.ISupportInitialize)(this.txtTienCong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCV.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtTienCong;
        private DevExpress.XtraEditors.TextEdit txtMaCV;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit txtMoTa;
        private DevExpress.XtraEditors.TextEdit txtTenCV;
        private DevExpress.XtraEditors.SimpleButton btnCheckMaCV;
    }
}

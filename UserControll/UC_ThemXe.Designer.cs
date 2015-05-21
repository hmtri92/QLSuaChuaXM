namespace DeTai
{
    partial class UC_ThemXe
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
            this.txtColor = new DevExpress.XtraEditors.TextEdit();
            this.txtPlate = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.lookLoaiXe = new DevExpress.XtraEditors.LookUpEdit();
            this.loaiXeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookLoaiXe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiXeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(349, 135);
            this.txtColor.Name = "txtColor";
            this.txtColor.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.Properties.Appearance.Options.UseFont = true;
            this.txtColor.Size = new System.Drawing.Size(390, 26);
            this.txtColor.TabIndex = 2;
            this.txtColor.Click += new System.EventHandler(this.texbox_click);
            // 
            // txtPlate
            // 
            this.txtPlate.Location = new System.Drawing.Point(350, 58);
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlate.Properties.Appearance.Options.UseFont = true;
            this.txtPlate.Size = new System.Drawing.Size(390, 26);
            this.txtPlate.TabIndex = 0;
            this.txtPlate.Click += new System.EventHandler(this.texbox_click);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(234, 142);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(51, 20);
            this.labelControl8.TabIndex = 59;
            this.labelControl8.Text = "Màu xe";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(235, 105);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(50, 20);
            this.labelControl7.TabIndex = 58;
            this.labelControl7.Text = "Loại xe";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(235, 65);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(40, 20);
            this.labelControl6.TabIndex = 57;
            this.labelControl6.Text = "Số xe";
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTitle.Location = new System.Drawing.Point(233, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(101, 29);
            this.lblTitle.TabIndex = 56;
            this.lblTitle.Text = "Thêm xe";
            // 
            // lookLoaiXe
            // 
            this.lookLoaiXe.Location = new System.Drawing.Point(349, 98);
            this.lookLoaiXe.Name = "lookLoaiXe";
            this.lookLoaiXe.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookLoaiXe.Properties.Appearance.Options.UseFont = true;
            this.lookLoaiXe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookLoaiXe.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaLXe", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenLXe", "Tên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MoTa", "Mô tả"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("deleted", "Deleted", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.lookLoaiXe.Properties.DataSource = this.loaiXeBindingSource;
            this.lookLoaiXe.Properties.DisplayMember = "TenLXe";
            this.lookLoaiXe.Properties.ValueMember = "MaLXe";
            this.lookLoaiXe.Size = new System.Drawing.Size(390, 26);
            this.lookLoaiXe.TabIndex = 1;
            // 
            // loaiXeBindingSource
            // 
            this.loaiXeBindingSource.DataSource = typeof(DeTai.LoaiXe);
            // 
            // UC_ThemXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lookLoaiXe);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtPlate);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.lblTitle);
            this.Name = "UC_ThemXe";
            this.Size = new System.Drawing.Size(1000, 193);
            this.Load += new System.EventHandler(this.UC_ThemXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookLoaiXe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiXeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtColor;
        private DevExpress.XtraEditors.TextEdit txtPlate;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.LookUpEdit lookLoaiXe;
        private System.Windows.Forms.BindingSource loaiXeBindingSource;
    }
}

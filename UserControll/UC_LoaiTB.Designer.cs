namespace DeTai
{
    partial class UC_LoaiTB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_LoaiTB));
            this.txtMoTa = new DevExpress.XtraEditors.MemoEdit();
            this.txTen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtMa = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCheckMaNhom = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(309, 234);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Properties.Appearance.Options.UseFont = true;
            this.txtMoTa.Size = new System.Drawing.Size(467, 185);
            this.txtMoTa.TabIndex = 2;
            // 
            // txTen
            // 
            this.txTen.Location = new System.Drawing.Point(309, 185);
            this.txTen.Name = "txTen";
            this.txTen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTen.Properties.Appearance.Options.UseFont = true;
            this.txTen.Size = new System.Drawing.Size(468, 26);
            this.txTen.TabIndex = 1;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Location = new System.Drawing.Point(163, 236);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(45, 19);
            this.labelControl14.TabIndex = 55;
            this.labelControl14.Text = "Mô tả:";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Location = new System.Drawing.Point(163, 189);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(117, 19);
            this.labelControl15.TabIndex = 54;
            this.labelControl15.Text = "Tên loại thiết bị:";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl13.Location = new System.Drawing.Point(163, 71);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(142, 29);
            this.labelControl13.TabIndex = 53;
            this.labelControl13.Text = "Loại thiết bị";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(309, 135);
            this.txtMa.Name = "txtMa";
            this.txtMa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.Properties.Appearance.Options.UseFont = true;
            this.txtMa.Size = new System.Drawing.Size(468, 26);
            this.txtMa.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(163, 139);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(110, 19);
            this.labelControl1.TabIndex = 60;
            this.labelControl1.Text = "Mã loại thiết bị:";
            // 
            // btnCheckMaNhom
            // 
            this.btnCheckMaNhom.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckMaNhom.Image")));
            this.btnCheckMaNhom.Location = new System.Drawing.Point(783, 136);
            this.btnCheckMaNhom.Name = "btnCheckMaNhom";
            this.btnCheckMaNhom.Size = new System.Drawing.Size(25, 25);
            this.btnCheckMaNhom.TabIndex = 62;
            this.btnCheckMaNhom.ToolTip = "Kiểm tra mã hợp lệ";
            this.btnCheckMaNhom.Click += new System.EventHandler(this.btnCheckMaNhom_Click);
            // 
            // UC_LoaiTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCheckMaNhom);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txTen);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.labelControl13);
            this.Name = "UC_LoaiTB";
            this.Size = new System.Drawing.Size(1000, 450);
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit txtMoTa;
        private DevExpress.XtraEditors.TextEdit txTen;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit txtMa;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCheckMaNhom;
    }
}

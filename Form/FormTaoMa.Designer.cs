namespace DeTai
{
    partial class FormTaoMa
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
            this.txtNguon = new DevExpress.XtraEditors.TextEdit();
            this.txtKetQua = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKetQua.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNguon
            // 
            this.txtNguon.Location = new System.Drawing.Point(36, 45);
            this.txtNguon.Name = "txtNguon";
            this.txtNguon.Size = new System.Drawing.Size(195, 20);
            this.txtNguon.TabIndex = 0;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(45, 121);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(195, 20);
            this.txtKetQua.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(113, 83);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FormTaoMa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 262);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtNguon);
            this.Name = "FormTaoMa";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.txtNguon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKetQua.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtNguon;
        private DevExpress.XtraEditors.TextEdit txtKetQua;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}
namespace QuanLyTiemThuocDongY
{
    partial class DoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoiMatKhau));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.tbMatKhauMoi = new System.Windows.Forms.TextBox();
            this.tbXacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.btXacNhan = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // tbMatKhau
            // 
            resources.ApplyResources(this.tbMatKhau, "tbMatKhau");
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.UseSystemPasswordChar = true;
            // 
            // tbMatKhauMoi
            // 
            resources.ApplyResources(this.tbMatKhauMoi, "tbMatKhauMoi");
            this.tbMatKhauMoi.Name = "tbMatKhauMoi";
            this.tbMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // tbXacNhanMatKhau
            // 
            resources.ApplyResources(this.tbXacNhanMatKhau, "tbXacNhanMatKhau");
            this.tbXacNhanMatKhau.Name = "tbXacNhanMatKhau";
            this.tbXacNhanMatKhau.UseSystemPasswordChar = true;
            // 
            // btXacNhan
            // 
            resources.ApplyResources(this.btXacNhan, "btXacNhan");
            this.btXacNhan.Name = "btXacNhan";
            this.btXacNhan.UseVisualStyleBackColor = true;
            this.btXacNhan.Click += new System.EventHandler(this.btXacNhan_Click);
            // 
            // btHuy
            // 
            resources.ApplyResources(this.btHuy, "btHuy");
            this.btHuy.Name = "btHuy";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // DoiMatKhau
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btXacNhan);
            this.Controls.Add(this.tbXacNhanMatKhau);
            this.Controls.Add(this.tbMatKhauMoi);
            this.Controls.Add(this.tbMatKhau);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "DoiMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMatKhau;
        private System.Windows.Forms.TextBox tbMatKhauMoi;
        private System.Windows.Forms.TextBox tbXacNhanMatKhau;
        private System.Windows.Forms.Button btXacNhan;
        private System.Windows.Forms.Button btHuy;
    }
}
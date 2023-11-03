namespace Buoi05_04
{
    partial class Form1
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
            this.picBox = new System.Windows.Forms.PictureBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.btnChonTapTin = new System.Windows.Forms.Button();
            this.btnLuuTapTin = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.Image = global::Buoi05_04.Properties.Resources._1918270;
            this.picBox.Location = new System.Drawing.Point(35, 30);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(213, 258);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(287, 30);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(465, 258);
            this.txtNoiDung.TabIndex = 1;
            this.txtNoiDung.Text = "nội dụng văn bản";
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Location = new System.Drawing.Point(35, 313);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(213, 58);
            this.btnChonAnh.TabIndex = 2;
            this.btnChonAnh.Text = "Chọn hình ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // btnChonTapTin
            // 
            this.btnChonTapTin.Location = new System.Drawing.Point(287, 313);
            this.btnChonTapTin.Name = "btnChonTapTin";
            this.btnChonTapTin.Size = new System.Drawing.Size(140, 58);
            this.btnChonTapTin.TabIndex = 2;
            this.btnChonTapTin.Text = "Chọn tập tin";
            this.btnChonTapTin.UseVisualStyleBackColor = true;
            this.btnChonTapTin.Click += new System.EventHandler(this.btnChonTapTin_Click);
            // 
            // btnLuuTapTin
            // 
            this.btnLuuTapTin.Location = new System.Drawing.Point(452, 313);
            this.btnLuuTapTin.Name = "btnLuuTapTin";
            this.btnLuuTapTin.Size = new System.Drawing.Size(140, 58);
            this.btnLuuTapTin.TabIndex = 2;
            this.btnLuuTapTin.Text = "Lưu tập tin";
            this.btnLuuTapTin.UseVisualStyleBackColor = true;
            this.btnLuuTapTin.Click += new System.EventHandler(this.btnLuuTapTin_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(612, 313);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(140, 58);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 395);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuuTapTin);
            this.Controls.Add(this.btnChonTapTin);
            this.Controls.Add(this.btnChonAnh);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.picBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Button btnChonTapTin;
        private System.Windows.Forms.Button btnLuuTapTin;
        private System.Windows.Forms.Button btnThoat;
    }
}


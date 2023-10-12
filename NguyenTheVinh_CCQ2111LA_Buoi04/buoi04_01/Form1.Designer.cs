using System;

namespace buoi04_01
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtB_HoTen = new System.Windows.Forms.TextBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btnChon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbDanhSach = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXoaAll_Click = new System.Windows.Forms.Button();
            this.btnXoa1_Click = new System.Windows.Forms.Button();
            this.btnThemAll_Click = new System.Windows.Forms.Button();
            this.btnThem1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbSinhVien = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTip1 = new System.Windows.Forms.ToolTip();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtB_HoTen);
            this.groupBox1.Controls.Add(this.btn_Thoat);
            this.groupBox1.Controls.Add(this.btnChon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm sinh viên";
            // 
            // txtB_HoTen
            // 
            this.txtB_HoTen.Location = new System.Drawing.Point(84, 31);
            this.txtB_HoTen.Name = "txtB_HoTen";
            this.txtB_HoTen.Size = new System.Drawing.Size(384, 20);
            this.txtB_HoTen.TabIndex = 2;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Thoat.Location = new System.Drawing.Point(617, 24);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 32);
            this.btn_Thoat.TabIndex = 1;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(511, 24);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 32);
            this.btnChon.TabIndex = 1;
            this.btnChon.Text = "Thêm";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbDanhSach);
            this.groupBox2.Location = new System.Drawing.Point(28, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 334);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sinh viên";
            // 
            // lbDanhSach
            // 
            this.lbDanhSach.FormattingEnabled = true;
            this.lbDanhSach.Location = new System.Drawing.Point(7, 20);
            this.lbDanhSach.Name = "lbDanhSach";
            this.lbDanhSach.Size = new System.Drawing.Size(230, 303);
            this.lbDanhSach.TabIndex = 0;
            this.lbDanhSach.SelectedIndexChanged += new System.EventHandler(this.lbDanhSach_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbKhoa);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnXoaAll_Click);
            this.groupBox3.Controls.Add(this.btnXoa1_Click);
            this.groupBox3.Controls.Add(this.btnThemAll_Click);
            this.groupBox3.Controls.Add(this.btnThem1);
            this.groupBox3.Location = new System.Drawing.Point(289, 128);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(155, 277);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // cbKhoa
            // 
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Items.AddRange(new object[] {
            "Công nghệ thông tin",
            "Cơ khí",
            "Nhà hàng",
            "Quản trị kinh doanh",
            "Kĩ thuật ô tô",
            "Quản trị khách sạn",
            "Du lịch"});
            this.cbKhoa.Location = new System.Drawing.Point(18, 47);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(121, 21);
            this.cbKhoa.TabIndex = 0;
            this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Khoa";
            // 
            // btnXoaAll_Click
            // 
            this.btnXoaAll_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaAll_Click.Location = new System.Drawing.Point(18, 228);
            this.btnXoaAll_Click.Name = "btnXoaAll_Click";
            this.btnXoaAll_Click.Size = new System.Drawing.Size(121, 33);
            this.btnXoaAll_Click.TabIndex = 1;
            this.btnXoaAll_Click.Text = "<<";
            this.btnXoaAll_Click.UseVisualStyleBackColor = true;
            this.btnXoaAll_Click.Click += new System.EventHandler(this.btnXoaAll_Click_Click);
            // 
            // btnXoa1_Click
            // 
            this.btnXoa1_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa1_Click.Location = new System.Drawing.Point(18, 177);
            this.btnXoa1_Click.Name = "btnXoa1_Click";
            this.btnXoa1_Click.Size = new System.Drawing.Size(121, 33);
            this.btnXoa1_Click.TabIndex = 1;
            this.btnXoa1_Click.Text = "<";
            this.btnXoa1_Click.UseVisualStyleBackColor = true;
            this.btnXoa1_Click.Click += new System.EventHandler(this.btnXoa1_Click_Click);
            // 
            // btnThemAll_Click
            // 
            this.btnThemAll_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemAll_Click.Location = new System.Drawing.Point(18, 127);
            this.btnThemAll_Click.Name = "btnThemAll_Click";
            this.btnThemAll_Click.Size = new System.Drawing.Size(121, 33);
            this.btnThemAll_Click.TabIndex = 1;
            this.btnThemAll_Click.Text = ">>";
            this.btnThemAll_Click.UseVisualStyleBackColor = true;
            this.btnThemAll_Click.Click += new System.EventHandler(this.btnThemAll_Click_Click);
            // 
            // btnThem1
            // 
            this.btnThem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem1.Location = new System.Drawing.Point(18, 79);
            this.btnThem1.Name = "btnThem1";
            this.btnThem1.Size = new System.Drawing.Size(121, 33);
            this.btnThem1.TabIndex = 1;
            this.btnThem1.Text = ">";
            this.btnThem1.UseVisualStyleBackColor = true;
            this.btnThem1.Click += new System.EventHandler(this.btnThem1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbSinhVien);
            this.groupBox4.Location = new System.Drawing.Point(465, 128);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(381, 340);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sinh viên được chọn";
            // 
            // lbSinhVien
            // 
            this.lbSinhVien.CheckBoxes = true;
            this.lbSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lbSinhVien.HideSelection = false;
            this.lbSinhVien.Location = new System.Drawing.Point(6, 20);
            this.lbSinhVien.Name = "lbSinhVien";
            this.lbSinhVien.Size = new System.Drawing.Size(369, 314);
            this.lbSinhVien.TabIndex = 0;
            this.lbSinhVien.UseCompatibleStateImageBehavior = false;
            this.lbSinhVien.View = System.Windows.Forms.View.Details;
            this.lbSinhVien.SelectedIndexChanged += new System.EventHandler(this.lbSinhVien_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Họ tên";
            this.columnHeader3.Width = 185;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Khoa";
            this.columnHeader4.Width = 317;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 550);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtB_HoTen;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXoaAll_Click;
        private System.Windows.Forms.Button btnXoa1_Click;
        private System.Windows.Forms.Button btnThemAll_Click;
        private System.Windows.Forms.Button btnThem1;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListBox lbDanhSach;
        private System.Windows.Forms.ListView lbSinhVien;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}


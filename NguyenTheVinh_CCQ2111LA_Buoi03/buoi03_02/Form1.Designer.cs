namespace buoi03_02
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
            this.gBox_Info = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBox_Name = new System.Windows.Forms.TextBox();
            this.rb_Nam = new System.Windows.Forms.RadioButton();
            this.rb_Nu = new System.Windows.Forms.RadioButton();
            this.cb_TheThao = new System.Windows.Forms.CheckBox();
            this.cb_DuLich = new System.Windows.Forms.CheckBox();
            this.cb_MuaSam = new System.Windows.Forms.CheckBox();
            this.gBox_func = new System.Windows.Forms.GroupBox();
            this.gBox_List = new System.Windows.Forms.GroupBox();
            this.btn_AddList = new System.Windows.Forms.Button();
            this.btn_RemoveList = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.mTxt_Mssv = new System.Windows.Forms.MaskedTextBox();
            this.mTxt_Date = new System.Windows.Forms.MaskedTextBox();
            this.txtDanhSach = new System.Windows.Forms.Label();
            this.gBox_Info.SuspendLayout();
            this.gBox_func.SuspendLayout();
            this.gBox_List.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBox_Info
            // 
            this.gBox_Info.Controls.Add(this.mTxt_Date);
            this.gBox_Info.Controls.Add(this.mTxt_Mssv);
            this.gBox_Info.Controls.Add(this.cb_MuaSam);
            this.gBox_Info.Controls.Add(this.cb_DuLich);
            this.gBox_Info.Controls.Add(this.cb_TheThao);
            this.gBox_Info.Controls.Add(this.rb_Nu);
            this.gBox_Info.Controls.Add(this.rb_Nam);
            this.gBox_Info.Controls.Add(this.txtBox_Name);
            this.gBox_Info.Controls.Add(this.label5);
            this.gBox_Info.Controls.Add(this.label4);
            this.gBox_Info.Controls.Add(this.label3);
            this.gBox_Info.Controls.Add(this.label2);
            this.gBox_Info.Controls.Add(this.label1);
            this.gBox_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBox_Info.Location = new System.Drawing.Point(28, 53);
            this.gBox_Info.Name = "gBox_Info";
            this.gBox_Info.Size = new System.Drawing.Size(255, 323);
            this.gBox_Info.TabIndex = 0;
            this.gBox_Info.TabStop = false;
            this.gBox_Info.Text = "Nhập thông tin";
            this.gBox_Info.Enter += new System.EventHandler(this.gBox_Info_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sở thích";
            // 
            // txtBox_Name
            // 
            this.txtBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Name.Location = new System.Drawing.Point(96, 76);
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.Size = new System.Drawing.Size(153, 20);
            this.txtBox_Name.TabIndex = 1;
            // 
            // rb_Nam
            // 
            this.rb_Nam.AutoSize = true;
            this.rb_Nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Nam.Location = new System.Drawing.Point(96, 178);
            this.rb_Nam.Name = "rb_Nam";
            this.rb_Nam.Size = new System.Drawing.Size(47, 17);
            this.rb_Nam.TabIndex = 2;
            this.rb_Nam.TabStop = true;
            this.rb_Nam.Text = "Nam";
            this.rb_Nam.UseVisualStyleBackColor = true;
            // 
            // rb_Nu
            // 
            this.rb_Nu.AutoSize = true;
            this.rb_Nu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Nu.Location = new System.Drawing.Point(184, 180);
            this.rb_Nu.Name = "rb_Nu";
            this.rb_Nu.Size = new System.Drawing.Size(39, 17);
            this.rb_Nu.TabIndex = 2;
            this.rb_Nu.TabStop = true;
            this.rb_Nu.Text = "Nữ";
            this.rb_Nu.UseVisualStyleBackColor = true;
            // 
            // cb_TheThao
            // 
            this.cb_TheThao.AutoSize = true;
            this.cb_TheThao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TheThao.Location = new System.Drawing.Point(96, 221);
            this.cb_TheThao.Name = "cb_TheThao";
            this.cb_TheThao.Size = new System.Drawing.Size(69, 17);
            this.cb_TheThao.TabIndex = 3;
            this.cb_TheThao.Text = "Thể thao";
            this.cb_TheThao.UseVisualStyleBackColor = true;
            // 
            // cb_DuLich
            // 
            this.cb_DuLich.AutoSize = true;
            this.cb_DuLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_DuLich.Location = new System.Drawing.Point(96, 244);
            this.cb_DuLich.Name = "cb_DuLich";
            this.cb_DuLich.Size = new System.Drawing.Size(59, 17);
            this.cb_DuLich.TabIndex = 3;
            this.cb_DuLich.Text = "Du lịch";
            this.cb_DuLich.UseVisualStyleBackColor = true;
            // 
            // cb_MuaSam
            // 
            this.cb_MuaSam.AutoSize = true;
            this.cb_MuaSam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_MuaSam.Location = new System.Drawing.Point(96, 267);
            this.cb_MuaSam.Name = "cb_MuaSam";
            this.cb_MuaSam.Size = new System.Drawing.Size(69, 17);
            this.cb_MuaSam.TabIndex = 3;
            this.cb_MuaSam.Text = "Mua sắm";
            this.cb_MuaSam.UseVisualStyleBackColor = true;
            // 
            // gBox_func
            // 
            this.gBox_func.Controls.Add(this.btn_Thoat);
            this.gBox_func.Controls.Add(this.btn_RemoveList);
            this.gBox_func.Controls.Add(this.btn_AddList);
            this.gBox_func.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBox_func.Location = new System.Drawing.Point(312, 53);
            this.gBox_func.Name = "gBox_func";
            this.gBox_func.Size = new System.Drawing.Size(454, 76);
            this.gBox_func.TabIndex = 1;
            this.gBox_func.TabStop = false;
            this.gBox_func.Text = "Chức năng";
            // 
            // gBox_List
            // 
            this.gBox_List.Controls.Add(this.txtDanhSach);
            this.gBox_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBox_List.Location = new System.Drawing.Point(312, 154);
            this.gBox_List.Name = "gBox_List";
            this.gBox_List.Size = new System.Drawing.Size(454, 222);
            this.gBox_List.TabIndex = 1;
            this.gBox_List.TabStop = false;
            this.gBox_List.Text = "Danh sách";
            // 
            // btn_AddList
            // 
            this.btn_AddList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddList.Location = new System.Drawing.Point(6, 19);
            this.btn_AddList.Name = "btn_AddList";
            this.btn_AddList.Size = new System.Drawing.Size(135, 38);
            this.btn_AddList.TabIndex = 0;
            this.btn_AddList.Text = "Thêm vào DS";
            this.btn_AddList.UseVisualStyleBackColor = true;
            this.btn_AddList.Click += new System.EventHandler(this.btn_AddList_Click);
            // 
            // btn_RemoveList
            // 
            this.btn_RemoveList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveList.Location = new System.Drawing.Point(158, 19);
            this.btn_RemoveList.Name = "btn_RemoveList";
            this.btn_RemoveList.Size = new System.Drawing.Size(135, 38);
            this.btn_RemoveList.TabIndex = 0;
            this.btn_RemoveList.Text = "Xóa DS";
            this.btn_RemoveList.UseVisualStyleBackColor = true;
            this.btn_RemoveList.Click += new System.EventHandler(this.btn_RemoveList_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(299, 20);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(135, 38);
            this.btn_Thoat.TabIndex = 0;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // mTxt_Mssv
            // 
            this.mTxt_Mssv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTxt_Mssv.Location = new System.Drawing.Point(96, 36);
            this.mTxt_Mssv.Mask = "2100000000";
            this.mTxt_Mssv.Name = "mTxt_Mssv";
            this.mTxt_Mssv.Size = new System.Drawing.Size(153, 20);
            this.mTxt_Mssv.TabIndex = 4;
            this.mTxt_Mssv.ValidatingType = typeof(int);
            this.mTxt_Mssv.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mTxt_Mssv_MaskInputRejected);
            // 
            // mTxt_Date
            // 
            this.mTxt_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTxt_Date.Location = new System.Drawing.Point(96, 122);
            this.mTxt_Date.Mask = "00/00/0000";
            this.mTxt_Date.Name = "mTxt_Date";
            this.mTxt_Date.Size = new System.Drawing.Size(153, 20);
            this.mTxt_Date.TabIndex = 4;
            this.mTxt_Date.ValidatingType = typeof(System.DateTime);
            // 
            // txtDanhSach
            // 
            this.txtDanhSach.AutoSize = true;
            this.txtDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDanhSach.Location = new System.Drawing.Point(20, 28);
            this.txtDanhSach.MaximumSize = new System.Drawing.Size(425, 0);
            this.txtDanhSach.Name = "txtDanhSach";
            this.txtDanhSach.Size = new System.Drawing.Size(0, 13);
            this.txtDanhSach.TabIndex = 2;
            this.txtDanhSach.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gBox_List);
            this.Controls.Add(this.gBox_func);
            this.Controls.Add(this.gBox_Info);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gBox_Info.ResumeLayout(false);
            this.gBox_Info.PerformLayout();
            this.gBox_func.ResumeLayout(false);
            this.gBox_List.ResumeLayout(false);
            this.gBox_List.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBox_Info;
        private System.Windows.Forms.CheckBox cb_MuaSam;
        private System.Windows.Forms.CheckBox cb_DuLich;
        private System.Windows.Forms.CheckBox cb_TheThao;
        private System.Windows.Forms.RadioButton rb_Nu;
        private System.Windows.Forms.RadioButton rb_Nam;
        private System.Windows.Forms.TextBox txtBox_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gBox_func;
        private System.Windows.Forms.GroupBox gBox_List;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_RemoveList;
        private System.Windows.Forms.Button btn_AddList;
        private System.Windows.Forms.MaskedTextBox mTxt_Date;
        private System.Windows.Forms.MaskedTextBox mTxt_Mssv;
        private System.Windows.Forms.Label txtDanhSach;
    }
}


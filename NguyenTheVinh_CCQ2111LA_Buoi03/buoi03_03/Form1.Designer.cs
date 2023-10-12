namespace buoi03_03
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mTxt_Gia = new System.Windows.Forms.MaskedTextBox();
            this.mTxt_MS = new System.Windows.Forms.MaskedTextBox();
            this.txtB_TenSach = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gBox_List = new System.Windows.Forms.GroupBox();
            this.txtDanhSach = new System.Windows.Forms.Label();
            this.gBox_func = new System.Windows.Forms.GroupBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_RemoveList = new System.Windows.Forms.Button();
            this.btn_AddList = new System.Windows.Forms.Button();
            this.numUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.gBox_List.SuspendLayout();
            this.gBox_func.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số lượng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numUpDown);
            this.groupBox1.Controls.Add(this.mTxt_Gia);
            this.groupBox1.Controls.Add(this.mTxt_MS);
            this.groupBox1.Controls.Add(this.txtB_TenSach);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 323);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sách";
            // 
            // mTxt_Gia
            // 
            this.mTxt_Gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTxt_Gia.Location = new System.Drawing.Point(87, 148);
            this.mTxt_Gia.Mask = "00000000 (vnđ)";
            this.mTxt_Gia.Name = "mTxt_Gia";
            this.mTxt_Gia.Size = new System.Drawing.Size(156, 20);
            this.mTxt_Gia.TabIndex = 2;
            this.mTxt_Gia.ValidatingType = typeof(int);
            // 
            // mTxt_MS
            // 
            this.mTxt_MS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTxt_MS.Location = new System.Drawing.Point(87, 34);
            this.mTxt_MS.Mask = "000000";
            this.mTxt_MS.Name = "mTxt_MS";
            this.mTxt_MS.Size = new System.Drawing.Size(156, 20);
            this.mTxt_MS.TabIndex = 2;
            this.mTxt_MS.ValidatingType = typeof(int);
            // 
            // txtB_TenSach
            // 
            this.txtB_TenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB_TenSach.Location = new System.Drawing.Point(87, 94);
            this.txtB_TenSach.Name = "txtB_TenSach";
            this.txtB_TenSach.Size = new System.Drawing.Size(156, 20);
            this.txtB_TenSach.TabIndex = 1;
            this.txtB_TenSach.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gBox_List
            // 
            this.gBox_List.Controls.Add(this.txtDanhSach);
            this.gBox_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBox_List.Location = new System.Drawing.Point(319, 170);
            this.gBox_List.Name = "gBox_List";
            this.gBox_List.Size = new System.Drawing.Size(454, 222);
            this.gBox_List.TabIndex = 2;
            this.gBox_List.TabStop = false;
            this.gBox_List.Text = "Danh sách";
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
            // 
            // gBox_func
            // 
            this.gBox_func.Controls.Add(this.btn_Thoat);
            this.gBox_func.Controls.Add(this.btn_RemoveList);
            this.gBox_func.Controls.Add(this.btn_AddList);
            this.gBox_func.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBox_func.Location = new System.Drawing.Point(319, 69);
            this.gBox_func.Name = "gBox_func";
            this.gBox_func.Size = new System.Drawing.Size(454, 76);
            this.gBox_func.TabIndex = 3;
            this.gBox_func.TabStop = false;
            this.gBox_func.Text = "Chức năng";
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
            // numUpDown
            // 
            this.numUpDown.Location = new System.Drawing.Point(87, 212);
            this.numUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpDown.Name = "numUpDown";
            this.numUpDown.Size = new System.Drawing.Size(156, 20);
            this.numUpDown.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gBox_List);
            this.Controls.Add(this.gBox_func);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gBox_List.ResumeLayout(false);
            this.gBox_List.PerformLayout();
            this.gBox_func.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mTxt_Gia;
        private System.Windows.Forms.MaskedTextBox mTxt_MS;
        private System.Windows.Forms.TextBox txtB_TenSach;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gBox_List;
        private System.Windows.Forms.Label txtDanhSach;
        private System.Windows.Forms.GroupBox gBox_func;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_RemoveList;
        private System.Windows.Forms.Button btn_AddList;
        private System.Windows.Forms.NumericUpDown numUpDown;
    }
}


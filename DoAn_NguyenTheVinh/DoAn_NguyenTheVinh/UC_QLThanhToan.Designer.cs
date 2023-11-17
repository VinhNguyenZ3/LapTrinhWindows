namespace DoAn_NguyenTheVinh
{
    partial class UC_QLThanhToan
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.PaymentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReservationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefundAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefundStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTongSV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtReservationID = new System.Windows.Forms.ComboBox();
            this.mtbRefundAmount = new System.Windows.Forms.MaskedTextBox();
            this.mtbAmount = new System.Windows.Forms.MaskedTextBox();
            this.mtbPaymentDate = new System.Windows.Forms.MaskedTextBox();
            this.cbPaymentStatus = new System.Windows.Forms.ComboBox();
            this.cbRefundStatus = new System.Windows.Forms.ComboBox();
            this.cbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.txtPaymentID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.dgvDanhSach);
            this.groupBox3.Controls.Add(this.txtTongSV);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(3, 376);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1357, 482);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PaymentID,
            this.ReservationID,
            this.PaymentDate,
            this.PaymentMethod,
            this.PaymentStatus,
            this.Amount,
            this.RefundAmount,
            this.RefundStatus});
            this.dgvDanhSach.Location = new System.Drawing.Point(7, 13);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.Size = new System.Drawing.Size(1340, 375);
            this.dgvDanhSach.TabIndex = 1;
            this.dgvDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellContentClick);
            // 
            // PaymentID
            // 
            this.PaymentID.DataPropertyName = "PaymentID";
            this.PaymentID.HeaderText = "ID thanh toán";
            this.PaymentID.Name = "PaymentID";
            // 
            // ReservationID
            // 
            this.ReservationID.DataPropertyName = "ReservationID";
            this.ReservationID.HeaderText = "ID đặt phòng";
            this.ReservationID.Name = "ReservationID";
            // 
            // PaymentDate
            // 
            this.PaymentDate.DataPropertyName = "PaymentDate";
            this.PaymentDate.HeaderText = "Ngày thanh toán";
            this.PaymentDate.Name = "PaymentDate";
            this.PaymentDate.Width = 130;
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.DataPropertyName = "PaymentMethod";
            this.PaymentMethod.HeaderText = "Phương thức thanh toán";
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.Width = 150;
            // 
            // PaymentStatus
            // 
            this.PaymentStatus.DataPropertyName = "PaymentStatus";
            this.PaymentStatus.HeaderText = "Trạng thái thanh toán";
            this.PaymentStatus.Name = "PaymentStatus";
            this.PaymentStatus.Width = 160;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Tổng tiền";
            this.Amount.Name = "Amount";
            this.Amount.Width = 140;
            // 
            // RefundAmount
            // 
            this.RefundAmount.DataPropertyName = "RefundAmount";
            this.RefundAmount.HeaderText = "Số tiền hoàn lại";
            this.RefundAmount.Name = "RefundAmount";
            this.RefundAmount.Width = 140;
            // 
            // RefundStatus
            // 
            this.RefundStatus.DataPropertyName = "RefundStatus";
            this.RefundStatus.HeaderText = "Trạng thái hoàn tiền";
            this.RefundStatus.Name = "RefundStatus";
            this.RefundStatus.Width = 150;
            // 
            // txtTongSV
            // 
            this.txtTongSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongSV.Location = new System.Drawing.Point(1222, 394);
            this.txtTongSV.Name = "txtTongSV";
            this.txtTongSV.ReadOnly = true;
            this.txtTongSV.Size = new System.Drawing.Size(125, 26);
            this.txtTongSV.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1026, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tổng số phiếu thanh toán";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Controls.Add(this.btnLoc);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(1366, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 776);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(8, 445);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(204, 64);
            this.btnLamMoi.TabIndex = 7;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.Location = new System.Drawing.Point(6, 362);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(204, 64);
            this.btnLoc.TabIndex = 1;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(6, 278);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(204, 64);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(6, 193);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(204, 64);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(6, 110);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(204, 64);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(6, 33);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(204, 64);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.txtReservationID);
            this.groupBox1.Controls.Add(this.mtbRefundAmount);
            this.groupBox1.Controls.Add(this.mtbAmount);
            this.groupBox1.Controls.Add(this.mtbPaymentDate);
            this.groupBox1.Controls.Add(this.cbPaymentStatus);
            this.groupBox1.Controls.Add(this.cbRefundStatus);
            this.groupBox1.Controls.Add(this.cbPaymentMethod);
            this.groupBox1.Controls.Add(this.txtPaymentID);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1357, 288);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtReservationID
            // 
            this.txtReservationID.FormattingEnabled = true;
            this.txtReservationID.Location = new System.Drawing.Point(246, 126);
            this.txtReservationID.Name = "txtReservationID";
            this.txtReservationID.Size = new System.Drawing.Size(190, 21);
            this.txtReservationID.TabIndex = 7;
            // 
            // mtbRefundAmount
            // 
            this.mtbRefundAmount.Location = new System.Drawing.Point(1101, 54);
            this.mtbRefundAmount.Name = "mtbRefundAmount";
            this.mtbRefundAmount.Size = new System.Drawing.Size(190, 20);
            this.mtbRefundAmount.TabIndex = 6;
            // 
            // mtbAmount
            // 
            this.mtbAmount.Location = new System.Drawing.Point(685, 199);
            this.mtbAmount.Name = "mtbAmount";
            this.mtbAmount.Size = new System.Drawing.Size(190, 20);
            this.mtbAmount.TabIndex = 6;
            // 
            // mtbPaymentDate
            // 
            this.mtbPaymentDate.Location = new System.Drawing.Point(246, 199);
            this.mtbPaymentDate.Name = "mtbPaymentDate";
            this.mtbPaymentDate.Size = new System.Drawing.Size(190, 20);
            this.mtbPaymentDate.TabIndex = 5;
            // 
            // cbPaymentStatus
            // 
            this.cbPaymentStatus.FormattingEnabled = true;
            this.cbPaymentStatus.Items.AddRange(new object[] {
            "Đã thanh toán",
            "Chưa thanh toán"});
            this.cbPaymentStatus.Location = new System.Drawing.Point(685, 128);
            this.cbPaymentStatus.Name = "cbPaymentStatus";
            this.cbPaymentStatus.Size = new System.Drawing.Size(190, 21);
            this.cbPaymentStatus.TabIndex = 4;
            // 
            // cbRefundStatus
            // 
            this.cbRefundStatus.FormattingEnabled = true;
            this.cbRefundStatus.Items.AddRange(new object[] {
            "Not Refunded",
            "Refunded"});
            this.cbRefundStatus.Location = new System.Drawing.Point(1101, 128);
            this.cbRefundStatus.Name = "cbRefundStatus";
            this.cbRefundStatus.Size = new System.Drawing.Size(190, 21);
            this.cbRefundStatus.TabIndex = 4;
            // 
            // cbPaymentMethod
            // 
            this.cbPaymentMethod.FormattingEnabled = true;
            this.cbPaymentMethod.Items.AddRange(new object[] {
            "Credit Card",
            "PayPal"});
            this.cbPaymentMethod.Location = new System.Drawing.Point(685, 57);
            this.cbPaymentMethod.Name = "cbPaymentMethod";
            this.cbPaymentMethod.Size = new System.Drawing.Size(190, 21);
            this.cbPaymentMethod.TabIndex = 4;
            // 
            // txtPaymentID
            // 
            this.txtPaymentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentID.Location = new System.Drawing.Point(246, 54);
            this.txtPaymentID.Name = "txtPaymentID";
            this.txtPaymentID.Size = new System.Drawing.Size(190, 26);
            this.txtPaymentID.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(934, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Trạng thái hoàn tiền";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(498, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Phương thức thanh toán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(498, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng tiền";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(934, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số tiền hoàn lại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID đặt phòng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày thanh toán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(498, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Trạng thái thanh toán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID thanh toán";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(709, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "Quản Lý Thanh Toán";
            // 
            // UC_QLThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "UC_QLThanhToan";
            this.Size = new System.Drawing.Size(1600, 900);
            this.Load += new System.EventHandler(this.UC_QLThanhToan_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.TextBox txtTongSV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPaymentID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbPaymentMethod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbPaymentStatus;
        private System.Windows.Forms.ComboBox cbRefundStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefundAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefundStatus;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.MaskedTextBox mtbPaymentDate;
        private System.Windows.Forms.MaskedTextBox mtbAmount;
        private System.Windows.Forms.MaskedTextBox mtbRefundAmount;
        private System.Windows.Forms.ComboBox txtReservationID;
    }
}

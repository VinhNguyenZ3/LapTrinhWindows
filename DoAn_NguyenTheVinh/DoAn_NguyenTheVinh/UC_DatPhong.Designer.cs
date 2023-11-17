namespace DoAn_NguyenTheVinh
{
    partial class UC_DatPhong
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
            this.ReservationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialRequests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfAdults = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfChildren = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckInDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckOutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckInStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckOutStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTongSV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRoomID = new System.Windows.Forms.ComboBox();
            this.cbPaymentStatus = new System.Windows.Forms.ComboBox();
            this.cbCheckInStatus = new System.Windows.Forms.ComboBox();
            this.cbCheckOutStatus = new System.Windows.Forms.ComboBox();
            this.mtbCheckOutDate = new System.Windows.Forms.MaskedTextBox();
            this.mtbTotalAmount = new System.Windows.Forms.MaskedTextBox();
            this.mtbCheckInDate = new System.Windows.Forms.MaskedTextBox();
            this.txtNumberOfChildren = new System.Windows.Forms.TextBox();
            this.txtNumberOfAdults = new System.Windows.Forms.TextBox();
            this.txtSpecialRequests = new System.Windows.Forms.TextBox();
            this.txtReservationID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.ComboBox();
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
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReservationID,
            this.CustomerID,
            this.RoomID,
            this.PaymentStatus,
            this.SpecialRequests,
            this.NumberOfAdults,
            this.NumberOfChildren,
            this.CheckInDate,
            this.CheckOutDate,
            this.TotalAmount,
            this.CheckInStatus,
            this.CheckOutStatus});
            this.dgvDanhSach.Location = new System.Drawing.Point(7, 13);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.Size = new System.Drawing.Size(1340, 375);
            this.dgvDanhSach.TabIndex = 1;
            this.dgvDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellContentClick);
            // 
            // ReservationID
            // 
            this.ReservationID.DataPropertyName = "ReservationID";
            this.ReservationID.HeaderText = "ID";
            this.ReservationID.Name = "ReservationID";
            this.ReservationID.Width = 50;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "ID khách hàng";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Width = 50;
            // 
            // RoomID
            // 
            this.RoomID.DataPropertyName = "RoomID";
            this.RoomID.HeaderText = "ID phòng";
            this.RoomID.Name = "RoomID";
            this.RoomID.Width = 50;
            // 
            // PaymentStatus
            // 
            this.PaymentStatus.DataPropertyName = "PaymentStatus";
            this.PaymentStatus.HeaderText = "Trạng thái thanh toán";
            this.PaymentStatus.Name = "PaymentStatus";
            this.PaymentStatus.Width = 140;
            // 
            // SpecialRequests
            // 
            this.SpecialRequests.DataPropertyName = "SpecialRequests";
            this.SpecialRequests.HeaderText = "Yêu cầu đặc biệt";
            this.SpecialRequests.Name = "SpecialRequests";
            this.SpecialRequests.Width = 170;
            // 
            // NumberOfAdults
            // 
            this.NumberOfAdults.DataPropertyName = "NumberOfAdults";
            this.NumberOfAdults.HeaderText = "Số lượng người lớn";
            this.NumberOfAdults.Name = "NumberOfAdults";
            this.NumberOfAdults.Width = 120;
            // 
            // NumberOfChildren
            // 
            this.NumberOfChildren.DataPropertyName = "NumberOfChildren";
            this.NumberOfChildren.HeaderText = "Số lượng trẻ em";
            this.NumberOfChildren.Name = "NumberOfChildren";
            this.NumberOfChildren.Width = 110;
            // 
            // CheckInDate
            // 
            this.CheckInDate.DataPropertyName = "CheckInDate";
            this.CheckInDate.HeaderText = "Ngày CheckIn";
            this.CheckInDate.Name = "CheckInDate";
            // 
            // CheckOutDate
            // 
            this.CheckOutDate.DataPropertyName = "CheckOutDate";
            this.CheckOutDate.HeaderText = "Ngày CheckOut";
            this.CheckOutDate.Name = "CheckOutDate";
            this.CheckOutDate.Width = 110;
            // 
            // TotalAmount
            // 
            this.TotalAmount.DataPropertyName = "TotalAmount";
            this.TotalAmount.HeaderText = "Tổng tiền";
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Width = 120;
            // 
            // CheckInStatus
            // 
            this.CheckInStatus.DataPropertyName = "CheckInStatus";
            this.CheckInStatus.HeaderText = "Trạng thái CheckIn";
            this.CheckInStatus.Name = "CheckInStatus";
            this.CheckInStatus.Width = 140;
            // 
            // CheckOutStatus
            // 
            this.CheckOutStatus.DataPropertyName = "CheckOutStatus";
            this.CheckOutStatus.HeaderText = "Trạng thái CheckOut";
            this.CheckOutStatus.Name = "CheckOutStatus";
            this.CheckOutStatus.Width = 140;
            // 
            // txtTongSV
            // 
            this.txtTongSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongSV.Location = new System.Drawing.Point(1222, 394);
            this.txtTongSV.Name = "txtTongSV";
            this.txtTongSV.ReadOnly = true;
            this.txtTongSV.Size = new System.Drawing.Size(125, 26);
            this.txtTongSV.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1052, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tổng số phòng đã đặt";
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
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(8, 441);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(204, 64);
            this.btnLamMoi.TabIndex = 8;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.Location = new System.Drawing.Point(6, 360);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(204, 64);
            this.btnLoc.TabIndex = 0;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(6, 276);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(204, 64);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(6, 191);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(204, 64);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(6, 108);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(204, 64);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(6, 31);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(204, 64);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(709, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Đặt Phòng";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.txtCustomerID);
            this.groupBox1.Controls.Add(this.txtRoomID);
            this.groupBox1.Controls.Add(this.cbPaymentStatus);
            this.groupBox1.Controls.Add(this.cbCheckInStatus);
            this.groupBox1.Controls.Add(this.cbCheckOutStatus);
            this.groupBox1.Controls.Add(this.mtbCheckOutDate);
            this.groupBox1.Controls.Add(this.mtbTotalAmount);
            this.groupBox1.Controls.Add(this.mtbCheckInDate);
            this.groupBox1.Controls.Add(this.txtNumberOfChildren);
            this.groupBox1.Controls.Add(this.txtNumberOfAdults);
            this.groupBox1.Controls.Add(this.txtSpecialRequests);
            this.groupBox1.Controls.Add(this.txtReservationID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(3, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1357, 288);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtRoomID
            // 
            this.txtRoomID.FormattingEnabled = true;
            this.txtRoomID.Location = new System.Drawing.Point(177, 136);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(190, 21);
            this.txtRoomID.TabIndex = 7;
            // 
            // cbPaymentStatus
            // 
            this.cbPaymentStatus.FormattingEnabled = true;
            this.cbPaymentStatus.Items.AddRange(new object[] {
            "Đã thanh toán",
            "Chưa thanh toán"});
            this.cbPaymentStatus.Location = new System.Drawing.Point(609, 233);
            this.cbPaymentStatus.Name = "cbPaymentStatus";
            this.cbPaymentStatus.Size = new System.Drawing.Size(190, 21);
            this.cbPaymentStatus.TabIndex = 6;
            // 
            // cbCheckInStatus
            // 
            this.cbCheckInStatus.FormattingEnabled = true;
            this.cbCheckInStatus.Items.AddRange(new object[] {
            "Đã nhận phòng",
            "Chưa nhận phòng"});
            this.cbCheckInStatus.Location = new System.Drawing.Point(609, 137);
            this.cbCheckInStatus.Name = "cbCheckInStatus";
            this.cbCheckInStatus.Size = new System.Drawing.Size(190, 21);
            this.cbCheckInStatus.TabIndex = 6;
            // 
            // cbCheckOutStatus
            // 
            this.cbCheckOutStatus.FormattingEnabled = true;
            this.cbCheckOutStatus.Items.AddRange(new object[] {
            "Đã trả phòng",
            "Chưa trả phòng"});
            this.cbCheckOutStatus.Location = new System.Drawing.Point(609, 186);
            this.cbCheckOutStatus.Name = "cbCheckOutStatus";
            this.cbCheckOutStatus.Size = new System.Drawing.Size(190, 21);
            this.cbCheckOutStatus.TabIndex = 6;
            // 
            // mtbCheckOutDate
            // 
            this.mtbCheckOutDate.Location = new System.Drawing.Point(609, 86);
            this.mtbCheckOutDate.Name = "mtbCheckOutDate";
            this.mtbCheckOutDate.Size = new System.Drawing.Size(191, 20);
            this.mtbCheckOutDate.TabIndex = 4;
            // 
            // mtbTotalAmount
            // 
            this.mtbTotalAmount.Location = new System.Drawing.Point(1026, 138);
            this.mtbTotalAmount.Name = "mtbTotalAmount";
            this.mtbTotalAmount.Size = new System.Drawing.Size(191, 20);
            this.mtbTotalAmount.TabIndex = 4;
            // 
            // mtbCheckInDate
            // 
            this.mtbCheckInDate.Location = new System.Drawing.Point(609, 33);
            this.mtbCheckInDate.Name = "mtbCheckInDate";
            this.mtbCheckInDate.Size = new System.Drawing.Size(191, 20);
            this.mtbCheckInDate.TabIndex = 4;
            // 
            // txtNumberOfChildren
            // 
            this.txtNumberOfChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfChildren.Location = new System.Drawing.Point(177, 230);
            this.txtNumberOfChildren.Name = "txtNumberOfChildren";
            this.txtNumberOfChildren.Size = new System.Drawing.Size(190, 26);
            this.txtNumberOfChildren.TabIndex = 3;
            // 
            // txtNumberOfAdults
            // 
            this.txtNumberOfAdults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfAdults.Location = new System.Drawing.Point(177, 183);
            this.txtNumberOfAdults.Name = "txtNumberOfAdults";
            this.txtNumberOfAdults.Size = new System.Drawing.Size(190, 26);
            this.txtNumberOfAdults.TabIndex = 3;
            // 
            // txtSpecialRequests
            // 
            this.txtSpecialRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecialRequests.Location = new System.Drawing.Point(1026, 31);
            this.txtSpecialRequests.Multiline = true;
            this.txtSpecialRequests.Name = "txtSpecialRequests";
            this.txtSpecialRequests.Size = new System.Drawing.Size(201, 76);
            this.txtSpecialRequests.TabIndex = 3;
            // 
            // txtReservationID
            // 
            this.txtReservationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReservationID.Location = new System.Drawing.Point(177, 30);
            this.txtReservationID.Name = "txtReservationID";
            this.txtReservationID.Size = new System.Drawing.Size(190, 26);
            this.txtReservationID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(865, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Yêu cầu đặc biệt";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(865, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tổng tiền";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(442, 186);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(155, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Trạng thái CheckOut";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(442, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Ngày CheckOut";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(442, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Trạng thái CheckIn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(442, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ngày CheckIn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(442, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Trạng thái thanh toán";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Số lượng trẻ em";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID phòng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số lượng người lớn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID khách hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "ID";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.FormattingEnabled = true;
            this.txtCustomerID.Location = new System.Drawing.Point(177, 85);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(190, 21);
            this.txtCustomerID.TabIndex = 7;
            // 
            // UC_DatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "UC_DatPhong";
            this.Size = new System.Drawing.Size(1600, 900);
            this.Load += new System.EventHandler(this.uc_DatPhong_Load);
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtbCheckInDate;
        private System.Windows.Forms.TextBox txtNumberOfChildren;
        private System.Windows.Forms.TextBox txtReservationID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSpecialRequests;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbPaymentStatus;
        private System.Windows.Forms.ComboBox cbCheckInStatus;
        private System.Windows.Forms.ComboBox cbCheckOutStatus;
        private System.Windows.Forms.MaskedTextBox mtbCheckOutDate;
        private System.Windows.Forms.TextBox txtNumberOfAdults;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialRequests;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfAdults;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfChildren;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckInDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckOutDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckInStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckOutStatus;
        private System.Windows.Forms.TextBox txtTongSV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.MaskedTextBox mtbTotalAmount;
        private System.Windows.Forms.ComboBox txtRoomID;
        private System.Windows.Forms.ComboBox txtCustomerID;
    }
}

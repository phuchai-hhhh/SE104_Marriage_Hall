﻿using QL_TiecCuoi.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_TiecCuoi
{
    public partial class LapHoaDon : Form
    {
        private Button button2;
        private Button buttonXem;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private GroupBox groupBox1;
        private Panel panel2;
        private Label label1;
        private Label label3;
        private DateTimePicker dateTimePickerLapHD;
        private DataGridView dataGridViewDichVu;
        private DataGridView dataGridViewThucDon;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private GroupBox groupBox5;
        private Panel panel4;
        private RadioButton radioButtonKhong;
        private RadioButton radioButtonCo;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label labelTongTien;
        private Label label20;
        private Label label19;
        private Label labelDichVu;
        private Label label17;
        private Label label12;
        private TextBox textBoxConLai;
        private TextBox textBoxTienCoc;
        private TextBox textBoxTongHoaDon;
        private TextBox textBoxTienPhat;
        private TextBox textBoxTienSanh;
        private TextBox textBoxTienDichVu;
        private TextBox textBoxTienThucDon;
        private TextBox textBoxEmail;
        private TextBox textBoxDienThoai;
        private TextBox textBoxDicChiKH;
        private TextBox textBoxTenKH;
        private TextBox textBoxNguoiLap;
        private Button button1;
        private TextBox textBoxNgayToChuc;
        private TextBox textBoxNgayLap;
        private Label label4;
        private TextBox textBoxPhat;
        private Panel panel1;
        private Label label13;
        private TextBox textBoxPhieuDT;
        private DataRow dataHoaDonCurrent;

        public LapHoaDon()
        {
            InitializeComponent();

        }






        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LapHoaDon));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxPhat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxConLai = new System.Windows.Forms.TextBox();
            this.textBoxTienCoc = new System.Windows.Forms.TextBox();
            this.textBoxTongHoaDon = new System.Windows.Forms.TextBox();
            this.textBoxTienPhat = new System.Windows.Forms.TextBox();
            this.textBoxTienSanh = new System.Windows.Forms.TextBox();
            this.textBoxTienDichVu = new System.Windows.Forms.TextBox();
            this.textBoxTienThucDon = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.radioButtonKhong = new System.Windows.Forms.RadioButton();
            this.radioButtonCo = new System.Windows.Forms.RadioButton();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.labelTongTien = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.labelDichVu = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonXem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDichVu = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewThucDon = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxNgayToChuc = new System.Windows.Forms.TextBox();
            this.textBoxNgayLap = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxDienThoai = new System.Windows.Forms.TextBox();
            this.textBoxDicChiKH = new System.Windows.Forms.TextBox();
            this.textBoxTenKH = new System.Windows.Forms.TextBox();
            this.textBoxNguoiLap = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPhieuDT = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePickerLapHD = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDichVu)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThucDon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.buttonXem);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.textBoxPhieuDT);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 586);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(564, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 28;
            this.button1.Text = "Xem ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label13.Location = new System.Drawing.Point(231, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 16);
            this.label13.TabIndex = 19;
            this.label13.Text = "Mã hợp đồng";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.panel4);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox5.Location = new System.Drawing.Point(497, 282);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(463, 251);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tính Tiền";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBoxPhat);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.textBoxConLai);
            this.panel4.Controls.Add(this.textBoxTienCoc);
            this.panel4.Controls.Add(this.textBoxTongHoaDon);
            this.panel4.Controls.Add(this.textBoxTienPhat);
            this.panel4.Controls.Add(this.textBoxTienSanh);
            this.panel4.Controls.Add(this.textBoxTienDichVu);
            this.panel4.Controls.Add(this.textBoxTienThucDon);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.radioButtonKhong);
            this.panel4.Controls.Add(this.radioButtonCo);
            this.panel4.Controls.Add(this.label25);
            this.panel4.Controls.Add(this.label24);
            this.panel4.Controls.Add(this.label23);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.labelTongTien);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.labelDichVu);
            this.panel4.Controls.Add(this.label17);
            this.panel4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.panel4.Location = new System.Drawing.Point(15, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(441, 232);
            this.panel4.TabIndex = 5;
            // 
            // textBoxPhat
            // 
            this.textBoxPhat.Location = new System.Drawing.Point(290, 34);
            this.textBoxPhat.Name = "textBoxPhat";
            this.textBoxPhat.Size = new System.Drawing.Size(138, 22);
            this.textBoxPhat.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(287, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tỉ số phạt";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxConLai
            // 
            this.textBoxConLai.Location = new System.Drawing.Point(130, 202);
            this.textBoxConLai.Name = "textBoxConLai";
            this.textBoxConLai.Size = new System.Drawing.Size(138, 22);
            this.textBoxConLai.TabIndex = 34;
            // 
            // textBoxTienCoc
            // 
            this.textBoxTienCoc.Location = new System.Drawing.Point(130, 165);
            this.textBoxTienCoc.Name = "textBoxTienCoc";
            this.textBoxTienCoc.Size = new System.Drawing.Size(138, 22);
            this.textBoxTienCoc.TabIndex = 33;
            // 
            // textBoxTongHoaDon
            // 
            this.textBoxTongHoaDon.Location = new System.Drawing.Point(130, 135);
            this.textBoxTongHoaDon.Name = "textBoxTongHoaDon";
            this.textBoxTongHoaDon.Size = new System.Drawing.Size(138, 22);
            this.textBoxTongHoaDon.TabIndex = 32;
            // 
            // textBoxTienPhat
            // 
            this.textBoxTienPhat.Location = new System.Drawing.Point(130, 94);
            this.textBoxTienPhat.Name = "textBoxTienPhat";
            this.textBoxTienPhat.Size = new System.Drawing.Size(138, 22);
            this.textBoxTienPhat.TabIndex = 31;
            // 
            // textBoxTienSanh
            // 
            this.textBoxTienSanh.Location = new System.Drawing.Point(130, 67);
            this.textBoxTienSanh.Name = "textBoxTienSanh";
            this.textBoxTienSanh.Size = new System.Drawing.Size(138, 22);
            this.textBoxTienSanh.TabIndex = 30;
            // 
            // textBoxTienDichVu
            // 
            this.textBoxTienDichVu.Location = new System.Drawing.Point(130, 37);
            this.textBoxTienDichVu.Name = "textBoxTienDichVu";
            this.textBoxTienDichVu.Size = new System.Drawing.Size(138, 22);
            this.textBoxTienDichVu.TabIndex = 29;
            // 
            // textBoxTienThucDon
            // 
            this.textBoxTienThucDon.Location = new System.Drawing.Point(130, 7);
            this.textBoxTienThucDon.Name = "textBoxTienThucDon";
            this.textBoxTienThucDon.Size = new System.Drawing.Size(138, 22);
            this.textBoxTienThucDon.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = "Tiền sảnh";
            // 
            // radioButtonKhong
            // 
            this.radioButtonKhong.AutoSize = true;
            this.radioButtonKhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKhong.Location = new System.Drawing.Point(290, 97);
            this.radioButtonKhong.Name = "radioButtonKhong";
            this.radioButtonKhong.Size = new System.Drawing.Size(64, 20);
            this.radioButtonKhong.TabIndex = 20;
            this.radioButtonKhong.TabStop = true;
            this.radioButtonKhong.Text = "Không";
            this.radioButtonKhong.UseVisualStyleBackColor = true;
            this.radioButtonKhong.CheckedChanged += new System.EventHandler(this.radioButtonKhong_CheckedChanged);
            // 
            // radioButtonCo
            // 
            this.radioButtonCo.AutoSize = true;
            this.radioButtonCo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCo.Location = new System.Drawing.Point(365, 97);
            this.radioButtonCo.Name = "radioButtonCo";
            this.radioButtonCo.Size = new System.Drawing.Size(46, 20);
            this.radioButtonCo.TabIndex = 19;
            this.radioButtonCo.TabStop = true;
            this.radioButtonCo.Text = "Có ";
            this.radioButtonCo.UseVisualStyleBackColor = true;
            this.radioButtonCo.CheckedChanged += new System.EventHandler(this.radioButtonCo_CheckedChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(287, 73);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(140, 16);
            this.label25.TabIndex = 18;
            this.label25.Text = "Áp dụng quy định phạt";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(3, 205);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(52, 16);
            this.label24.TabIndex = 11;
            this.label24.Text = "Còn lại:";
            // 
            // label23
            // 
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label23.Location = new System.Drawing.Point(102, 195);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(200, 2);
            this.label23.TabIndex = 10;
            this.label23.Text = "label23";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(3, 168);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(63, 16);
            this.label22.TabIndex = 9;
            this.label22.Text = "Tiền cọc:";
            // 
            // labelTongTien
            // 
            this.labelTongTien.AutoSize = true;
            this.labelTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongTien.Location = new System.Drawing.Point(5, 141);
            this.labelTongTien.Name = "labelTongTien";
            this.labelTongTien.Size = new System.Drawing.Size(119, 16);
            this.labelTongTien.TabIndex = 8;
            this.labelTongTien.Text = "Tổng tiền hóa đơn:";
            // 
            // label20
            // 
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(80, 122);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(200, 2);
            this.label20.TabIndex = 7;
            this.label20.Text = "label20";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(3, 97);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 16);
            this.label19.TabIndex = 6;
            this.label19.Text = "Tiền phạt:";
            // 
            // labelDichVu
            // 
            this.labelDichVu.AutoSize = true;
            this.labelDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDichVu.Location = new System.Drawing.Point(3, 40);
            this.labelDichVu.Name = "labelDichVu";
            this.labelDichVu.Size = new System.Drawing.Size(83, 16);
            this.labelDichVu.TabIndex = 5;
            this.labelDichVu.Text = "Tiền dịch vụ:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(3, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 16);
            this.label17.TabIndex = 4;
            this.label17.Text = "Tiền thực đơn:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(854, 539);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 26);
            this.button2.TabIndex = 8;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonXem
            // 
            this.buttonXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXem.Location = new System.Drawing.Point(732, 539);
            this.buttonXem.Name = "buttonXem";
            this.buttonXem.Size = new System.Drawing.Size(80, 26);
            this.buttonXem.TabIndex = 7;
            this.buttonXem.Text = "Lưu";
            this.buttonXem.UseVisualStyleBackColor = true;
            this.buttonXem.Click += new System.EventHandler(this.buttonXem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(11, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(477, 283);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sử dụng chi phí";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewDichVu);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox4.Location = new System.Drawing.Point(6, 149);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(465, 128);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dịch vụ";
            // 
            // dataGridViewDichVu
            // 
            this.dataGridViewDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDichVu.Location = new System.Drawing.Point(3, 21);
            this.dataGridViewDichVu.Name = "dataGridViewDichVu";
            this.dataGridViewDichVu.Size = new System.Drawing.Size(453, 98);
            this.dataGridViewDichVu.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewThucDon);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(465, 124);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thực đơn";
            // 
            // dataGridViewThucDon
            // 
            this.dataGridViewThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThucDon.Location = new System.Drawing.Point(6, 16);
            this.dataGridViewThucDon.Name = "dataGridViewThucDon";
            this.dataGridViewThucDon.Size = new System.Drawing.Size(453, 102);
            this.dataGridViewThucDon.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxNgayToChuc);
            this.groupBox1.Controls.Add(this.textBoxNgayLap);
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.textBoxDienThoai);
            this.groupBox1.Controls.Add(this.textBoxDicChiKH);
            this.groupBox1.Controls.Add(this.textBoxTenKH);
            this.groupBox1.Controls.Add(this.textBoxNguoiLap);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(17, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(946, 134);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hợp đồng đặt tiệc";
            // 
            // textBoxNgayToChuc
            // 
            this.textBoxNgayToChuc.Location = new System.Drawing.Point(150, 98);
            this.textBoxNgayToChuc.Name = "textBoxNgayToChuc";
            this.textBoxNgayToChuc.Size = new System.Drawing.Size(163, 22);
            this.textBoxNgayToChuc.TabIndex = 20;
            // 
            // textBoxNgayLap
            // 
            this.textBoxNgayLap.Location = new System.Drawing.Point(150, 61);
            this.textBoxNgayLap.Name = "textBoxNgayLap";
            this.textBoxNgayLap.Size = new System.Drawing.Size(163, 22);
            this.textBoxNgayLap.TabIndex = 19;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(785, 61);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(149, 22);
            this.textBoxEmail.TabIndex = 18;
            // 
            // textBoxDienThoai
            // 
            this.textBoxDienThoai.Location = new System.Drawing.Point(785, 25);
            this.textBoxDienThoai.Name = "textBoxDienThoai";
            this.textBoxDienThoai.Size = new System.Drawing.Size(149, 22);
            this.textBoxDienThoai.TabIndex = 17;
            // 
            // textBoxDicChiKH
            // 
            this.textBoxDicChiKH.Location = new System.Drawing.Point(461, 61);
            this.textBoxDicChiKH.Name = "textBoxDicChiKH";
            this.textBoxDicChiKH.Size = new System.Drawing.Size(154, 22);
            this.textBoxDicChiKH.TabIndex = 16;
            // 
            // textBoxTenKH
            // 
            this.textBoxTenKH.Location = new System.Drawing.Point(458, 28);
            this.textBoxTenKH.Name = "textBoxTenKH";
            this.textBoxTenKH.Size = new System.Drawing.Size(157, 22);
            this.textBoxTenKH.TabIndex = 15;
            // 
            // textBoxNguoiLap
            // 
            this.textBoxNguoiLap.Location = new System.Drawing.Point(150, 25);
            this.textBoxNguoiLap.Name = "textBoxNguoiLap";
            this.textBoxNguoiLap.Size = new System.Drawing.Size(163, 22);
            this.textBoxNguoiLap.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label11.Location = new System.Drawing.Point(621, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 16);
            this.label11.TabIndex = 7;
            this.label11.Text = "Email khách hàng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label10.Location = new System.Drawing.Point(621, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Số điện thoại khách hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label9.Location = new System.Drawing.Point(335, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Địa chỉ khách hàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label8.Location = new System.Drawing.Point(335, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tên khách hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label7.Location = new System.Drawing.Point(6, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Người lập hợp đồng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(9, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ngày tổ chức tiệc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(6, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ngày đặt tiệc";
            // 
            // textBoxPhieuDT
            // 
            this.textBoxPhieuDT.Location = new System.Drawing.Point(355, 97);
            this.textBoxPhieuDT.Name = "textBoxPhieuDT";
            this.textBoxPhieuDT.Size = new System.Drawing.Size(163, 20);
            this.textBoxPhieuDT.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTimePickerLapHD);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(11, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(936, 42);
            this.panel2.TabIndex = 1;
            // 
            // dateTimePickerLapHD
            // 
            this.dateTimePickerLapHD.Location = new System.Drawing.Point(601, 10);
            this.dateTimePickerLapHD.Name = "dateTimePickerLapHD";
            this.dateTimePickerLapHD.Size = new System.Drawing.Size(208, 20);
            this.dateTimePickerLapHD.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(480, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày lập hóa đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(350, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lập Hóa Đơn Thanh Toán";
            // 
            // LapHoaDon
            // 
            this.ClientSize = new System.Drawing.Size(963, 578);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LapHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý tiệc cưới";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDichVu)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThucDon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Menu();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string query = @"Select a.*,p.NgayToChuc,p.NgayLap,p.Email,p.TenKhachHang,p.DiaChi,p.DienThoai,p.TienCoc, NhanVienTiepTan.TenNhanVien,c.*,d.*, e.DonGiaToiThieu, e.TiSoPhat
            from ThongTinDatTiec a
            left join ThongTinKhachHang p on p.id = a.IDThongTinKhachHang
            left join NhanVienTiepTan on NhanVienTiepTan.id = a.IDNhanVien
            left join DichVu c on c.id = a.IdDichVu
            left join ThucDon d on d.id = a.IdThucDon
            left join ThongTinSanh e on e.id = a.IdLoaiSanh
             where MaDatTiec ='" + textBoxPhieuDT.Text + "'";
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            DataRow dataRow = data.Rows[0];
            this.dataHoaDonCurrent = dataRow;
            
            textBoxNguoiLap.Text = dataRow["TenNhanVien"].ToString();
            textBoxNgayLap.Text = dataRow["NgayLap"].ToString();
            textBoxNgayToChuc.Text = dataRow["NgayToChuc"].ToString();
            textBoxTenKH.Text = dataRow["TenKhachHang"].ToString();
            textBoxDicChiKH.Text = dataRow["DiaChi"].ToString();
            textBoxDienThoai.Text = dataRow["DienThoai"].ToString();
            textBoxEmail.Text = dataRow["Email"].ToString();
            string query1 = "select d.* from ThongTinDatTiec a left join ThucDon d on d.id = a.IdThucDon where MaDatTiec = '" + textBoxPhieuDT.Text + "'";
            dataGridViewThucDon.DataSource = provider.ExecuteQuery(query1);
            string query2 = "select c.* from ThongTinDatTiec a left join DichVu c on c.id = a.IdThucDon where MaDatTiec = '" + textBoxPhieuDT.Text + "'";
            dataGridViewDichVu.DataSource = provider.ExecuteQuery(query2);
            textBoxTienThucDon.Text = dataRow["GiaThucDon"].ToString();
            textBoxTienDichVu.Text = dataRow["GiaDichVu"].ToString();
            textBoxTienSanh.Text = dataRow["DonGiaToiThieu"].ToString();
            textBoxPhat.Text = dataRow["TiSoPhat"].ToString();
            textBoxTienCoc.Text = dataRow["TienCoc"].ToString();

        }


        private void radioButtonKhong_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButtonKhong.Checked)
            {
                double i = 0;
                textBoxTienPhat.Text = i.ToString();
                double a1, b1, c1, d1;
                bool isAValid = double.TryParse(textBoxTienSanh.Text.Trim(), out a1);
                bool isBValid = double.TryParse(textBoxTienPhat.Text.Trim(), out b1);
                bool isCValid = double.TryParse(textBoxTienThucDon.Text.Trim(), out c1);
                bool isDValid = double.TryParse(textBoxTienDichVu.Text.Trim(), out d1);
                if (isAValid && isBValid && isCValid && isDValid)
                    textBoxTongHoaDon.Text = (a1 + b1 + c1 + d1).ToString();

                else
                    textBoxTongHoaDon.Text = "Invalid input";
                double e1, f1;
                bool isEValid = double.TryParse(textBoxTongHoaDon.Text.Trim(), out e1);
                bool isFValid = double.TryParse(textBoxTienCoc.Text.Trim(), out f1);
                if (isEValid && isFValid )
                    textBoxConLai.Text = (e1 - f1).ToString();
                else
                    textBoxConLai.Text = "Invalid input";

            }
            else
            {
                double a, b;
                bool isAValid = double.TryParse(textBoxTienSanh.Text.Trim(), out a);
                bool isBValid = double.TryParse(textBoxPhat.Text.Trim(), out b);
                    if (isAValid && isBValid)
                    { 
                        textBoxTienPhat.Text = (a * b).ToString();    
                    }
                    else
                        textBoxTienPhat.Text = "Invalid input";
                double a2, b2, c2, d2;
                bool isA2Valid = double.TryParse(textBoxTienSanh.Text.Trim(), out a2);
                bool isB2Valid = double.TryParse(textBoxTienPhat.Text.Trim(), out b2);
                bool isC2Valid = double.TryParse(textBoxTienThucDon.Text.Trim(), out c2);
                bool isD2Valid = double.TryParse(textBoxTienDichVu.Text.Trim(), out d2);
                if (isA2Valid && isB2Valid && isC2Valid && isD2Valid)
                    textBoxTongHoaDon.Text = (a2 + b2 + c2 + d2).ToString();

                else
                    textBoxTongHoaDon.Text = "Invalid input";
                double e2, f2;
                bool isEValid = double.TryParse(textBoxTongHoaDon.Text.Trim(), out e2);
                bool isFValid = double.TryParse(textBoxTienCoc.Text.Trim(), out f2);
                if (isEValid && isFValid)
                    textBoxConLai.Text = (e2 - f2).ToString();
                else
                    textBoxConLai.Text = "Invalid input";
            }
            
        }
    

        private void radioButtonCo_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonXem_Click(object sender, EventArgs e)
        {
            try
            {

                DataProvider provider = new DataProvider();
                Console.WriteLine(this.dataHoaDonCurrent["id"].ToString());
                string query1 = "Insert into HoaDon( IdMaDatTiec, IDThongTinKhachHang ,IdLoaiSanh ,IdDichVu,IdThucDon, TienPhat,TongTienHoaDon,TienCoc ,TienConLai) Values("
                    + this.dataHoaDonCurrent["id"] + " , "
                    + this.dataHoaDonCurrent["IDThongTinKhachHang"] + " , "
                    + this.dataHoaDonCurrent["IdLoaiSanh"] + " , "
                    + this.dataHoaDonCurrent["IdDichVu"] + " , "
                    + this.dataHoaDonCurrent["IdThucDon"] + " , '"

                    + textBoxTienPhat.Text + "' , '"
                    + textBoxTongHoaDon.Text + "' , '"
                    + textBoxTienCoc.Text + "' , '"
                    + textBoxConLai.Text + "')";
                 provider.ExecuteWrite(query1);
                
          
                MessageBox.Show("Bạn đã lưu thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
           
            catch
            {
                MessageBox.Show("Lỗi, không lưu được");
            }
        }
    }

}



namespace WindowsFormsApp3
{
    partial class ChucNang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChucNang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tim = new System.Windows.Forms.TabPage();
            this.btThem = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.tbShowemp = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.btTimID = new System.Windows.Forms.Button();
            this.Dsnhanvien = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.Loai = new System.Windows.Forms.TabPage();
            this.dgvDs = new System.Windows.Forms.DataGridView();
            this.btFresher = new System.Windows.Forms.Button();
            this.btIntern = new System.Windows.Forms.Button();
            this.btExperience = new System.Windows.Forms.Button();
            this.Kinhnghiem = new System.Windows.Forms.TabPage();
            this.tbKN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btKN = new System.Windows.Forms.Button();
            this.dgvKN = new System.Windows.Forms.DataGridView();
            this.Kinang = new System.Windows.Forms.TabPage();
            this.tbKyNang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btKyNang = new System.Windows.Forms.Button();
            this.dgvKyNang = new System.Windows.Forms.DataGridView();
            this.Totnghiep = new System.Windows.Forms.TabPage();
            this.btXuatsac = new System.Windows.Forms.Button();
            this.btGioi = new System.Windows.Forms.Button();
            this.btKha = new System.Windows.Forms.Button();
            this.btTrungbinh = new System.Windows.Forms.Button();
            this.dgvLTNghiep = new System.Windows.Forms.DataGridView();
            this.Nganh = new System.Windows.Forms.TabPage();
            this.tbCN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btCN = new System.Windows.Forms.Button();
            this.dgvCN = new System.Windows.Forms.DataGridView();
            this.Luong = new System.Windows.Forms.TabPage();
            this.tbDsLuong = new System.Windows.Forms.TextBox();
            this.Kynang = new System.Windows.Forms.TabPage();
            this.Loaitotnghiep = new System.Windows.Forms.TabPage();
            this.Chuyennganh = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Tim.SuspendLayout();
            this.Dsnhanvien.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.Loai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDs)).BeginInit();
            this.Kinhnghiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKN)).BeginInit();
            this.Kinang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKyNang)).BeginInit();
            this.Totnghiep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLTNghiep)).BeginInit();
            this.Nganh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCN)).BeginInit();
            this.Luong.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tim);
            this.tabControl1.Controls.Add(this.Dsnhanvien);
            this.tabControl1.Controls.Add(this.Luong);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 442);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // Tim
            // 
            this.Tim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Tim.BackgroundImage")));
            this.Tim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tim.Controls.Add(this.btThem);
            this.Tim.Controls.Add(this.btDel);
            this.Tim.Controls.Add(this.btCapNhat);
            this.Tim.Controls.Add(this.tbShowemp);
            this.Tim.Controls.Add(this.tbID);
            this.Tim.Controls.Add(this.lbID);
            this.Tim.Controls.Add(this.btTimID);
            this.Tim.Location = new System.Drawing.Point(4, 25);
            this.Tim.Name = "Tim";
            this.Tim.Padding = new System.Windows.Forms.Padding(3);
            this.Tim.Size = new System.Drawing.Size(792, 413);
            this.Tim.TabIndex = 0;
            this.Tim.Text = "Tìm nhân viên";
            this.Tim.UseVisualStyleBackColor = true;
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(527, 232);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(229, 39);
            this.btThem.TabIndex = 7;
            this.btThem.Text = "Thêm nhân viên";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btDel
            // 
            this.btDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDel.Location = new System.Drawing.Point(527, 353);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(229, 39);
            this.btDel.TabIndex = 6;
            this.btDel.Text = "Xóa nhân viên";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btCapNhat
            // 
            this.btCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCapNhat.Location = new System.Drawing.Point(527, 291);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(229, 39);
            this.btCapNhat.TabIndex = 5;
            this.btCapNhat.Text = "Cập nhật thông tin";
            this.btCapNhat.UseVisualStyleBackColor = true;
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // tbShowemp
            // 
            this.tbShowemp.Location = new System.Drawing.Point(3, 59);
            this.tbShowemp.Multiline = true;
            this.tbShowemp.Name = "tbShowemp";
            this.tbShowemp.ReadOnly = true;
            this.tbShowemp.Size = new System.Drawing.Size(488, 348);
            this.tbShowemp.TabIndex = 4;
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(57, 15);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(220, 24);
            this.tbID.TabIndex = 3;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbID.Location = new System.Drawing.Point(22, 18);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(29, 18);
            this.lbID.TabIndex = 2;
            this.lbID.Text = "ID:";
            // 
            // btTimID
            // 
            this.btTimID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimID.Location = new System.Drawing.Point(294, 11);
            this.btTimID.Name = "btTimID";
            this.btTimID.Size = new System.Drawing.Size(101, 39);
            this.btTimID.TabIndex = 1;
            this.btTimID.Text = "Tìm ";
            this.btTimID.UseVisualStyleBackColor = true;
            this.btTimID.Click += new System.EventHandler(this.btTimID_Click);
            // 
            // Dsnhanvien
            // 
            this.Dsnhanvien.Controls.Add(this.tabControl2);
            this.Dsnhanvien.Location = new System.Drawing.Point(4, 25);
            this.Dsnhanvien.Name = "Dsnhanvien";
            this.Dsnhanvien.Size = new System.Drawing.Size(792, 413);
            this.Dsnhanvien.TabIndex = 2;
            this.Dsnhanvien.Text = "Danh sách nhân viên ";
            this.Dsnhanvien.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.Loai);
            this.tabControl2.Controls.Add(this.Kinhnghiem);
            this.tabControl2.Controls.Add(this.Kinang);
            this.tabControl2.Controls.Add(this.Totnghiep);
            this.tabControl2.Controls.Add(this.Nganh);
            this.tabControl2.Location = new System.Drawing.Point(5, 7);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(784, 403);
            this.tabControl2.TabIndex = 0;
            // 
            // Loai
            // 
            this.Loai.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Loai.BackgroundImage")));
            this.Loai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Loai.Controls.Add(this.dgvDs);
            this.Loai.Controls.Add(this.btFresher);
            this.Loai.Controls.Add(this.btIntern);
            this.Loai.Controls.Add(this.btExperience);
            this.Loai.Location = new System.Drawing.Point(4, 25);
            this.Loai.Name = "Loai";
            this.Loai.Padding = new System.Windows.Forms.Padding(3);
            this.Loai.Size = new System.Drawing.Size(776, 374);
            this.Loai.TabIndex = 0;
            this.Loai.Text = "Theo loại";
            this.Loai.UseVisualStyleBackColor = true;
            // 
            // dgvDs
            // 
            this.dgvDs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDs.Location = new System.Drawing.Point(6, 51);
            this.dgvDs.Name = "dgvDs";
            this.dgvDs.RowHeadersWidth = 51;
            this.dgvDs.RowTemplate.Height = 24;
            this.dgvDs.Size = new System.Drawing.Size(764, 320);
            this.dgvDs.TabIndex = 10;
            // 
            // btFresher
            // 
            this.btFresher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFresher.Location = new System.Drawing.Point(545, 6);
            this.btFresher.Name = "btFresher";
            this.btFresher.Size = new System.Drawing.Size(229, 39);
            this.btFresher.TabIndex = 8;
            this.btFresher.Text = "Fresher";
            this.btFresher.UseVisualStyleBackColor = true;
            this.btFresher.Click += new System.EventHandler(this.btFresher_Click);
            // 
            // btIntern
            // 
            this.btIntern.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIntern.Location = new System.Drawing.Point(270, 6);
            this.btIntern.Name = "btIntern";
            this.btIntern.Size = new System.Drawing.Size(229, 39);
            this.btIntern.TabIndex = 7;
            this.btIntern.Text = "Intern";
            this.btIntern.UseVisualStyleBackColor = true;
            this.btIntern.Click += new System.EventHandler(this.btIntern_Click);
            // 
            // btExperience
            // 
            this.btExperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExperience.Location = new System.Drawing.Point(6, 6);
            this.btExperience.Name = "btExperience";
            this.btExperience.Size = new System.Drawing.Size(229, 39);
            this.btExperience.TabIndex = 6;
            this.btExperience.Text = "Experience";
            this.btExperience.UseVisualStyleBackColor = true;
            this.btExperience.Click += new System.EventHandler(this.btExperience_Click);
            // 
            // Kinhnghiem
            // 
            this.Kinhnghiem.Controls.Add(this.tbKN);
            this.Kinhnghiem.Controls.Add(this.label1);
            this.Kinhnghiem.Controls.Add(this.btKN);
            this.Kinhnghiem.Controls.Add(this.dgvKN);
            this.Kinhnghiem.Location = new System.Drawing.Point(4, 25);
            this.Kinhnghiem.Name = "Kinhnghiem";
            this.Kinhnghiem.Padding = new System.Windows.Forms.Padding(3);
            this.Kinhnghiem.Size = new System.Drawing.Size(776, 374);
            this.Kinhnghiem.TabIndex = 1;
            this.Kinhnghiem.Text = "Theo kinh nghiệm";
            this.Kinhnghiem.UseVisualStyleBackColor = true;
            // 
            // tbKN
            // 
            this.tbKN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKN.Location = new System.Drawing.Point(132, 15);
            this.tbKN.Name = "tbKN";
            this.tbKN.Size = new System.Drawing.Size(220, 24);
            this.tbKN.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kinh nghiệm:";
            // 
            // btKN
            // 
            this.btKN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKN.Location = new System.Drawing.Point(392, 8);
            this.btKN.Name = "btKN";
            this.btKN.Size = new System.Drawing.Size(101, 39);
            this.btKN.TabIndex = 12;
            this.btKN.Text = "Tìm ";
            this.btKN.UseVisualStyleBackColor = true;
            this.btKN.Click += new System.EventHandler(this.btKN_Click);
            // 
            // dgvKN
            // 
            this.dgvKN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKN.Location = new System.Drawing.Point(3, 56);
            this.dgvKN.Name = "dgvKN";
            this.dgvKN.RowHeadersWidth = 51;
            this.dgvKN.RowTemplate.Height = 24;
            this.dgvKN.Size = new System.Drawing.Size(764, 315);
            this.dgvKN.TabIndex = 11;
            // 
            // Kinang
            // 
            this.Kinang.Controls.Add(this.tbKyNang);
            this.Kinang.Controls.Add(this.label2);
            this.Kinang.Controls.Add(this.btKyNang);
            this.Kinang.Controls.Add(this.dgvKyNang);
            this.Kinang.Location = new System.Drawing.Point(4, 25);
            this.Kinang.Name = "Kinang";
            this.Kinang.Size = new System.Drawing.Size(776, 374);
            this.Kinang.TabIndex = 2;
            this.Kinang.Text = "Theo kỹ năng";
            this.Kinang.UseVisualStyleBackColor = true;
            // 
            // tbKyNang
            // 
            this.tbKyNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKyNang.Location = new System.Drawing.Point(89, 13);
            this.tbKyNang.Name = "tbKyNang";
            this.tbKyNang.Size = new System.Drawing.Size(266, 24);
            this.tbKyNang.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Kĩ năng:";
            // 
            // btKyNang
            // 
            this.btKyNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKyNang.Location = new System.Drawing.Point(395, 6);
            this.btKyNang.Name = "btKyNang";
            this.btKyNang.Size = new System.Drawing.Size(101, 39);
            this.btKyNang.TabIndex = 16;
            this.btKyNang.Text = "Tìm ";
            this.btKyNang.UseVisualStyleBackColor = true;
            this.btKyNang.Click += new System.EventHandler(this.btKyNang_Click);
            // 
            // dgvKyNang
            // 
            this.dgvKyNang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKyNang.Location = new System.Drawing.Point(6, 54);
            this.dgvKyNang.Name = "dgvKyNang";
            this.dgvKyNang.RowHeadersWidth = 51;
            this.dgvKyNang.RowTemplate.Height = 24;
            this.dgvKyNang.Size = new System.Drawing.Size(764, 315);
            this.dgvKyNang.TabIndex = 15;
            // 
            // Totnghiep
            // 
            this.Totnghiep.Controls.Add(this.btXuatsac);
            this.Totnghiep.Controls.Add(this.btGioi);
            this.Totnghiep.Controls.Add(this.btKha);
            this.Totnghiep.Controls.Add(this.btTrungbinh);
            this.Totnghiep.Controls.Add(this.dgvLTNghiep);
            this.Totnghiep.Location = new System.Drawing.Point(4, 25);
            this.Totnghiep.Name = "Totnghiep";
            this.Totnghiep.Size = new System.Drawing.Size(776, 374);
            this.Totnghiep.TabIndex = 3;
            this.Totnghiep.Text = "Theo loại tốt nghiệp ";
            this.Totnghiep.UseVisualStyleBackColor = true;
            // 
            // btXuatsac
            // 
            this.btXuatsac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXuatsac.Location = new System.Drawing.Point(615, 9);
            this.btXuatsac.Name = "btXuatsac";
            this.btXuatsac.Size = new System.Drawing.Size(155, 39);
            this.btXuatsac.TabIndex = 25;
            this.btXuatsac.Text = "Xuất sắc";
            this.btXuatsac.UseVisualStyleBackColor = true;
            this.btXuatsac.Click += new System.EventHandler(this.btXuatsac_Click);
            // 
            // btGioi
            // 
            this.btGioi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGioi.Location = new System.Drawing.Point(420, 9);
            this.btGioi.Name = "btGioi";
            this.btGioi.Size = new System.Drawing.Size(155, 39);
            this.btGioi.TabIndex = 24;
            this.btGioi.Text = "Giỏi ";
            this.btGioi.UseVisualStyleBackColor = true;
            this.btGioi.Click += new System.EventHandler(this.btGioi_Click);
            // 
            // btKha
            // 
            this.btKha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKha.Location = new System.Drawing.Point(199, 9);
            this.btKha.Name = "btKha";
            this.btKha.Size = new System.Drawing.Size(155, 39);
            this.btKha.TabIndex = 23;
            this.btKha.Text = "Khá ";
            this.btKha.UseVisualStyleBackColor = true;
            this.btKha.Click += new System.EventHandler(this.btKha_Click);
            // 
            // btTrungbinh
            // 
            this.btTrungbinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTrungbinh.Location = new System.Drawing.Point(6, 9);
            this.btTrungbinh.Name = "btTrungbinh";
            this.btTrungbinh.Size = new System.Drawing.Size(155, 39);
            this.btTrungbinh.TabIndex = 22;
            this.btTrungbinh.Text = "Trung Bình";
            this.btTrungbinh.UseVisualStyleBackColor = true;
            this.btTrungbinh.Click += new System.EventHandler(this.btTrungbinh_Click);
            // 
            // dgvLTNghiep
            // 
            this.dgvLTNghiep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLTNghiep.Location = new System.Drawing.Point(6, 54);
            this.dgvLTNghiep.Name = "dgvLTNghiep";
            this.dgvLTNghiep.RowHeadersWidth = 51;
            this.dgvLTNghiep.RowTemplate.Height = 24;
            this.dgvLTNghiep.Size = new System.Drawing.Size(764, 315);
            this.dgvLTNghiep.TabIndex = 19;
            // 
            // Nganh
            // 
            this.Nganh.Controls.Add(this.tbCN);
            this.Nganh.Controls.Add(this.label3);
            this.Nganh.Controls.Add(this.btCN);
            this.Nganh.Controls.Add(this.dgvCN);
            this.Nganh.Location = new System.Drawing.Point(4, 25);
            this.Nganh.Name = "Nganh";
            this.Nganh.Size = new System.Drawing.Size(776, 374);
            this.Nganh.TabIndex = 4;
            this.Nganh.Text = "Theo chuyên ngành";
            this.Nganh.UseVisualStyleBackColor = true;
            // 
            // tbCN
            // 
            this.tbCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCN.Location = new System.Drawing.Point(139, 13);
            this.tbCN.Name = "tbCN";
            this.tbCN.Size = new System.Drawing.Size(241, 24);
            this.tbCN.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Chuyên ngành:";
            // 
            // btCN
            // 
            this.btCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCN.Location = new System.Drawing.Point(395, 6);
            this.btCN.Name = "btCN";
            this.btCN.Size = new System.Drawing.Size(101, 39);
            this.btCN.TabIndex = 20;
            this.btCN.Text = "Tìm ";
            this.btCN.UseVisualStyleBackColor = true;
            this.btCN.Click += new System.EventHandler(this.btCN_Click);
            // 
            // dgvCN
            // 
            this.dgvCN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCN.Location = new System.Drawing.Point(6, 54);
            this.dgvCN.Name = "dgvCN";
            this.dgvCN.RowHeadersWidth = 51;
            this.dgvCN.RowTemplate.Height = 24;
            this.dgvCN.Size = new System.Drawing.Size(764, 315);
            this.dgvCN.TabIndex = 19;
            // 
            // Luong
            // 
            this.Luong.Controls.Add(this.tbDsLuong);
            this.Luong.Location = new System.Drawing.Point(4, 25);
            this.Luong.Name = "Luong";
            this.Luong.Size = new System.Drawing.Size(792, 413);
            this.Luong.TabIndex = 3;
            this.Luong.Text = "Danh sách lương nhân viên";
            this.Luong.UseVisualStyleBackColor = true;
            // 
            // tbDsLuong
            // 
            this.tbDsLuong.Location = new System.Drawing.Point(14, 23);
            this.tbDsLuong.Multiline = true;
            this.tbDsLuong.Name = "tbDsLuong";
            this.tbDsLuong.ReadOnly = true;
            this.tbDsLuong.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDsLuong.Size = new System.Drawing.Size(764, 387);
            this.tbDsLuong.TabIndex = 21;
            // 
            // Kynang
            // 
            this.Kynang.Location = new System.Drawing.Point(4, 25);
            this.Kynang.Name = "Kynang";
            this.Kynang.Size = new System.Drawing.Size(868, 570);
            this.Kynang.TabIndex = 2;
            this.Kynang.Text = "Theo kĩ năng ";
            this.Kynang.UseVisualStyleBackColor = true;
            // 
            // Loaitotnghiep
            // 
            this.Loaitotnghiep.Location = new System.Drawing.Point(4, 25);
            this.Loaitotnghiep.Name = "Loaitotnghiep";
            this.Loaitotnghiep.Size = new System.Drawing.Size(868, 570);
            this.Loaitotnghiep.TabIndex = 3;
            this.Loaitotnghiep.Text = "Theo loại tốt nghiệp ";
            this.Loaitotnghiep.UseVisualStyleBackColor = true;
            // 
            // Chuyennganh
            // 
            this.Chuyennganh.Location = new System.Drawing.Point(4, 25);
            this.Chuyennganh.Name = "Chuyennganh";
            this.Chuyennganh.Size = new System.Drawing.Size(868, 570);
            this.Chuyennganh.TabIndex = 4;
            this.Chuyennganh.Text = "Theo chuyên ngành";
            this.Chuyennganh.UseVisualStyleBackColor = true;
            // 
            // ChucNang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 463);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "ChucNang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChucNang";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Tim.ResumeLayout(false);
            this.Tim.PerformLayout();
            this.Dsnhanvien.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.Loai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDs)).EndInit();
            this.Kinhnghiem.ResumeLayout(false);
            this.Kinhnghiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKN)).EndInit();
            this.Kinang.ResumeLayout(false);
            this.Kinang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKyNang)).EndInit();
            this.Totnghiep.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLTNghiep)).EndInit();
            this.Nganh.ResumeLayout(false);
            this.Nganh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCN)).EndInit();
            this.Luong.ResumeLayout(false);
            this.Luong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tim;
        private System.Windows.Forms.TabPage Dsnhanvien;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage Loai;
        private System.Windows.Forms.TabPage Kinhnghiem;
        private System.Windows.Forms.TabPage Luong;
        private System.Windows.Forms.TabPage Kynang;
        private System.Windows.Forms.TabPage Loaitotnghiep;
        private System.Windows.Forms.TabPage Chuyennganh;
        private System.Windows.Forms.TabPage Kinang;
        private System.Windows.Forms.TabPage Totnghiep;
        private System.Windows.Forms.TabPage Nganh;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btTimID;
        private System.Windows.Forms.TextBox tbShowemp;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btCapNhat;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btFresher;
        private System.Windows.Forms.Button btIntern;
        private System.Windows.Forms.Button btExperience;
        private System.Windows.Forms.DataGridView dgvDs;
        private System.Windows.Forms.TextBox tbKN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btKN;
        private System.Windows.Forms.DataGridView dgvKN;
        private System.Windows.Forms.TextBox tbKyNang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btKyNang;
        private System.Windows.Forms.DataGridView dgvKyNang;
        private System.Windows.Forms.Button btXuatsac;
        private System.Windows.Forms.Button btGioi;
        private System.Windows.Forms.Button btKha;
        private System.Windows.Forms.Button btTrungbinh;
        private System.Windows.Forms.DataGridView dgvLTNghiep;
        private System.Windows.Forms.TextBox tbCN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btCN;
        private System.Windows.Forms.DataGridView dgvCN;
        private System.Windows.Forms.TextBox tbDsLuong;
    }
}
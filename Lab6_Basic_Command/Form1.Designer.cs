namespace Lab6_Basic_Command
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
            this.components = new System.ComponentModel.Container();
            this.tc = new System.Windows.Forms.TabControl();
            this.tp1 = new System.Windows.Forms.TabPage();
            this.lvCategory = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmViewFood = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.sfaf = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmsDelA = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsViewDetailA = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_create_Date = new System.Windows.Forms.DateTimePicker();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_tell = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbb_stt = new System.Windows.Forms.ComboBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.cbb_role = new System.Windows.Forms.ComboBox();
            this.txt_account_name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Change_pasword = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbb_Status = new System.Windows.Forms.ComboBox();
            this.cbb_Group = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_viewDetail = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_Capacity = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.tc.SuspendLayout();
            this.tp1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tc
            // 
            this.tc.Controls.Add(this.tp1);
            this.tc.Controls.Add(this.tabPage1);
            this.tc.Controls.Add(this.tabPage2);
            this.tc.Controls.Add(this.tabPage3);
            this.tc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc.Location = new System.Drawing.Point(0, 0);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(895, 557);
            this.tc.TabIndex = 0;
            this.tc.SelectedIndexChanged += new System.EventHandler(this.tc_SelectedIndexChanged);
            // 
            // tp1
            // 
            this.tp1.Controls.Add(this.lvCategory);
            this.tp1.Controls.Add(this.btnDelete);
            this.tp1.Controls.Add(this.btnUpdate);
            this.tp1.Controls.Add(this.btnAdd);
            this.tp1.Controls.Add(this.btnLoad);
            this.tp1.Controls.Add(this.txtType);
            this.tp1.Controls.Add(this.label3);
            this.tp1.Controls.Add(this.txtName);
            this.tp1.Controls.Add(this.label2);
            this.tp1.Controls.Add(this.txtID);
            this.tp1.Controls.Add(this.label1);
            this.tp1.Location = new System.Drawing.Point(4, 25);
            this.tp1.Name = "tp1";
            this.tp1.Padding = new System.Windows.Forms.Padding(3);
            this.tp1.Size = new System.Drawing.Size(887, 528);
            this.tp1.TabIndex = 0;
            this.tp1.Text = "Nhóm món ăn";
            this.tp1.UseVisualStyleBackColor = true;
            // 
            // lvCategory
            // 
            this.lvCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvCategory.ContextMenuStrip = this.contextMenuStrip1;
            this.lvCategory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvCategory.FullRowSelect = true;
            this.lvCategory.HideSelection = false;
            this.lvCategory.Location = new System.Drawing.Point(3, 176);
            this.lvCategory.MultiSelect = false;
            this.lvCategory.Name = "lvCategory";
            this.lvCategory.Size = new System.Drawing.Size(881, 349);
            this.lvCategory.TabIndex = 6;
            this.lvCategory.UseCompatibleStateImageBehavior = false;
            this.lvCategory.View = System.Windows.Forms.View.Details;
            this.lvCategory.Click += new System.EventHandler(this.lvCategory_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Loại";
            this.columnHeader1.Width = 97;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên loại món ăn";
            this.columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Loại";
            this.columnHeader3.Width = 112;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDelete,
            this.tsmViewFood});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(233, 52);
            // 
            // tsmDelete
            // 
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(232, 24);
            this.tsmDelete.Text = "Xóa nhóm sản phẩm";
            this.tsmDelete.Click += new System.EventHandler(this.tsmDelete_Click);
            // 
            // tsmViewFood
            // 
            this.tsmViewFood.Name = "tsmViewFood";
            this.tsmViewFood.Size = new System.Drawing.Size(232, 24);
            this.tsmViewFood.Text = "Xem danh sách món ăn";
            this.tsmViewFood.Click += new System.EventHandler(this.tsmViewFood_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(482, 128);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 29);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(358, 128);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 29);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(234, 128);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 29);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(28, 128);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(118, 29);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Lấy danh sách";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtType
            // 
            this.txtType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.Location = new System.Drawing.Point(153, 83);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(328, 28);
            this.txtType.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(153, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(328, 28);
            this.txtName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên nhóm thức ăn:";
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(153, 15);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(328, 28);
            this.txtID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhóm:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvBill);
            this.tabPage1.Controls.Add(this.dtp2);
            this.tabPage1.Controls.Add(this.dtp1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.sfaf);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(887, 528);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "BillsForm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvBill
            // 
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBill.Location = new System.Drawing.Point(3, 66);
            this.dgvBill.MultiSelect = false;
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowHeadersWidth = 51;
            this.dgvBill.RowTemplate.Height = 24;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(881, 459);
            this.dgvBill.TabIndex = 2;
            this.dgvBill.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBill_CellContentDoubleClick);
            // 
            // dtp2
            // 
            this.dtp2.CustomFormat = "dd/MM/yyyy";
            this.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp2.Location = new System.Drawing.Point(411, 18);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(200, 22);
            this.dtp2.TabIndex = 1;
            this.dtp2.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtp1
            // 
            this.dtp1.CustomFormat = "dd/MM/yyyy";
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp1.Location = new System.Drawing.Point(96, 17);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(200, 22);
            this.dtp1.TabIndex = 1;
            this.dtp1.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtp1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tới ngày";
            // 
            // sfaf
            // 
            this.sfaf.AutoSize = true;
            this.sfaf.Location = new System.Drawing.Point(25, 22);
            this.sfaf.Name = "sfaf";
            this.sfaf.Size = new System.Drawing.Size(59, 16);
            this.sfaf.TabIndex = 0;
            this.sfaf.Text = "Từ Ngày";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvAccounts);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(887, 528);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "AccountManager";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccounts.ContextMenuStrip = this.contextMenuStrip2;
            this.dgvAccounts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAccounts.Location = new System.Drawing.Point(3, 262);
            this.dgvAccounts.MultiSelect = false;
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.RowHeadersWidth = 51;
            this.dgvAccounts.RowTemplate.Height = 24;
            this.dgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccounts.Size = new System.Drawing.Size(881, 263);
            this.dgvAccounts.TabIndex = 8;
            this.dgvAccounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccounts_CellClick);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsDelA,
            this.tmsViewDetailA});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(225, 52);
            // 
            // tmsDelA
            // 
            this.tmsDelA.Name = "tmsDelA";
            this.tmsDelA.Size = new System.Drawing.Size(224, 24);
            this.tmsDelA.Text = "Xóa tài khoản";
            this.tmsDelA.Click += new System.EventHandler(this.tmsDelA_Click);
            // 
            // tmsViewDetailA
            // 
            this.tmsViewDetailA.Name = "tmsViewDetailA";
            this.tmsViewDetailA.Size = new System.Drawing.Size(224, 24);
            this.tmsViewDetailA.Text = "Xem danh sách vai trò";
            this.tmsViewDetailA.Click += new System.EventHandler(this.tmsViewDetailA_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_create_Date);
            this.groupBox1.Controls.Add(this.txt_fullname);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_tell);
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbb_stt);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.cbb_role);
            this.groupBox1.Controls.Add(this.txt_account_name);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(19, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(851, 137);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // dtp_create_Date
            // 
            this.dtp_create_Date.Enabled = false;
            this.dtp_create_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_create_Date.Location = new System.Drawing.Point(457, 95);
            this.dtp_create_Date.Name = "dtp_create_Date";
            this.dtp_create_Date.Size = new System.Drawing.Size(164, 22);
            this.dtp_create_Date.TabIndex = 2;
            // 
            // txt_fullname
            // 
            this.txt_fullname.Location = new System.Drawing.Point(115, 96);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(164, 22);
            this.txt_fullname.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(604, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Email";
            // 
            // txt_tell
            // 
            this.txt_tell.Location = new System.Drawing.Point(681, 55);
            this.txt_tell.Name = "txt_tell";
            this.txt_tell.Size = new System.Drawing.Size(164, 22);
            this.txt_tell.TabIndex = 1;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(115, 58);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(164, 22);
            this.txt_password.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(604, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Điện Thoại";
            // 
            // cbb_stt
            // 
            this.cbb_stt.FormattingEnabled = true;
            this.cbb_stt.Items.AddRange(new object[] {
            "Actived",
            "Nonactived"});
            this.cbb_stt.Location = new System.Drawing.Point(398, 49);
            this.cbb_stt.Name = "cbb_stt";
            this.cbb_stt.Size = new System.Drawing.Size(166, 24);
            this.cbb_stt.TabIndex = 2;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(681, 18);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(164, 22);
            this.txt_email.TabIndex = 1;
            // 
            // cbb_role
            // 
            this.cbb_role.FormattingEnabled = true;
            this.cbb_role.Location = new System.Drawing.Point(398, 10);
            this.cbb_role.Name = "cbb_role";
            this.cbb_role.Size = new System.Drawing.Size(166, 24);
            this.cbb_role.TabIndex = 2;
            // 
            // txt_account_name
            // 
            this.txt_account_name.Location = new System.Drawing.Point(115, 21);
            this.txt_account_name.Name = "txt_account_name";
            this.txt_account_name.Size = new System.Drawing.Size(164, 22);
            this.txt_account_name.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(311, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ngày Tạo Tài Khoản";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(311, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Trạng Thái";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(311, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Quyền";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Họ Và Tên";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Mật khẩu";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Tên Tài Khoản";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Change_pasword);
            this.groupBox2.Controls.Add(this.btn_Save);
            this.groupBox2.Controls.Add(this.btn_Clear);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.cbb_Status);
            this.groupBox2.Controls.Add(this.cbb_Group);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(19, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(851, 96);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc";
            // 
            // btn_Change_pasword
            // 
            this.btn_Change_pasword.Location = new System.Drawing.Point(607, 51);
            this.btn_Change_pasword.Name = "btn_Change_pasword";
            this.btn_Change_pasword.Size = new System.Drawing.Size(153, 30);
            this.btn_Change_pasword.TabIndex = 12;
            this.btn_Change_pasword.Text = "Đổi mật khẩu";
            this.btn_Change_pasword.UseVisualStyleBackColor = true;
            this.btn_Change_pasword.Click += new System.EventHandler(this.btn_Change_pasword_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(607, 15);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(153, 30);
            this.btn_Save.TabIndex = 13;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(411, 54);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(153, 30);
            this.btn_Clear.TabIndex = 10;
            this.btn_Clear.Text = "Xóa Trắng";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(411, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "Lấy Danh Sách";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbb_Status
            // 
            this.cbb_Status.FormattingEnabled = true;
            this.cbb_Status.Items.AddRange(new object[] {
            "Actived",
            "Nonactived"});
            this.cbb_Status.Location = new System.Drawing.Point(85, 58);
            this.cbb_Status.Name = "cbb_Status";
            this.cbb_Status.Size = new System.Drawing.Size(251, 24);
            this.cbb_Status.TabIndex = 8;
            // 
            // cbb_Group
            // 
            this.cbb_Group.FormattingEnabled = true;
            this.cbb_Group.Location = new System.Drawing.Point(85, 15);
            this.cbb_Group.Name = "cbb_Group";
            this.cbb_Group.Size = new System.Drawing.Size(251, 24);
            this.cbb_Group.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Trạng thái";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nhóm";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvTable);
            this.tabPage3.Controls.Add(this.btn_Remove);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.btn_viewDetail);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.txt_Capacity);
            this.tabPage3.Controls.Add(this.txt_name);
            this.tabPage3.Controls.Add(this.txt_id);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(887, 528);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(531, 88);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(100, 30);
            this.btn_Remove.TabIndex = 14;
            this.btn_Remove.Text = "Xóa";
            this.btn_Remove.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(531, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 15;
            this.button2.Text = "Lưu";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_viewDetail
            // 
            this.btn_viewDetail.Location = new System.Drawing.Point(446, 124);
            this.btn_viewDetail.Name = "btn_viewDetail";
            this.btn_viewDetail.Size = new System.Drawing.Size(185, 30);
            this.btn_viewDetail.TabIndex = 16;
            this.btn_viewDetail.Text = "Xem Danh Sách Hóa Đơn";
            this.btn_viewDetail.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(531, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 30);
            this.button3.TabIndex = 17;
            this.button3.Text = "Xóa Trắng";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Trống",
            "Có Người"});
            this.comboBox1.Location = new System.Drawing.Point(131, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 24);
            this.comboBox1.TabIndex = 13;
            // 
            // txt_Capacity
            // 
            this.txt_Capacity.Location = new System.Drawing.Point(131, 110);
            this.txt_Capacity.Name = "txt_Capacity";
            this.txt_Capacity.Size = new System.Drawing.Size(180, 22);
            this.txt_Capacity.TabIndex = 11;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(131, 45);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(180, 22);
            this.txt_name.TabIndex = 12;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(131, 16);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(180, 22);
            this.txt_id.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(41, 115);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 16);
            this.label15.TabIndex = 6;
            this.label15.Text = "Số chổ ngồi";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(41, 79);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 16);
            this.label16.TabIndex = 7;
            this.label16.Text = "Trạng thái";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(41, 45);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 16);
            this.label17.TabIndex = 8;
            this.label17.Text = "Tên bàn";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(41, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 16);
            this.label18.TabIndex = 9;
            this.label18.Text = "Mã bàn";
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTable.Location = new System.Drawing.Point(3, 178);
            this.dgvTable.MultiSelect = false;
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.RowHeadersWidth = 51;
            this.dgvTable.RowTemplate.Height = 24;
            this.dgvTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTable.Size = new System.Drawing.Size(881, 347);
            this.dgvTable.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 557);
            this.Controls.Add(this.tc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tc.ResumeLayout(false);
            this.tp1.ResumeLayout(false);
            this.tp1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc;
        private System.Windows.Forms.TabPage tp1;
        private System.Windows.Forms.ListView lvCategory;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmViewFood;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label sfaf;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvAccounts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_create_Date;
        private System.Windows.Forms.TextBox txt_fullname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_tell;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbb_stt;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.ComboBox cbb_role;
        private System.Windows.Forms.TextBox txt_account_name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbb_Group;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Change_pasword;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tmsDelA;
        private System.Windows.Forms.ToolStripMenuItem tmsViewDetailA;
        private System.Windows.Forms.ComboBox cbb_Status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_viewDetail;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt_Capacity;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}



namespace GiuKi
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExcelSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiJsonSave = new System.Windows.Forms.ToolStripMenuItem();
            this.inToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tvLop = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rdSdt = new System.Windows.Forms.RadioButton();
            this.rdTen = new System.Windows.Forms.RadioButton();
            this.rdMs = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lvSv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmstDs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiThem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRemoveSv = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.cmstDs.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpToolStripMenuItem,
            this.lưuToolStripMenuItem,
            this.inToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1246, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nhậpToolStripMenuItem
            // 
            this.nhậpToolStripMenuItem.Name = "nhậpToolStripMenuItem";
            this.nhậpToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.nhậpToolStripMenuItem.Text = "Nhập";
            // 
            // lưuToolStripMenuItem
            // 
            this.lưuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExcelSave,
            this.tsmiJsonSave});
            this.lưuToolStripMenuItem.Name = "lưuToolStripMenuItem";
            this.lưuToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.lưuToolStripMenuItem.Text = "Lưu";
            // 
            // tsmiExcelSave
            // 
            this.tsmiExcelSave.Name = "tsmiExcelSave";
            this.tsmiExcelSave.Size = new System.Drawing.Size(224, 26);
            this.tsmiExcelSave.Text = "Excel";
            this.tsmiExcelSave.Click += new System.EventHandler(this.tsmiExcelSave_Click);
            // 
            // tsmiJsonSave
            // 
            this.tsmiJsonSave.Name = "tsmiJsonSave";
            this.tsmiJsonSave.Size = new System.Drawing.Size(224, 26);
            this.tsmiJsonSave.Text = "Json";
            this.tsmiJsonSave.Click += new System.EventHandler(this.tsmiJsonSave_Click);
            // 
            // inToolStripMenuItem
            // 
            this.inToolStripMenuItem.Name = "inToolStripMenuItem";
            this.inToolStripMenuItem.Size = new System.Drawing.Size(35, 24);
            this.inToolStripMenuItem.Text = "In";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.tvLop);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 586);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn lớp để hiển thị danh sách sinh viên";
            // 
            // tvLop
            // 
            this.tvLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvLop.Location = new System.Drawing.Point(3, 18);
            this.tvLop.Name = "tvLop";
            this.tvLop.Size = new System.Drawing.Size(301, 565);
            this.tvLop.TabIndex = 0;
            this.tvLop.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvLop_AfterSelect);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.rdSdt);
            this.groupBox2.Controls.Add(this.rdTen);
            this.groupBox2.Controls.Add(this.rdMs);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lvSv);
            this.groupBox2.Location = new System.Drawing.Point(354, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(880, 615);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(130, 53);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(379, 22);
            this.txtSearch.TabIndex = 5;
            // 
            // rdSdt
            // 
            this.rdSdt.AutoSize = true;
            this.rdSdt.Location = new System.Drawing.Point(397, 21);
            this.rdSdt.Name = "rdSdt";
            this.rdSdt.Size = new System.Drawing.Size(112, 21);
            this.rdSdt.TabIndex = 4;
            this.rdSdt.TabStop = true;
            this.rdSdt.Text = "Số điện thoại";
            this.rdSdt.UseVisualStyleBackColor = true;
            // 
            // rdTen
            // 
            this.rdTen.AutoSize = true;
            this.rdTen.Location = new System.Drawing.Point(260, 21);
            this.rdTen.Name = "rdTen";
            this.rdTen.Size = new System.Drawing.Size(71, 21);
            this.rdTen.TabIndex = 3;
            this.rdTen.TabStop = true;
            this.rdTen.Text = "Họ tên";
            this.rdTen.UseVisualStyleBackColor = true;
            // 
            // rdMs
            // 
            this.rdMs.AutoSize = true;
            this.rdMs.Checked = true;
            this.rdMs.Location = new System.Drawing.Point(133, 21);
            this.rdMs.Name = "rdMs";
            this.rdMs.Size = new System.Drawing.Size(67, 21);
            this.rdMs.TabIndex = 2;
            this.rdMs.TabStop = true;
            this.rdMs.Text = "MSSV";
            this.rdMs.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm theo:";
            // 
            // lvSv
            // 
            this.lvSv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvSv.ContextMenuStrip = this.cmstDs;
            this.lvSv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvSv.FullRowSelect = true;
            this.lvSv.GridLines = true;
            this.lvSv.HideSelection = false;
            this.lvSv.Location = new System.Drawing.Point(3, 83);
            this.lvSv.Name = "lvSv";
            this.lvSv.Size = new System.Drawing.Size(874, 529);
            this.lvSv.TabIndex = 0;
            this.lvSv.UseCompatibleStateImageBehavior = false;
            this.lvSv.View = System.Windows.Forms.View.Details;
            this.lvSv.SelectedIndexChanged += new System.EventHandler(this.lvSv_SelectedIndexChanged);
            this.lvSv.DoubleClick += new System.EventHandler(this.lvSv_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MSSV";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ và tên lót";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên";
            this.columnHeader3.Width = 63;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giới tính";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày sinh";
            this.columnHeader5.Width = 84;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số điện thoại";
            this.columnHeader6.Width = 95;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Lớp";
            // 
            // cmstDs
            // 
            this.cmstDs.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmstDs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiThem,
            this.tsmiRemoveSv});
            this.cmstDs.Name = "cmstDs";
            this.cmstDs.Size = new System.Drawing.Size(116, 52);
            // 
            // tsmiThem
            // 
            this.tsmiThem.Name = "tsmiThem";
            this.tsmiThem.Size = new System.Drawing.Size(115, 24);
            this.tsmiThem.Text = "Thêm";
            this.tsmiThem.Click += new System.EventHandler(this.tsmiThem_Click);
            // 
            // tsmiRemoveSv
            // 
            this.tsmiRemoveSv.Name = "tsmiRemoveSv";
            this.tsmiRemoveSv.Size = new System.Drawing.Size(115, 24);
            this.tsmiRemoveSv.Text = "Xóa";
            this.tsmiRemoveSv.Click += new System.EventHandler(this.tsmiRemoveSv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 639);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.cmstDs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView tvLop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rdSdt;
        private System.Windows.Forms.RadioButton rdTen;
        private System.Windows.Forms.RadioButton rdMs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvSv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ContextMenuStrip cmstDs;
        private System.Windows.Forms.ToolStripMenuItem tsmiThem;
        private System.Windows.Forms.ToolStripMenuItem tsmiRemoveSv;
        private System.Windows.Forms.ToolStripMenuItem tsmiExcelSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiJsonSave;
    }
}


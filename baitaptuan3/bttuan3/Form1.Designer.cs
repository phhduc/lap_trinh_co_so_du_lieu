
namespace bttuan3
{
    partial class MainForm
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
            this.tvwPublisher = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.bntRemove = new System.Windows.Forms.Button();
            this.pnNews = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tvwPublisher
            // 
            this.tvwPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvwPublisher.Location = new System.Drawing.Point(12, 50);
            this.tvwPublisher.Name = "tvwPublisher";
            this.tvwPublisher.Size = new System.Drawing.Size(251, 605);
            this.tvwPublisher.TabIndex = 0;
            this.tvwPublisher.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwPublisher_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn toàn soạn, chuyên mục";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(204, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(28, 25);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // bntRemove
            // 
            this.bntRemove.Location = new System.Drawing.Point(235, 20);
            this.bntRemove.Name = "bntRemove";
            this.bntRemove.Size = new System.Drawing.Size(28, 25);
            this.bntRemove.TabIndex = 4;
            this.bntRemove.Text = "-";
            this.bntRemove.UseVisualStyleBackColor = true;
            this.bntRemove.Click += new System.EventHandler(this.bntRemove_Click);
            // 
            // pnNews
            // 
            this.pnNews.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnNews.AutoScroll = true;
            this.pnNews.BackgroundImage = global::bttuan3.Properties.Resources.bg;
            this.pnNews.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnNews.Location = new System.Drawing.Point(269, 50);
            this.pnNews.Name = "pnNews";
            this.pnNews.Size = new System.Drawing.Size(765, 600);
            this.pnNews.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 667);
            this.Controls.Add(this.bntRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnNews);
            this.Controls.Add(this.tvwPublisher);
            this.Name = "MainForm";
            this.Text = "Quản lý tin tức";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvwPublisher;
        private System.Windows.Forms.Panel pnNews;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button bntRemove;
    }
}


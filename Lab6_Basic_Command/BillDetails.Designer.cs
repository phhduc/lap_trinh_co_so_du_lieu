namespace Lab6_Basic_Command
{
    partial class BillDetails
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
            this.d = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.d)).BeginInit();
            this.SuspendLayout();
            // 
            // d
            // 
            this.d.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.d.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d.Location = new System.Drawing.Point(0, 0);
            this.d.MultiSelect = false;
            this.d.Name = "d";
            this.d.RowHeadersWidth = 51;
            this.d.RowTemplate.Height = 24;
            this.d.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.d.Size = new System.Drawing.Size(800, 450);
            this.d.TabIndex = 0;
            // 
            // BillDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.d);
            this.Name = "BillDetails";
            this.Text = "BillDetails";
            ((System.ComponentModel.ISupportInitialize)(this.d)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView d;
    }
}
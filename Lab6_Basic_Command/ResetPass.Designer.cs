namespace Lab6_Basic_Command
{
    partial class ResetPass
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
            this.a = new System.Windows.Forms.Label();
            this.txtP0 = new System.Windows.Forms.TextBox();
            this.f = new System.Windows.Forms.Label();
            this.txtP1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtP2 = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(24, 35);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(78, 16);
            this.a.TabIndex = 0;
            this.a.Text = "Mật khẩu cũ";
            // 
            // txtP0
            // 
            this.txtP0.Location = new System.Drawing.Point(174, 32);
            this.txtP0.Name = "txtP0";
            this.txtP0.PasswordChar = '*';
            this.txtP0.Size = new System.Drawing.Size(258, 22);
            this.txtP0.TabIndex = 1;
            // 
            // f
            // 
            this.f.AutoSize = true;
            this.f.Location = new System.Drawing.Point(24, 63);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(86, 16);
            this.f.TabIndex = 0;
            this.f.Text = "Mật khẩu mới";
            // 
            // txtP1
            // 
            this.txtP1.Location = new System.Drawing.Point(174, 60);
            this.txtP1.Name = "txtP1";
            this.txtP1.PasswordChar = '*';
            this.txtP1.Size = new System.Drawing.Size(258, 22);
            this.txtP1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Xác nhận mật khẩu mới";
            // 
            // txtP2
            // 
            this.txtP2.Location = new System.Drawing.Point(174, 88);
            this.txtP2.Name = "txtP2";
            this.txtP2.PasswordChar = '*';
            this.txtP2.Size = new System.Drawing.Size(258, 22);
            this.txtP2.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(224, 137);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(357, 137);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ResetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 178);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtP2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtP1);
            this.Controls.Add(this.f);
            this.Controls.Add(this.txtP0);
            this.Controls.Add(this.a);
            this.Name = "ResetPass";
            this.Text = "ResetPass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label a;
        private System.Windows.Forms.TextBox txtP0;
        private System.Windows.Forms.Label f;
        private System.Windows.Forms.TextBox txtP1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtP2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_Basic_Command
{
    public partial class ResetPass : Form
    {
        public ResetPass()
        {
            InitializeComponent();
        }
        private string usr, pss;
        public ResetPass(string usr, string pss):this()
        {
            
            this.usr = usr;
            this.pss = pss;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtP1.Text != txtP2.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không trùng khớp");
                return;
            }
            if(txtP0.Text != this.pss)
            {
                MessageBox.Show("Sai mật khẩu cũ");
                return;
            }
            string pp = txtP1.Text;
            SqlConnection c = new SqlConnection("server:RE;database:RestaurantManagement;Integrated Security:true;");
            SqlCommand cmd = c.CreateCommand();
            cmd.CommandText = $"Update Account set Password = N'{pp}' where AccoutName = N'{this.usr}'";
            c.Open();
            int n = cmd.ExecuteNonQuery();
            c.Close();
            c.Dispose();
            if (n > 0)
            {
                MessageBox.Show("Đổi mật khẩu thành công");
                this.btnCancel.PerformClick();
            }
        }


    }
}

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
    public partial class RoleAccount : Form
    {
        public RoleAccount()
        {
            InitializeComponent();
        }
        public void LoadF(string acc)
        {
            SqlConnection c = new SqlConnection("server:RE;database=RestaurantManagement;Integrated Security:true;");
            SqlCommand cmd = c.CreateCommand();
            cmd.CommandText= "select ra.RoleID, r.RoleName, ra.AccountName, ra.Actived, ra.Notes, r.Path" +
                " from RoleAccount ra, Role r where ra.AccountName = '" + acc + "' and r.ID = ra.RoleID";
            c.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            d.DataSource = dt;
            this.Text = "Danh sách vai trò của tài khoản: " + acc;
            c.Close();
            c.Dispose();
            da.Dispose();
            d.Columns[0].HeaderText = "Mã Quyền";
            d.Columns[1].HeaderText = "Tên Quyền";
            d.Columns[2].HeaderText = "Tên tài khoản";
            d.Columns[3].HeaderText = "Trạng thái";
            d.Columns[4].HeaderText = "Mô tả";
            d.Columns[5].HeaderText = "Đường dẫn";
        }
    }
}

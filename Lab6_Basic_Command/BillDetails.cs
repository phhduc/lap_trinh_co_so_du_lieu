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
    public partial class BillDetails : Form
    {
        public BillDetails()
        {
            InitializeComponent();
        }
        public void LoadF(string id)
        {
            string a = "server=RE;database=RestaurantManagement;Integrated Security=true;";
            SqlConnection c = new SqlConnection(a);
            SqlCommand cmd = c.CreateCommand();
            cmd.CommandText = $"select c.ID, c.Name, Quantity from bills a join BillDetails b on a.ID=b.InvoiceID join Food c on b.FoodID = c.ID where a.ID={id}";
            c.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            d.DataSource = dt;
            d.Columns[0].HeaderText = "ID món ăn";
            d.Columns[1].HeaderText = "Tên món ăn";
            d.Columns[2].HeaderText = "Số lượng";
            c.Close();
            c.Dispose();
            da.Dispose();
            d.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            d.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            d.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}

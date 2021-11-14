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

namespace WindLab7_Advanced_Command
{
    public partial class OrderDetailsForm : Form
    {
        public OrderDetailsForm()
        {
            InitializeComponent();
        }


        public void ShowDetails(int id)
        {
            SqlConnection connect = new SqlConnection(env.sqlconnectString);
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "select b.Name, a.Quantity from BillDetails as a join Food as b on a.FoodID=b.ID where InvoiceID = @id";
            cmd.Parameters.Add("@id", SqlDbType.Int);
            cmd.Parameters["@id"].Value = id;
            connect.Open();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            connect.Close();
            connect.Dispose();
            ad.Dispose();
            d.DataSource = dt;
            d.Columns[0].HeaderText = "Tên món ăn";
            d.Columns[1].HeaderText = "số lượng";
            d.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}

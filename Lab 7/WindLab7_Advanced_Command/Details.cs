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
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }
        public void LoadListBox(string acc)
        {
            SqlConnection conn = new SqlConnection(env.sqlconnectString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"select CheckoutDate from Bills where Account=@name";
            cmd.Parameters.Add("@name", SqlDbType.NVarChar,100);
            cmd.Parameters["@name"].Value = acc;
            conn.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                lbBill.Items.Add(rd["CheckoutDate"].ToString()); 
            }
            rd.Close();
            cmd.CommandText = "select count(ID) from Bills where Account=@name";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@name", SqlDbType.NVarChar, 100);
            cmd.Parameters["@name"].Value=acc;
            int num = (int)cmd.ExecuteScalar();
            txthd.Text= num.ToString();
            cmd.Parameters.Clear();
            cmd.CommandText = "select sum(Amount) from Bills where Account=@name";
            cmd.Parameters.Add("@name",SqlDbType.NVarChar, 100);
            cmd.Parameters["@name"].Value=acc;
            txtT.Text = ((int)cmd.ExecuteScalar()).ToString();
            conn.Close();
            conn.Dispose();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void lbBill_SelectedValueChanged(object sender, EventArgs e)
        {
            string b = lbBill.SelectedItem.ToString();
            DateTime s = DateTime.Parse(b);
            SqlConnection conn = new SqlConnection(env.sqlconnectString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select c.Name, b.Quantity from Bills as a join BillDetails as b on b.InvoiceID=a.ID join Food as c on b.FoodID=c.ID where a.CheckoutDate = @date";
            cmd.Parameters.Add("@date", SqlDbType.SmallDateTime);
            cmd.Parameters["@date"].Value = s;
            conn.Open();
            SqlDataAdapter a = new SqlDataAdapter(cmd);
            DataTable d = new DataTable();
            a.Fill(d);
            conn.Close();
            conn.Dispose();
            a.Dispose();
            dgvDetails.DataSource = d;
        }
    }
}

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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void dtpNgay_ValueChanged(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(env.sqlconnectString);
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "select * from Bills where CheckoutDate = @date";
            cmd.Parameters.Add("@date", SqlDbType.Date);
            cmd.Parameters["@date"].Value=dtpNgay.Value;
            connect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connect.Close();
            connect.Dispose();
            adapter.Dispose();
            dgvOders.DataSource = dt;
            dgvOders.ReadOnly = true;
            dgvOders.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            dgvOders.Columns[dgvOders.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            txtTongDoanhThu.Text = TinhTongDoanhThu().ToString();
        }
        private long TinhTongDoanhThu()
        {
            long sum = 0;
            for (int i = 0; i < dgvOders.Rows.Count; i++)
            {
                sum += Convert.ToInt64(dgvOders.Rows[i].Cells[3].Value);
            }
            return sum;
        }

        private void dgvOders_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id =Convert.ToInt32(dgvOders.SelectedRows[0].Cells[0].Value);
            OrderDetailsForm f = new OrderDetailsForm();
            f.Show(this);
            f.ShowDetails(id);
        }
    }
}

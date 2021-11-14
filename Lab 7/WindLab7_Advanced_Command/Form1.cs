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
    public partial class Form1 : Form
    {
        private DataTable foodTable;
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadCategory()
        {
            SqlConnection sqlConnect = new SqlConnection(env.sqlconnectString);
            SqlCommand sqlCommand = sqlConnect.CreateCommand();
            sqlCommand.CommandText = "select ID, Name from Category";
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sqlConnect.Open();
            da.Fill(dt);
            sqlConnect.Close();
            sqlConnect.Dispose();
            cbbCategory.DataSource = dt;
            cbbCategory.DisplayMember = "Name";
            cbbCategory.ValueMember = "ID";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCategory.SelectedIndex == -1) return;
            SqlConnection sqlConnection= new SqlConnection(env.sqlconnectString);
            SqlCommand sqlCmd = sqlConnection.CreateCommand();
            sqlCmd.CommandText = "select * from Food where FoodCategoryID = @categoryID";
            sqlCmd.Parameters.Add("@categoryID", SqlDbType.Int);
            if(cbbCategory.SelectedValue is DataRowView)
            {
                DataRowView rowView = (DataRowView)cbbCategory.SelectedValue;
                sqlCmd.Parameters["@categoryID"].Value = rowView["ID"];
            } else
            {
                sqlCmd.Parameters["@categoryID"].Value = cbbCategory.SelectedValue;
            }
            SqlDataAdapter adapter= new SqlDataAdapter(sqlCmd);
            foodTable = new DataTable();

            adapter.Fill(foodTable);
            sqlConnection.Close();
            sqlConnection.Dispose();
            dgvFoodList.DataSource = foodTable;
            dgvFoodList.Columns[1].HeaderText = "Tên món ăn";
            dgvFoodList.Columns[2].HeaderText = "Đơn vị tính";
            dgvFoodList.Columns[3].HeaderText = "ID nhóm";
            dgvFoodList.Columns[4].HeaderText = "Giá";
            dgvFoodList.Columns[5].HeaderText = "Ghi chú";
            dgvFoodList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            dgvFoodList.Columns[dgvFoodList.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lblQauntity.Text = foodTable.Rows.Count.ToString();
            lblCatName.Text= cbbCategory.Name;
        }

        private void tsmCalculateQuantity_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection(env.sqlconnectString);
            SqlCommand cmd = sqlConnect.CreateCommand();
            cmd.CommandText = "select @numSaleFood = sum(Quantity) from BillDetails where FoodID=@foodId";
            if(dgvFoodList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];
                DataRowView rowView = selectedRow.DataBoundItem as DataRowView;
                cmd.Parameters.Add("@foodId", SqlDbType.Int);
                cmd.Parameters["@foodId"].Value = rowView["ID"];
                cmd.Parameters.Add("@numSaleFood", SqlDbType.Int);
                cmd.Parameters["@numSaleFood"].Direction = ParameterDirection.Output;
                sqlConnect.Open();
                cmd.ExecuteNonQuery(); 
                string result=cmd.Parameters["@numSaleFood"].Value.ToString();
                if (result == "") result = "0";
                MessageBox.Show($"Tổng số lượng món {rowView["Name"]} đã bán là {result} {rowView["Unit"]}");
                sqlConnect.Close();
            }
            cmd.Dispose();
            sqlConnect.Dispose();
        }

        private void tsmAddFood_Click(object sender, EventArgs e)
        {
            FoodInfoForm f  = new FoodInfoForm();
            f.FormClosed += F_FormClosed;
            f.Show(this);
        }

        private void F_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadCategory();
            int index = cbbCategory.SelectedIndex;
            cbbCategory.SelectedIndex = -1;
            cbbCategory.SelectedIndex = index;
        }

        private void tsmSeperator_Click(object sender, EventArgs e)
        {

        }

        private void tsmUpdateFood_Click(object sender, EventArgs e)
        {
            if(dgvFoodList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];
                DataRowView rowView = selectedRow.DataBoundItem as DataRowView;
                FoodInfoForm f = new FoodInfoForm();
                f.FormClosed += F_FormClosed;
                f.Show(this);
                f.DisplayFoodInfo(rowView);
            }
        }

        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
            if (foodTable == null) return;
            DataViewRowState rowStateFilter = DataViewRowState.OriginalRows;
            DataView foodView = new DataView(foodTable,$"Name like '%{txtSearchByName.Text}%'", "price DESC", rowStateFilter);
            dgvFoodList.DataSource = foodView;
        }

        private void odersFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderForm f = new OrderForm();
            f.Show(this);
        }

        private void accountFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountFoirm f= new AccountFoirm();
            f.Show(this);

        }
    }
}

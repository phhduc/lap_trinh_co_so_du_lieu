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
    public partial class FoodForm : Form
    {
        public FoodForm()
        {
            InitializeComponent();
        }
        public int categoryID;
        public void LoadFood(int categoryID)
        {
            dgvFood.Refresh() ;
             
            this.categoryID = categoryID;
            string connection = "server=RE;database=RestaurantManagement;Integrated Security =true;";
            SqlConnection sqlConnection = new SqlConnection(connection);
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandText = $"select Name from Category where ID ={categoryID.ToString()}";
            sqlConnection.Open();
            string catName = cmd.ExecuteScalar().ToString();
            this.Text = "Danh sách các món ăn thuộc nhóm: " + catName;
            cmd.CommandText = $"select * from Food where FoodCategoryID={categoryID}";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            
            dgvFood.DataSource = dt;
            dgvFood.Columns[0].HeaderText = "ID";
            dgvFood.Columns[1].HeaderText = "Tên món ăn";
            dgvFood.Columns[2].HeaderText = "Đơn vị tính";
            dgvFood.Columns[3].HeaderText = "ID nhóm món ăn";
            dgvFood.Columns[4].HeaderText = "Đơn giá";
            dgvFood.Columns[5].HeaderText = "Ghi chú";
            
            sqlConnection.Close();
            sqlConnection.Dispose();
            adapter.Dispose();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string[] str = new string[6];
            str[0] = dgvFood.CurrentRow.Cells[0].Value.ToString();
            str[1] = dgvFood.CurrentRow.Cells[1].Value.ToString();
            str[2] = dgvFood.CurrentRow.Cells[2].Value.ToString();
            str[3] = dgvFood.CurrentRow.Cells[3].Value.ToString();
            str[4] = dgvFood.CurrentRow.Cells[4].Value.ToString();
            str[5] = dgvFood.CurrentRow.Cells[5].Value.ToString();
            if (str[0] == "")
            {
                insertFood(str);
                
            } else updateFood(str);
            LoadFood(categoryID);
            
            
        }
        private void updateFood(string[] str)
        {
            string connectString = "server=RE;database=RestaurantManagement;Integrated Security=true;";
            SqlConnection connection = new SqlConnection(connectString);
            SqlCommand cmd = connection.CreateCommand();
            connection.Open();
            cmd.CommandText = $"update Food set Name=N'{str[1]}', Unit=N'{str[2]}', Price = {str[4]}, Notes=N'{str[5]}' where ID = {str[0]}";
            int numOfRowsEffected = cmd.ExecuteNonQuery();
            connection.Close();
            if (numOfRowsEffected == 1)
            {
                MessageBox.Show("Cập nhật món ăn thành công");

            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
            }
        }
        private void insertFood(string[] str)
        {
            string connectString = "server=RE;database=RestaurantManagement;Integrated Security=true;";
            SqlConnection connection = new SqlConnection(connectString);
            SqlCommand cmd = connection.CreateCommand();
            connection.Open();
            cmd.CommandText = $"insert into Food(Name, Unit, FoodCategoryID, Price, Notes) values (N'{str[1]}', N'{str[2]}', {categoryID}, {str[4]}, N'{str[5]}')";
            int numOfRowsEffected = cmd.ExecuteNonQuery();
            connection.Close();
            if (numOfRowsEffected == 1)
            {
                MessageBox.Show("Thêm món ăn thành công");
                
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string str = dgvFood.CurrentRow.Cells[0].Value.ToString();
            

            string connectstring = "server=RE; database=RestaurantManagement; Integrated Security =true;";
            SqlConnection sqlConnection = new SqlConnection(connectstring);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $"delete from Food where ID = {str}";
            sqlConnection.Open();
            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (numOfRowsEffected == 1)
            {
                dgvFood.Rows.Remove(dgvFood.CurrentRow);
                btnDelete.Enabled = false;
                MessageBox.Show("Xóa món ăn thành công");
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
            }
        }

        private void dgvFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
        }
    }
}

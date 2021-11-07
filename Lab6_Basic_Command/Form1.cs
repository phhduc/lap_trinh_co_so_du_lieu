using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_Basic_Command
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string connectstring = "server=RE; database=RestaurantManagement; Integrated Security =true;";
            SqlConnection sqlConnection = new SqlConnection(connectstring);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $"select ID,Name,Type from Category";
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            this.DisplayCategory(sqlDataReader);
            sqlConnection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLoad.PerformClick();
            dateTimePicker1_ValueChanged(sender, e);
        }
        private void DisplayCategory(SqlDataReader reader)
        {
            lvCategory.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["ID"].ToString());
                lvCategory.Items.Add(item);
                item.SubItems.Add(reader["Name"].ToString());
                item.SubItems.Add(reader["Type"].ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string connectstring = "server=RE; database=RestaurantManagement; Integrated Security =true;";
            SqlConnection sqlConnection = new SqlConnection(connectstring);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $"insert into Category(Name, [Type]) values (N'{txtName.Text}', {txtType.Text})";
            sqlConnection.Open();
            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if(numOfRowsEffected == 1)
            {
                MessageBox.Show("Thêm nhóm món ăn thành công");
                btnLoad.PerformClick();
                txtName.Text = "";
                txtType.Text = "";
            } else
            {
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
            }
        }

        private void lvCategory_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvCategory.SelectedItems[0];
            txtID.Text = item.Text;
            txtName.Text = item.SubItems[1].Text;
            txtType.Text=item.SubItems[2].Text;

            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectstring = "server=RE; database=RestaurantManagement; Integrated Security =true;";
            SqlConnection sqlConnection = new SqlConnection(connectstring);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $"update Category set Name = N'{txtName.Text}', [Type]={txtType.Text} where ID = {txtID.Text}";
            sqlConnection.Open();
            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if(numOfRowsEffected == 1)
            {
                ListViewItem item = lvCategory.SelectedItems[0];
                item.SubItems[1].Text = txtName.Text;
                item.SubItems[2].Text=txtType.Text;

                txtID.Text = "";
                txtName.Text = "";
                txtType.Text = "";

                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

                MessageBox.Show("Cập nhật nhóm món ăn thành công");
            }else
            {
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectstring = "server=RE; database=RestaurantManagement; Integrated Security =true;";
            SqlConnection sqlConnection = new SqlConnection(connectstring);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $"delete from Category where ID = {txtID.Text}";
            sqlConnection.Open();
            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (numOfRowsEffected == 1)
            {
                ListViewItem item = lvCategory.SelectedItems[0];
                lvCategory.Items.Remove(item);

                txtID.Text = "";
                txtName.Text = "";
                txtType.Text = "";

                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

                MessageBox.Show("Xóa nhóm món ăn thành công");
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
            }
        }

        

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            if (lvCategory.SelectedItems.Count > 0)
                btnDelete.PerformClick();
        }

        private void tsmViewFood_Click(object sender, EventArgs e)
        {
            if(txtID.Text != "")
            {
               FoodForm f = new FoodForm();
                f.Show(this);
                f.LoadFood(Convert.ToInt32(txtID.Text));
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dtp1.Value > dtp2.Value)
            {
                MessageBox.Show("Lôi nhập ngày, vui lòng nhập đúng ngày");
                return;
            }
            string d1 = (dtp1.Value.Date).ToString("dd/MM/yyyy");
            string d2 = (dtp2.Value.Date).ToString("dd/MM/yyyy");
            string s1= "convert(smalldatetime,'"+d1+"',103)";
            string s2 = "convert(smalldatetime,'"+d2+"',103)";
            string a = "server=RE;database=RestaurantManagement;Integrated Security=true;";
            SqlConnection c = new SqlConnection(a);
            SqlCommand cmd = c.CreateCommand();
            cmd.CommandText = $"set DATEFORMAT dmy; select * from Bills where CheckoutDate >={s1} and CheckoutDate <={s2}";
            c.Open();
            SqlDataAdapter d = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable(); 
            d.Fill(dt);
            dgvBill.Refresh();
            dgvBill.DataSource = dt;
            dgvBill.Columns[0].HeaderText = "ID";
            dgvBill.Columns[1].HeaderText = "Tên hóa đơn";
            dgvBill.Columns[2].HeaderText = "Bàn";
            dgvBill.Columns[3].HeaderText = "Tổng tiền";
            dgvBill.Columns[4].HeaderText = "Giảm giá";
            dgvBill.Columns[5].HeaderText = "Thuế";
            dgvBill.Columns[6].HeaderText = "Trạng thái";
            dgvBill.Columns[7].HeaderText = "Ngày";
            dgvBill.Columns[8].HeaderText = "Tài khoản";
            for (int i = 0; i < 8; i++)
                dgvBill.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvBill.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            c.Close();

        }

        private void dgvBill_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvBill.CurrentRow.Cells[0].Value.ToString();
            BillDetails f = new BillDetails();
            f.Show(this);
            f.LoadF(id);
        }

        private void LoadA1()
        {
            string a = "server=RE;database=RestaurantManagement;Integrated Security=true;";
            SqlConnection c = new SqlConnection(a);
            SqlCommand cmd = c.CreateCommand();
            cmd.CommandText = "select a.AccountName, a.Password, a.FullName, a.Email, a.Tell, a.DateCreated, r.RoleName, ra.Actived " +
                "from Role r, Account a, RoleAccount ra " +
                "where r.ID=ra.RoleID and ra.AccountName = a.AccountName";
            c.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Accounts");
            da.Fill(dt);
            dgvAccounts.DataSource = dt;
            c.Close();
            c.Dispose();
            da.Dispose();
            dgvAccounts.Columns[0].HeaderText = "Tên tài khoản";
            dgvAccounts.Columns[1].HeaderText = "Mật khẩu";
            dgvAccounts.Columns[2].HeaderText = "Tên đầy đủ";
            dgvAccounts.Columns[3].HeaderText = "Email";
            dgvAccounts.Columns[4].HeaderText = "Số điện thoại";
            dgvAccounts.Columns[5].HeaderText = "Ngày tạo tài khoản";
            dgvAccounts.Columns[6].HeaderText = "Quyền";
            dgvAccounts.Columns[7].HeaderText = "Trạng thái";
        }

        private void tc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadA1();
            LoadA2();
            LoadT1();
        }
        private List<Role> lsR;
        private void LoadA2()
        {
            string connectionString = "server=RE;database=RestaurantManagement;Integrated Security=true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = "select * from Role";
            sqlCommand.CommandText = query;
            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            lsR = new List<Role>();
            while (sqlDataReader.Read())
            {
                lsR.Add(new Role(sqlDataReader["ID"].ToString(), sqlDataReader["RoleName"].ToString()));
            }

            tdA();
        }
        public void tdA()
        {
            cbb_Group.DataSource = lsR;
            cbb_Group.DisplayMember = "RoleName";
            cbb_Group.ValueMember = "ID";
            cbb_Group.Text = "";
            cbb_role.DataSource = lsR;
            cbb_role.DisplayMember = "RoleName";
            cbb_role.ValueMember = "ID";
            cbb_role.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadA1();
            LoadA2();
            tdA();
        }

        private void dgvAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count > 0)
            {
                txt_account_name.Text = dgvAccounts.SelectedRows[0].Cells[0].Value.ToString();
                txt_password.Text = dgvAccounts.SelectedRows[0].Cells[1].Value.ToString();
                txt_fullname.Text = dgvAccounts.SelectedRows[0].Cells[2].Value.ToString();
                txt_email.Text = dgvAccounts.SelectedRows[0].Cells[3].Value.ToString();
                txt_tell.Text = dgvAccounts.SelectedRows[0].Cells[4].Value.ToString();
                if (dgvAccounts.SelectedRows[0].Cells[5].Value.ToString() != "")
                    dtp_create_Date.Value = DateTime.Parse(dgvAccounts.SelectedRows[0].Cells[5].Value.ToString());
                else dtp_create_Date.Value = DateTime.Now;
                cbb_role.Text = dgvAccounts.SelectedRows[0].Cells[6].Value.ToString();
                cbb_stt.Text = dgvAccounts.SelectedRows[0].Cells[7].Value.ToString()== "true"? "Actived" : "Nonactived";
                
            }
        }
        public void clA()
        {
            txt_account_name.Text = "";
            txt_fullname.Text = "";
            txt_password.Text = "";
            txt_email.Text = "";
            txt_tell.Text = "";
            cbb_role.Text = "";
            cbb_stt.Text = "";
            dtp_create_Date.Value = DateTime.Now;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clA();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string connectionString = "server=RE;database=RestaurantManagement;Integrated Security=true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string role_id = lsR.Find(s => s.RoleName == cbb_role.Text).ID;
            string stt = cbb_stt.Text == "Actived" ? "1" : "0";

            sqlCommand.CommandText = "select * from Account where AccoutName = '" + txt_account_name.Text + "'";
            sqlConnection.Open();

            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable("Accounts");
            da.Fill(dt);
            if (dt.Rows.Count <= 0)
            {
                sqlCommand.CommandText = "insert into Account(AccoutName, Password, FullName, Email, Tell, DateCreated) values " +
                   "(N'" + txt_account_name.Text + "', N'" + txt_password.Text + "', N'" + txt_fullname.Text + "', N'" + txt_email.Text + "'," +
                   "'" + txt_tell.Text + "', '" + dtp_create_Date.Value.Date.ToString() + "')";
                sqlCommand.ExecuteNonQuery();
                sqlCommand.CommandText = "insert into RoleAccount(RoleID, AccountName, Actived) values " +
                    "('" + role_id + "', N'" + txt_account_name.Text + "', '" + stt + "')";
                int num = sqlCommand.ExecuteNonQuery();
                if (num == 1)
                {
                    MessageBox.Show("Thêm tài khoản thành công!");
                    LoadA1();
                    clA();
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản không thành công!");
                }

            }
            else
            {
                sqlCommand.CommandText = "Update Account set Password = N'" + txt_password.Text + "', FullName = N'" + txt_fullname.Text + "', " +
                    "Email = '" + txt_email.Text + "', Tell = '" + txt_tell.Text + "', DateCreated='" + dtp_create_Date.Value.Date.ToString() + "' " +
                    "where AccoutName = '" + txt_account_name.Text + "'";
                sqlCommand.ExecuteNonQuery();
                sqlCommand.CommandText = "Update RoleAccount set Actived = '" + stt + "' where RoleID = '" + role_id + "' and AccountName = '" + txt_account_name.Text + "'";
                int num2 = sqlCommand.ExecuteNonQuery();
                if (num2 == 1)
                {
                    MessageBox.Show("Cập nhật tài khoản không thành công!");
                    LoadA1();
                    clA();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin không thành công!");
                }

            }
        }

        private void btn_Change_pasword_Click(object sender, EventArgs e)
        {
            ResetPass f = new ResetPass(txt_account_name.Text, txt_password.Text) ;
            f.Show();
            
        }

        private void tmsDelA_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count <= 0) return;
            SqlConnection c = new SqlConnection("server:RE;database=RestaurantManagement;Integrated Security:true;");
            SqlCommand cmd = c.CreateCommand();
            string id = lsR.Find(sss => sss.RoleName == dgvAccounts.SelectedRows[0].Cells[6].Value.ToString()).ID;
            cmd.CommandText = $"update RoleAccount set Actived='false' where AccountName = '{txt_account_name}' and RoleID='{id}'";
            c.Open();
            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Xóa tài khoản thành công");
                LoadA1();
                clA();
            }
            else MessageBox.Show("Xóa tài khoản thất bại, vui lòng thử lại");
        }

        private void tmsViewDetailA_Click(object sender, EventArgs e)
        {
            RoleAccount f = new RoleAccount();
            f.Show();
            f.LoadF(txt_account_name.Text);
        }
        public void LoadT1()
        {
            string connectstring = "server=RE; database=RestaurantManagement; Integrated Security =true;";
            SqlConnection sqlConnection = new SqlConnection(connectstring);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "select * from DiningTable";
            sqlConnection.Open();

            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable("Tables");
            da.Fill(dt);
            dgvTable.DataSource = dt;
            sqlConnection.Close();
            sqlConnection.Dispose();
            da.Dispose();

            dgvTable.Columns[0].HeaderText = "Mã bàn";
            dgvTable.Columns[1].HeaderText = "Tên bàn";
            dgvTable.Columns[2].HeaderText = "Trạng thái";
            dgvTable.Columns[3].HeaderText = "Số chổ ngồi";
        }
    }
}

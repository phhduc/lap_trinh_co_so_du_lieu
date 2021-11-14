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
    public partial class AccountFoirm : Form
    {
        public AccountFoirm()
        {
            InitializeComponent();
        }
        public void DataCombobox()
        {
            SqlConnection conn = new SqlConnection(env.sqlconnectString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select ID, RoleName from Role";
            conn.Open();
            SqlDataAdapter a = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            a.Fill(dt);
            conn.Close();
            conn.Dispose();
            a.Dispose();
            cbRole.DataSource = dt;
            cbRole.DisplayMember = "RoleName";
            cbRole.ValueMember = "ID";
            cbRole.SelectedIndex = -1;
            cbActive.DataSource = new List<String>() { "none active", "actived" };
            cbActive.SelectedIndex = -1;
        }

        private void AccountFoirm_Load(object sender, EventArgs e)
        {
            LoadList();
            DataCombobox();
        }
        private void LoadList()
        {
            dgvAccount.Refresh();
            SqlConnection connect = new SqlConnection(env.sqlconnectString);
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "select a.AccountName, FullName, Email, RoleName, Actived from Account as a join RoleAccount as b on a.AccountName=b.AccountName join Role as c on b.RoleID=c.ID";
            connect.Open();
            SqlDataAdapter a = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            a.Fill(dt);
            connect.Close();
            connect.Dispose();
            a.Dispose();
            dgvAccount.DataSource = dt;
            dgvAccount.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvAccount.Columns[dgvAccount.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = (dgvAccount.SelectedRows[0].Cells[0].Value.ToString());
            string role = dgvAccount.SelectedRows[0].Cells[3].Value.ToString();
            SqlConnection connect = new SqlConnection(env.sqlconnectString);
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "select a.AccountName, FullName, Email, DateCreated, RoleID, Actived, Tell from Account as a join RoleAccount as b on a.AccountName=b.AccountName join Role as c on b.RoleID=c.ID where a.AccountName=@name and c.RoleName=@role";
            cmd.Parameters.Add("@name", SqlDbType.NVarChar, 100);
            cmd.Parameters.Add("@role", SqlDbType.NVarChar, 1000); 
            cmd.Parameters["@name"].Value = name;
            cmd.Parameters["@role"].Value = role;
            connect.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtUserName.Text = reader["AccountName"].ToString();
                txtFullName.Text = reader["FullName"].ToString();
                txtEmail.Text = reader["Email"].ToString();
                cbRole.SelectedIndex = Convert.ToInt32(reader["RoleID"])-1;
                if (reader["Actived"].ToString() == "True")
                    cbActive.SelectedIndex = 1;
                else cbActive.SelectedIndex = 0;
                if(!reader.IsDBNull(reader.GetOrdinal("DateCreated"))) dtpCreate.Value=DateTime.Parse(reader["DateCreated"].ToString());
                if (!reader.IsDBNull(reader.GetOrdinal("Tell"))) mktTell.Text= reader["Tell"].ToString();
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //create procedure[insertAccount]
            //@username nvarchar(100),
            //@fullname nvarchar(1000),
            //@email nvarchar(1000),
            //@tell nvarchar(200),
            //@datecreated smalldatetime,
            //@roleid int,
            //@actived bit
            //as
            //insert into[Account] values(@username, N'password', @fullname, @email, @tell, @datecreated)
            //insert into[RoleAccount] values(@roleid, @username, @actived, null)
            //if @@ERROR <> 0
            //return 0
            //else return 1
            //go
            try
            {
                SqlConnection connect = new SqlConnection(env.sqlconnectString);
                SqlCommand cmd = connect.CreateCommand();
                cmd.CommandText = "execute insertAccount @username, @fullname, @email, @tell, @datecreated, @roleid, @actived";
                cmd.Parameters.Add("@username", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@fullname", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@email", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@tell", SqlDbType.NVarChar, 200);
                cmd.Parameters.Add("@datecreated", SqlDbType.SmallDateTime);
                cmd.Parameters.Add("@roleid", SqlDbType.Int);
                cmd.Parameters.Add("@actived", SqlDbType.Bit);
                cmd.Parameters["@username"].Value = txtUserName.Text;
                cmd.Parameters["@fullname"].Value = txtFullName.Text;
                cmd.Parameters["@email"].Value = txtFullName.Text;
                cmd.Parameters["@tell"].Value = mktTell.Text;
                cmd.Parameters["@datecreated"].Value = dtpCreate.Value;
                cmd.Parameters["@roleid"].Value = cbRole.SelectedIndex + 1;
                cmd.Parameters["@actived"].Value = cbActive.SelectedIndex;
                connect.Open();
                int num = cmd.ExecuteNonQuery();
                connect.Close();
                connect.Dispose();
                if (num > 0)
                {
                    MessageBox.Show("Successfully");
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //            create procedure[updateAccount]
            //@username nvarchar(100),
            //@fullname nvarchar(1000),
            //@email nvarchar(1000),
            //@tell nvarchar(200),
            //@datecreated smalldatetime,
            //@roleid int,
            //@actived bit
            //as
            //update Account
            //set
            //    [FullName] = @fullname,

            //    [Email] = @email,

            //    [Tell] = @tell,

            //    [DateCreated] = @datecreated
            //where AccountName = @username
            //update RoleAccount
            //set RoleID = @roleid,
            //Actived = @actived
            //where AccountName = @username
            //if @@ERROR <> 0
            //return 0
            //else return 1
            //go
            try
            {
                SqlConnection conn = new SqlConnection(env.sqlconnectString);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "execute updateAccount @username, @fullname, @email, @tell, @datecreated, @roleid, @active";
                cmd.Parameters.Add("@username", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@fullname", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@email", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@tell", SqlDbType.NVarChar, 200);
                cmd.Parameters.Add("@datecreated", SqlDbType.SmallDateTime);
                cmd.Parameters.Add("@roleid", SqlDbType.Int);
                cmd.Parameters.Add("@active", SqlDbType.Bit);
                cmd.Parameters["@username"].Value = txtUserName.Text;
                cmd.Parameters["@fullname"].Value = txtFullName.Text;
                cmd.Parameters["@email"].Value = txtEmail.Text;
                cmd.Parameters["@tell"].Value = mktTell.Text;
                cmd.Parameters["@datecreated"].Value = dtpCreate.Value;
                cmd.Parameters["@roleid"].Value = cbRole.SelectedIndex + 1;
                cmd.Parameters["@active"].Value = cbActive.SelectedIndex;
                conn.Open();
                int num = cmd.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                if (num > 0)
                {
                    MessageBox.Show("succesfully");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            LoadList();
        }

        private void xemNhậtKýHoạtĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Details f = new Details();
            f.Show(this);
            f.LoadListBox(dgvAccount.SelectedRows[0].Cells[0].Value.ToString());
        }
    }
}

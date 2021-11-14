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
    public partial class FoodInfoForm : Form
    {
        public FoodInfoForm()
        {
            InitializeComponent();
        }
        private void FoodInfoForm_Load(object sender, EventArgs e)
        {
            IntiValues();
        }
        private void IntiValues()
        {
            SqlConnection sqlConnect = new SqlConnection(env.sqlconnectString);
            SqlCommand cmd = sqlConnect.CreateCommand();
            cmd.CommandText = "Select ID, Name From Category";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sqlConnect.Open();
            adapter.Fill(ds,"Category");
            cbbCaName.DataSource = ds.Tables["Category"];
            cbbCaName.DisplayMember = "Name";
            cbbCaName.ValueMember = "ID";
            sqlConnect.Close();
            sqlConnect.Dispose();
        }
        private void ResetText()
        {
            txtID.ResetText();
            txtName.ResetText();
            txtNotes.ResetText();
            txtUnit.ResetText();
            cbbCaName.ResetText();
            nudPrice.ResetText();
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            try
           
            {
                SqlConnection sqlConnect = new SqlConnection(env.sqlconnectString);
                SqlCommand cmd = sqlConnect.CreateCommand();
                cmd.CommandText = "execute insertFood @id output, @name, @unit,@foodCategoryID,@price, @notes";
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@unit", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@foodCategoryID", SqlDbType.Int);
                cmd.Parameters.Add("@price", SqlDbType.Int);
                cmd.Parameters.Add("@notes", SqlDbType.NVarChar, 3000);
                cmd.Parameters["@id"].Direction = ParameterDirection.Output;
                cmd.Parameters["@name"].Value = txtName.Text;
                cmd.Parameters["@unit"].Value = txtUnit.Text;
                cmd.Parameters["@foodCategoryID"].Value = cbbCaName.SelectedValue;
                cmd.Parameters["@price"].Value = nudPrice.Value;
                cmd.Parameters["@notes"].Value = txtNotes.Text;
                sqlConnect.Open();
                int num = cmd.ExecuteNonQuery();
                if (num > 0)
                {
                    string foodID = cmd.Parameters["@id"].Value.ToString();
                    MessageBox.Show($"Successfully adding new food, FoodID = {foodID}", "Message");
                    this.ResetText();
                }
                else
                {
                    MessageBox.Show("Adding food failed");
                }
                sqlConnect.Close();
                sqlConnect.Dispose();
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "SQL err");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
           
        }
        public void DisplayFoodInfo(DataRowView rowView)
        {
            try
            {
                txtID.Text = rowView["ID"].ToString();
                txtName.Text=rowView["Name"].ToString();
                txtUnit.Text=rowView["Unit"].ToString();
                txtNotes.Text = rowView["Notes"].ToString();
                nudPrice.Value = Convert.ToInt32(rowView["Price"].ToString());
                cbbCaName.SelectedIndex = -1;
                for(int i = 0; i < cbbCaName.Items.Count; i++)
                {
                    DataRowView ca = cbbCaName.Items[i] as DataRowView;
                    if(ca["ID"].ToString() == rowView["ID"].ToString())
                    {
                        cbbCaName.SelectedIndex = i;
                        break;
                    }
                }
            }
            catch (Exception exception){
                MessageBox.Show(exception.Message, "Error");
                this.Close();
            }
        }

        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnect = new SqlConnection(env.sqlconnectString);
                SqlCommand cmd = sqlConnect.CreateCommand();
                cmd.CommandText = "execute updateFood @id, @name, @unit, @foodCategoryID,@price,@notes";
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@unit", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@foodCategoryID", SqlDbType.Int);
                cmd.Parameters.Add("@price", SqlDbType.Int);
                cmd.Parameters.Add("@notes", SqlDbType.NVarChar, 3000);

                cmd.Parameters["@id"].Value = txtID.Text;
                cmd.Parameters["@name"].Value = txtName.Text;
                cmd.Parameters["@unit"].Value = txtUnit.Text;
                cmd.Parameters["@foodCategoryID"].Value = cbbCaName.Text;
                cmd.Parameters["@price"].Value = nudPrice.Value;
                cmd.Parameters["@notes"].Value = txtNotes.Text;
                sqlConnect.Open();
                int num = cmd.ExecuteNonQuery();
                if (num > 0)
                {
                    MessageBox.Show($"Successfully updating food", "Message");
                    this.ResetText();
                }
                else
                {
                    MessageBox.Show("Updating food failed");
                }
                sqlConnect.Close();
                sqlConnect.Dispose();
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "SQL err");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddCategory f = new AddCategory();
            f.Show();
            f.FormClosed += F_FormClosed;
        }

        private void F_FormClosed(object sender, FormClosedEventArgs e)
        {
            IntiValues();
        }
    }
}

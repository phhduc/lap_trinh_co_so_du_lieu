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
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
        }
        //        create procedure[insertCategory]
        //@id int output,
        //@name nvarchar(1000),
        //@type int
        //as
        //insert into[Category]([Name], [Type])
        //values(@name, @type)
        //select @id = SCOPE_IDENTITY()
        //go



        private void btnOK_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int type = (int)nudType.Value;
            SqlConnection sqlConnect = new SqlConnection(env.sqlconnectString);
            SqlCommand cmd = sqlConnect.CreateCommand();
            cmd.CommandText = "execute insertCategory @id output, @name,@type";
            cmd.Parameters.Add("@id", SqlDbType.Int);
            cmd.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
            cmd.Parameters.Add("@type", SqlDbType.Int);
            cmd.Parameters["@id"].Direction = ParameterDirection.Output;
            cmd.Parameters["@name"].Value = txtName.Text;
            cmd.Parameters["@type"].Value = nudType.Value;
            sqlConnect.Open();
            try
            { 
                
                int num = cmd.ExecuteNonQuery();
                if (num > 0)
                {
                    string id = cmd.Parameters["@id"].Value.ToString();
                    MessageBox.Show($"Successfully adding category, ID = {id}", "message");
                }
                else
                {
                    MessageBox.Show("Adding failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            sqlConnect.Close();
            sqlConnect.Dispose();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Demo
{
    public partial class Input : Form
    {
        object a;
        public Input(object s)
        {
            InitializeComponent();
            a = s;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            a = txtInput.Text;
            this.Close();
        }
    }
}

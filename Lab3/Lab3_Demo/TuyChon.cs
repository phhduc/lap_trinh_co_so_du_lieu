using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Demo.Data
{
    public partial class TuyChonForm : Form
    {
        private bool ss = false;
        public TuyChonForm()
        {
            InitializeComponent();
        }
        public TuyChonForm(bool x)
        {
            ss = x;
        }

        private void TuyChonForm_Load(object sender, EventArgs e)
        {
            if (ss)
            {
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                textBox1.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}

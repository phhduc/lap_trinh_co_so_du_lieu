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
        public string Tk { get; set; }
        public int SS { get; set; }
        public TuyChonForm()
        {
            InitializeComponent();
        }
        public TuyChonForm(bool x)
        {
            ss = x;
            InitializeComponent();
        }

        private void TuyChonForm_Load(object sender, EventArgs e)
        {
            if (ss)
            {
                
                textBox1.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
            {
                SS = 1;
            }
            else if (this.radioButton2.Checked)
            {
                SS = 2;

            }
            else if (this.radioButton3.Checked)
            {
                SS = 3;

            }
            this.Tk = textBox1.Text;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(this.radioButton1.Checked)
            {
                SS = 1;
                this.Close();
            }
            else if(this.radioButton2.Checked)
            {
                SS = 2;
                this.Close();
            }
            else if (this.radioButton3.Checked)
            {
                SS = 3;
                this.Close();
            }
            this.Close();
        }
    }
}

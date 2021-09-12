using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bttuan3.Components
{
    public partial class NewControl : UserControl
    {
        public NewControl()
        {
            InitializeComponent();
        }
        public void SetArticle(Article news)
        {
            lblTitle.Text = news.Title;
            lblDescription.Text = news.Description;
            lblPubDate.Text = news.PublishedDate.ToString("dd/MM/yyyy HH:mm");
            
            lblDetail.LinkClicked += (sender, args) =>
            {
                Process.Start(news.Link);
            };
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawRectangle(Pens.Black, 0, 1, Width - 1, Height - 2);
        }
    }
}

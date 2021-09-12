using bttuan3.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bttuan3
{
    public partial class MainForm : Form
    {
        public readonly NewsFeedManager _newsManager;
        public MainForm(NewsFeedManager newsManger)
        {
            _newsManager = newsManger;
            InitializeComponent();
            ShowFeedOnTreeView(_newsManager.GetNewsFeed());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var dialog = new AddFeedForm(_newsManager);
            dialog.ShowDialog(this);
            if (dialog.HasChanges)
            {
                _newsManager.SaveChanged();
                ShowFeedOnTreeView(_newsManager.GetNewsFeed());
            }

        }

        private void bntRemove_Click(object sender, EventArgs e)
        {
            if (tvwPublisher.SelectedNode == null) return;
            if (tvwPublisher.SelectedNode.Level == 0)
            {
                _newsManager.RemovePublisher(tvwPublisher.SelectedNode.Text);
            }
            else
            {
                var pN = tvwPublisher.SelectedNode.Parent;
                _newsManager.RemoveCategory(pN.Text, tvwPublisher.SelectedNode.Text);
            }
            tvwPublisher.SelectedNode.Remove();
        }

        private void tvwPublisher_AfterSelect(object sender, TreeViewEventArgs e)
        {
            pnNews.Controls.Clear();
            if (e.Node.Level == 1)
            {
                var articles = _newsManager.GetNews(e.Node.Parent.Text, e.Node.Text);
                foreach(var article in articles)
                {
                    var item = new NewControl();
                    item.Size = new Size(500, 100);
                    item.Dock = DockStyle.Top;
                    item.SetArticle(article);
                    pnNews.Controls.Add(item);
                }
            }

        }
        private void ShowFeedOnTreeView(List<Publisher> publishers)
        {
            tvwPublisher.Nodes.Clear();
            pnNews.Controls.Clear();
            foreach(var p in publishers)
            {
                var pNode = tvwPublisher.Nodes.Add(p.Name);
                foreach(var c in p.Categories)
                {
                    pNode.Nodes.Add(c.Name);
                }
            }
            tvwPublisher.ExpandAll();
        }
    }
}

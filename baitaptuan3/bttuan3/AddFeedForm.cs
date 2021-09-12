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
    public partial class AddFeedForm : Form
    {
        public readonly NewsFeedManager _newManager;
        public bool HasChanges { get; set; }

        public AddFeedForm(NewsFeedManager newManager)
        {
            _newManager = newManager;
            InitializeComponent();
        }

        private void AddFeedForm_Load(object sender, EventArgs e)
        {
            var publishers = _newManager.GetNewsFeed();
            foreach(var p in publishers)
            {
                cbbPublishers.Items.Add(p.Name);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var pName = cbbPublishers.Text;
            var cName = txtCategoryName.Text;
            var rssl = txtRssLink.Text;
            if(string.IsNullOrWhiteSpace(pName) || 
                string.IsNullOrWhiteSpace(cName) ||
                string.IsNullOrWhiteSpace(rssl))
            {
                MessageBox.Show("Bạn phải nhập đủ dữ liệu", "Lỗi");
                return;
            }
            HasChanges = true;
            var success = _newManager.AddCategory(pName, cName, rssl, false);
            if (success)
            {
                ClearForm();
                return;
            }
            if(MessageBox.Show("Chuyên mục này đã tồn tại, bạn có muốn cập nhật RSS Link không?","Thông báo", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                _newManager.AddCategory(pName, cName, rssl, true);
            }
            ClearForm();
        }

        private void ClearForm()
        {
            cbbPublishers.Text = "";
            txtCategoryName.Text = "";
            txtRssLink.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

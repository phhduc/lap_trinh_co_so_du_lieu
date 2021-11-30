using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using BusinessLogic;
namespace Lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadCategory();
            LoadFoodDataToListView();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private List<Category> listCategory = new List<Category>();
        private List<FoodRecord> listFood = new List<FoodRecord>();
        private FoodRecord foodCurrent = new FoodRecord();

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtUnit.Text = "";
            txtPrice.Text = "";
            txtNotes.Text = "";
            if(cbbCategory.Items.Count>0)
                cbbCategory.SelectedIndex = 0;
        }

        public void LoadCategory()
        {
            CategoryBL categoryBL = new CategoryBL();
            listCategory = categoryBL.GetAll();
            cbbCategory.DataSource = listCategory;
            cbbCategory.ValueMember = "ID";
            cbbCategory.DisplayMember = "Name";
        }
        public void LoadFoodDataToListView()
        {
            FoodBL foodBL = new FoodBL();
            listFood = foodBL.GetAll();
            int count = 1;
            lvFood.Items.Clear();
            foreach(var food in listFood)
            {
                ListViewItem item = lvFood.Items.Add(count.ToString());
                item.SubItems.Add(food.Name);
                item.SubItems.Add(food.Unit);
                item.SubItems.Add(food.Price.ToString());
                string foodName = listCategory.Find(x=>x.ID == food.FoodCategoryID).Name;
                item.SubItems.Add(foodName);
                item.SubItems.Add(food.Notes);
                count++;
            }
        }

        private void lvFood_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < lvFood.Items.Count; i++)
            {
                if (lvFood.Items[i].Selected)
                {
                    foodCurrent = listFood[i];
                    txtName.Text = foodCurrent.Name;
                    txtUnit.Text = foodCurrent.Unit;
                    txtPrice.Text = foodCurrent.Price.ToString();
                    txtNotes.Text = foodCurrent.Notes;
                    cbbCategory.SelectedIndex = listCategory.FindIndex(x =>x.ID == foodCurrent.FoodCategoryID);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int result = InsertFood();
            if (result > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công");
                LoadFoodDataToListView();
            }
            else
                MessageBox.Show("Thêm dữ liệu không thành công. Vui lòng kiểm tra lại dữ liệu đã nhập");
        }
        public int InsertFood()
        {
            FoodRecord food = new FoodRecord();
            food.ID = 0;
            if (txtName.Text == "" || txtUnit.Text == "" || txtPrice.Text == "")
                MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập lại");
            else
            {
                food.Name = txtName.Text;
                food.Unit = txtUnit.Text;
                food.Notes = txtNotes.Text;
                int price = 0;
                try
                {
                    price = int.Parse(txtPrice.Text);
                }
                catch
                {
                    price = 0;
                }
                food.Price = price;
                food.FoodCategoryID = 1;
                food.FoodCategoryID += int.Parse(cbbCategory.SelectedIndex.ToString());
                FoodBL foodBL = new FoodBL();
                return foodBL.Insert(food);
            }
            return -1;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn xóa món ăn này", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                FoodBL foodBL = new FoodBL();
                if (foodBL.Delete(foodCurrent) > 0)
                {
                    MessageBox.Show("Xóa thực phẩm thành công");
                    LoadFoodDataToListView();
                }
                else MessageBox.Show("Xóa không thành công");
            }
        }
        public int UpdateFood()
        {
            FoodRecord food = foodCurrent;
            if (txtName.Text == "" || txtUnit.Text == "" || txtPrice.Text == "")
                MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập lại");
            else
            {
                food.Name = txtName.Text;
                food.Unit = txtUnit.Text;
                food.Notes = txtPrice.Text;
                int price = 0;
                try
                {
                    price= int.Parse(txtPrice.Text);
                } catch {
                    price = 0; 
                }
                food.Price = price;
                food.FoodCategoryID=int.Parse(cbbCategory.SelectedValue.ToString());
                FoodBL foodBl = new FoodBL();
                return foodBl.Update(food);
            }
            return -1;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int result = UpdateFood();
            if (result > 0)
            {
                MessageBox.Show("Cập nhật dữ liệu thành công");
                LoadFoodDataToListView();
            }
            else MessageBox.Show("Cập nhật dữ liệu không thành công, vui lòng kiểm tra lại dữ liệu");
        }
    }
}

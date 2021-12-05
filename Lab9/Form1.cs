using Lab9.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9
{
    public partial class Form1 : Form
    {
        private RestaurantContext _context;
        public Form1()
        {
            _context = new RestaurantContext();
            InitializeComponent();
        }
        //-----------------------------
        private List<Category> GetCategories()
        {
            RestaurantContext context = new RestaurantContext();
            return context.Categories.OrderBy(c => c.Name).ToList();
        }
        private void ShowCategories()
        {
            tvwCategory.Nodes.Clear();
            var cateMap = new Dictionary<CategoryType, string>()
            {
                [CategoryType.Food] = "Đồ ăn",
                [CategoryType.Drink] = "Thức uống"
            };
            var rootNode = tvwCategory.Nodes.Add("Tất cả");
            var categories = GetCategories();
            foreach(var cateType in cateMap)
            {
                var childNode = rootNode.Nodes.Add(cateType.Key.ToString(), cateType.Value);
                childNode.Tag = cateType.Key;
                foreach(var category in categories)
                {
                    if (category.Type != cateType.Key) continue;
                    var grantChildNode = childNode.Nodes.Add(category.Id.ToString(), category.Name);
                    grantChildNode.Tag = category;
                }
            }
            tvwCategory.ExpandAll();
            tvwCategory.SelectedNode = rootNode;
        }
        private List<FoodModel> GetFoodByCategory(int? categoryId)
        {
            var foods = _context.Foods.AsQueryable();
            if(categoryId!=null && categoryId > 0)
            {
                foods = foods.Where(x => x.FoodCategoryId == categoryId);
            }
            return foods.OrderBy(x => x.Name).Select(x => new FoodModel()
            {
                Id = x.Id,
                Name = x.Name,
                Unit = x.Unit,
                Price = x.Price,
                Notes = x.Notes,
                CategoryName = x.Category.Name
            }).ToList();
        }
        private List<FoodModel> GetFoodByCategoryType(CategoryType categoryType)
        {
            return _context.Foods.Where(x => x.Category.Type == categoryType)
                .OrderBy(x => x.Name).Select(x => new FoodModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Unit = x.Unit,
                    Price = x.Price,
                    Notes = x.Notes,
                    CategoryName = x.Category.Name
                }).ToList();
        }
        private void ShowFoodsForNode(TreeNode node)
        {
            lvwFood.Items.Clear();
            if (node == null) return;
            List<FoodModel> foods = null;
            if(node.Level == 1)
            {
                var cateType = (CategoryType)node.Tag;
                foods = GetFoodByCategoryType(cateType);
            }
            else
            {
                var category = node.Tag as Category;
                foods = GetFoodByCategory(category?.Id);
            }
            ShowFoodsOnListView(foods);
        }
        private void ShowFoodsOnListView(List<FoodModel> foods)
        {
            foreach(var foodItem in foods)
            {
                var item = lvwFood.Items.Add(foodItem.Id.ToString());
                item.SubItems.Add(foodItem.Name);
                item.SubItems.Add(foodItem.Unit);
                item.SubItems.Add(foodItem.Price.ToString("##,###"));
                item.SubItems.Add(foodItem.CategoryName);
                item.SubItems.Add(foodItem.Notes);
            }
        }

        //-----------------------------

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowCategories();
        }

        private void btnReloadCategory_Click(object sender, EventArgs e)
        {
            ShowCategories();
        }

        private void tvwCategory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ShowFoodsForNode(e.Node);
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            var dialog = new CategoryForm();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                ShowCategories();
            }
        }

        private void tvwCategory_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node == null || e.Node.Level < 2 || e.Node.Tag == null) return;
            var category = e.Node.Tag as Category;
            var dialog = new CategoryForm(category?.Id);
            if(dialog.ShowDialog(this) == DialogResult.OK)
            {
                ShowCategories();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ShowFoodsForNode(tvwCategory.SelectedNode);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lvwFood.SelectedItems.Count ==0) return;
            var selectedFoodId = int.Parse(lvwFood.SelectedItems[0].Text);
            var selectedFood = _context.Foods.Find(selectedFoodId);
            if (selectedFood != null)
            {
                _context.Foods.Remove(selectedFood);
                _context.SaveChanges();

                lvwFood.Items.Remove(lvwFood.SelectedItems[0]);
            }

        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            var dialog = new FoodForm();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                ShowFoodsForNode(tvwCategory.SelectedNode);
            }
        }

        private void lvwFood_DoubleClick(object sender, EventArgs e)
        {
            if (lvwFood.SelectedItems.Count == 0) return;
            var foodId = int.Parse(lvwFood.SelectedItems[0].Text);
            var dialog = new FoodForm(foodId);
            if(dialog.ShowDialog(this) == DialogResult.OK)
            {
                ShowFoodsForNode(tvwCategory.SelectedNode);
            }
        }
    }
}


using System;
using System.Windows.Forms;
namespace wb
{

    
    public partial class UserForm : Form
    {
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadProducts(txtSearch.Text.Trim());
        }

        private void LoadProducts(string search = "")
        {
            flowProducts.Controls.Clear();

            var adapter = new WBDataSetTableAdapters.ProductsTableAdapter();
            var products = adapter.GetData();

            foreach (var product in products)
            {
                if (product.IsActive &&
                    product.Name.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    ProductCard card = new ProductCard();

                    card.SetProduct(
                        product.ProductID,
                        product.Name,
                        product.IsDescriptionNull() ? "" : product.Description,
                        product.Price,
                        product.StockQuantity,
                        product.IsImagePathNull() ? "" : product.ImagePath
                    );

                    flowProducts.Controls.Add(card);
                }
            }
        }
        public UserForm()
        {
            InitializeComponent();
        }

        private void productCard5_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            LoadProducts(txtSearch.Text.Trim());
        }

        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadProducts(txtSearch.Text.Trim());
                e.SuppressKeyPress = true;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
          
            LoadProducts();
        }


        private void ShowPage(Panel page)
        {
            panelHome.Visible = false;
            //panelCategories.Visible = false;
            panelFavorites.Visible = false;
            //panelCart.Visible = false;
            panelProfile.Visible = false;

            page.Visible = true;
            page.BringToFront();
        }
        private void flowProducts_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

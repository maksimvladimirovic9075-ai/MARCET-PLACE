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

        private void AddFavorite(int productId)
        {
            var adapter = new WBDataSetTableAdapters.FavoritesTableAdapter();

            adapter.AddFavorite(
                currentUserId.ToString(),
                productId.ToString()
            );

            MessageBox.Show("Товар добавлен в избранное!");
        }
        private void AddCart(int productId)
        {
            var adapter = new WBDataSetTableAdapters.CartTableAdapter();

            int updated = adapter.IncreaseCartItem(
                currentUserId,
                productId
            );

            if (updated == 0)
            {
                adapter.InsertCartItem(
                    currentUserId.ToString(),
                    productId.ToString()
                );
            }

            MessageBox.Show("Товар добавлен в корзину!");
        }
        private void LoadProfile()
        {
            var adapter = new WBDataSetTableAdapters.UsersTableAdapter();

            var users = adapter.GetUserById(currentUserId);

            if (users.Rows.Count > 0)
            {
                var user = users.Rows[0];

                lblProfileName.Text = "Имя: " + user["Name"].ToString();
                lblProfileEmail.Text = "Email: " + user["Email"].ToString();
                lblProfileRole.Text = "Роль: Покупатель";
            }
        }

        private void LoadProductsByCategory(int categoryId)
        {
            flowProducts.Controls.Clear();

            var adapter = new WBDataSetTableAdapters.ProductsTableAdapter();

            var products = adapter.GetProductsByCategory(categoryId);

            foreach (var product in products)
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

                card.FavoriteClicked += (s, e) => AddFavorite(card.ProductID);
                card.BuyClicked += (s, e) => AddCart(card.ProductID);

                flowProducts.Controls.Add(card);
            }
        }

        private int currentUserId;
        public UserForm(int userUd)
        {
            InitializeComponent();
            currentUserId = userUd;
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
            ShowPage(panelHome);
            LoadProducts();
        }
        private void ShowPage(Panel page)
        {
            panelHome.Visible = false;
            panelCategories.Visible = false;
            panelFavorites.Visible = false;
            panelCart.Visible = false;
            panelProfile.Visible = false;

            page.Visible = true;
            page.BringToFront();
        }
        private void UserForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
            ShowPage(panelHome);
        }
        private void btnCategories_Click(object sender, EventArgs e)
        {
            ShowPage(panelCategories);
        }
        private void btnFavorites_Click(object sender, EventArgs e)
        {
            ShowPage(panelFavorites);
        }
        private void btnCart_Click(object sender, EventArgs e)
        {
            ShowPage(panelCart);
        }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            LoadProfile();
            ShowPage(panelProfile);
        }
        private void btnElectronucs_Click(object sender, EventArgs e)
        {
            LoadProductsByCategory(1);
            ShowPage(panelHome);
        }
        private void btnClothes_Click(object sender, EventArgs e)
        {
            LoadProductsByCategory(2);
            ShowPage(panelHome);
        }
        private void btnShoes_Click(object sender, EventArgs e)
        {
            LoadProductsByCategory(3);
            ShowPage(panelHome);
        }
        private void btnHomeGoods_Click(object sender, EventArgs e)
        {
            LoadProductsByCategory(4);
            ShowPage(panelHome);
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form loginForm = Application.OpenForms["Form1"];

            if (loginForm != null)
            {
                loginForm.Show();
                loginForm.Activate();
            }

            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wb
{
    public partial class ProductCard : UserControl
    {
        public int ProductID;

        public ProductCard()
        {
            InitializeComponent();
        }

        public void SetProduct(int id, string name, string description,
                       decimal price, int stock, string imagePath)
        {
            ProductID = id;

            lblProductName.Text = name;
            lblDescription.Text = description;
            lblPrice.Text = price.ToString("N0") + " ₽";
            lblStock.Text = "В наличии: " + stock + " шт.";

            btnBuy.Enabled = stock > 0;

            if (stock == 0)
            {
                lblStock.Text = "Нет в наличии";
                btnBuy.Text = "Нет в наличии";
            }
            else
            {
                btnBuy.Text = "В корзину";
            }

            // Загружаем фотографию товара
            string file = Path.Combine(Application.StartupPath, "Images", imagePath ?? "");

            if (!string.IsNullOrEmpty(imagePath) && File.Exists(file))
            {
                picProduct.ImageLocation = file;
            }
            else
            {
                picProduct.ImageLocation = null;
                picProduct.Image = null;
            }
        }
    }
}

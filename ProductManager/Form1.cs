using Microsoft.Data.SqlClient;

namespace ProductManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReloadAllProducts();
        }

        /// <summary>
        /// This clears and reloads all the products into 
        /// the listbox
        /// </summary>
        private void ReloadAllProducts()
        {
            lstProducts.Items.Clear(); // Clear existing items

			List<Classes.Product> allProducts = ProductDb.GetAllProducts();

            // Add each product to listbox
            foreach (Classes.Product p in allProducts)
            {
                lstProducts.Items.Add(p);
            }
        }

        private void btnOpenCreateForm_Click(object sender, EventArgs e)
        {
            AddProductForm newProForm = new AddProductForm();
            newProForm.ShowDialog();

            ReloadAllProducts(); // Refresh product list after adding new product
		}

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            // If no product is selected, tell user and return immediately
            if (lstProducts.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
			}
            
            Classes.Product selectedProd = lstProducts.SelectedItem as Classes.Product;

            ProductDb.DeleteProduct(selectedProd);
            ReloadAllProducts(); // Refresh product list

			MessageBox.Show($"Product {selectedProd.Name} deleted.");
		}
    }
}

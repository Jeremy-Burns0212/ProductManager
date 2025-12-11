using Microsoft.Data.SqlClient;

namespace ProductManager
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
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

        public void btnUpdateProduct_Click(object sender, EventArgs e)
        {
           if (lstProducts.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a product to update.");
                return;
            }

            Classes.Product? selectedProd = lstProducts.SelectedItem as Classes.Product;
            AddUpdateProductForm updateForm = new(selectedProd);
            updateForm.ShowDialog();
            ReloadAllProducts();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
			// If no product is selected, tell user and return immediately
			if (lstProducts.SelectedIndex < 0)
			{
				MessageBox.Show("Please select a product to delete.");
				return;
			}

			Classes.Product? selectedProd = lstProducts.SelectedItem as Classes.Product;

			ProductDb.DeleteProduct(selectedProd);
			ReloadAllProducts(); // Refresh product list

			MessageBox.Show($"Product {selectedProd.Name} deleted.");
		}

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddUpdateProductForm addForm = new();
            DialogResult result = addForm.ShowDialog();

			// Only refresh if a new product was added
			if (result == DialogResult.OK)
            {
                ReloadAllProducts(); 
            }
        }
    }
}

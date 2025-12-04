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
		}
    }
}

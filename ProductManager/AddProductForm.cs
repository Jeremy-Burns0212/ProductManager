using ProductManager.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace ProductManager
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
			// Validate product name
			string name = txtProductName.Text?.Trim() ?? string.Empty;
			if (string.IsNullOrEmpty(name))
			{
				MessageBox.Show("Please enter a product name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtProductName.Focus();
				return;
			}

			// Validate and parse price (use current culture)
			if (!double.TryParse(txtPrice.Text, NumberStyles.Number | NumberStyles.AllowCurrencySymbol, CultureInfo.CurrentCulture, out double salesPrice))
			{
				MessageBox.Show("Please enter a valid price.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtPrice.Focus();
				return;
			}

			// Create product
			Product p = new()
			{
				Name = name,
				SalesPrice = salesPrice
			};

			try
			{
				// Persist product
				ProductDb.AddProduct(p);

				MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

				// Close the add form (or clear fields if you prefer)
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Failed to add product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
    }
}

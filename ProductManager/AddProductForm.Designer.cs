namespace ProductManager
{
    partial class AddProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPrice = new Label();
            ProductName = new Label();
            txtPrice = new TextBox();
            txtProductName = new TextBox();
            btnAddNewProduct = new Button();
            SuspendLayout();
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(126, 45);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(53, 25);
            lblPrice.TabIndex = 0;
            lblPrice.Text = "Price:";
            // 
            // ProductName
            // 
            ProductName.AutoSize = true;
            ProductName.Location = new Point(47, 111);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(132, 25);
            ProductName.TabIndex = 1;
            ProductName.Text = "Product name: ";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(185, 42);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(150, 31);
            txtPrice.TabIndex = 2;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(185, 108);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(150, 31);
            txtProductName.TabIndex = 3;
            // 
            // btnAddNewProduct
            // 
            btnAddNewProduct.Location = new Point(47, 192);
            btnAddNewProduct.Name = "btnAddNewProduct";
            btnAddNewProduct.Size = new Size(252, 108);
            btnAddNewProduct.TabIndex = 4;
            btnAddNewProduct.Text = "Add New Product";
            btnAddNewProduct.UseVisualStyleBackColor = true;
            btnAddNewProduct.Click += btnAddNewProduct_Click;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 354);
            Controls.Add(btnAddNewProduct);
            Controls.Add(txtProductName);
            Controls.Add(txtPrice);
            Controls.Add(ProductName);
            Controls.Add(lblPrice);
            Name = "AddProductForm";
            Text = "AddProductForm";
            Load += AddProductForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrice;
        private Label ProductName;
        private TextBox txtPrice;
        private TextBox txtProductName;
        private Button btnAddNewProduct;
    }
}
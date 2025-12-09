namespace ProductManager
{
    partial class WelcomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstProducts = new ListBox();
            btnUpdateProduct = new Button();
            btnDeleteProduct = new Button();
            btnAddProduct = new Button();
            SuspendLayout();
            // 
            // lstProducts
            // 
            lstProducts.FormattingEnabled = true;
            lstProducts.Location = new Point(12, 168);
            lstProducts.Name = "lstProducts";
            lstProducts.Size = new Size(348, 254);
            lstProducts.TabIndex = 0;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.Location = new Point(399, 239);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(258, 105);
            btnUpdateProduct.TabIndex = 1;
            btnUpdateProduct.Text = "Update Selected Product";
            btnUpdateProduct.UseVisualStyleBackColor = true;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(399, 106);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(258, 105);
            btnDeleteProduct.TabIndex = 2;
            btnDeleteProduct.Text = "Delete Selected Product";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(399, 368);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(258, 105);
            btnAddProduct.TabIndex = 3;
            btnAddProduct.Text = "Add New Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 587);
            Controls.Add(btnAddProduct);
            Controls.Add(btnDeleteProduct);
            Controls.Add(btnUpdateProduct);
            Controls.Add(lstProducts);
            Name = "WelcomeForm";
            Text = "Welcome Form";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstProducts;
        private Button btnUpdateProduct;
        private Button btnDeleteProduct;
        private Button btnAddProduct;
    }
}

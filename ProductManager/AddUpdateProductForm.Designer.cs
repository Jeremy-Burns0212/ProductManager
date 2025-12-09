namespace ProductManager
{
    partial class AddUpdateProductForm
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
            this.lblProductName = new Label();
            lblSalesPrice = new Label();
            txtProductName = new TextBox();
            txtSalesPrice = new TextBox();
            btnAddProduct = new Button();
            SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new Point(21, 54);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new Size(126, 25);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product Name";
            // 
            // lblSalesPrice
            // 
            lblSalesPrice.AutoSize = true;
            lblSalesPrice.Location = new Point(53, 146);
            lblSalesPrice.Name = "lblSalesPrice";
            lblSalesPrice.Size = new Size(94, 25);
            lblSalesPrice.TabIndex = 1;
            lblSalesPrice.Text = "Sales Price";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(153, 54);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(150, 31);
            txtProductName.TabIndex = 2;
            // 
            // txtSalesPrice
            // 
            txtSalesPrice.Location = new Point(153, 146);
            txtSalesPrice.Name = "txtSalesPrice";
            txtSalesPrice.Size = new Size(150, 31);
            txtSalesPrice.TabIndex = 3;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(88, 212);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(168, 78);
            btnAddProduct.TabIndex = 4;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // AddUpdateProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 353);
            Controls.Add(btnAddProduct);
            Controls.Add(txtSalesPrice);
            Controls.Add(txtProductName);
            Controls.Add(lblSalesPrice);
            Controls.Add(this.lblProductName);
            Name = "AddUpdateProductForm";
            Text = "AddUpdateProductForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductName;
        private Label lblSalesPrice;
        private TextBox txtProductName;
        private TextBox txtSalesPrice;
        private Button btnAddProduct;
    }
}
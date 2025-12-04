namespace ProductManager
{
    partial class Form1
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
            btnOpenCreateForm = new Button();
            btnDeleteProduct = new Button();
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
            // btnOpenCreateForm
            // 
            btnOpenCreateForm.Location = new Point(12, 12);
            btnOpenCreateForm.Name = "btnOpenCreateForm";
            btnOpenCreateForm.Size = new Size(258, 105);
            btnOpenCreateForm.TabIndex = 1;
            btnOpenCreateForm.Text = "Open Create Product Form";
            btnOpenCreateForm.UseVisualStyleBackColor = true;
            btnOpenCreateForm.Click += btnOpenCreateForm_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(415, 168);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(213, 105);
            btnDeleteProduct.TabIndex = 2;
            btnDeleteProduct.Text = "Delete Product";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 587);
            Controls.Add(btnDeleteProduct);
            Controls.Add(btnOpenCreateForm);
            Controls.Add(lstProducts);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstProducts;
        private Button btnOpenCreateForm;
        private Button btnDeleteProduct;
    }
}

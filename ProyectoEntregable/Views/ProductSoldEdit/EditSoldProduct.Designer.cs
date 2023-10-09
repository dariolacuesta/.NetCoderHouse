namespace ProyectoEntregable.Views.ProductSoldEdit
{
    partial class EditSoldProduct
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
            this.btn_save = new System.Windows.Forms.Button();
            this.product = new System.Windows.Forms.Label();
            this.txt_stock = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_product = new System.Windows.Forms.TextBox();
            this.txt_idSold = new System.Windows.Forms.TextBox();
            this.num_stock = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.num_stock)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(277, 385);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(273, 40);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Guardar";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // product
            // 
            this.product.AutoSize = true;
            this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product.Location = new System.Drawing.Point(274, 58);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(111, 25);
            this.product.TabIndex = 1;
            this.product.Text = "Id Producto";
            // 
            // txt_stock
            // 
            this.txt_stock.AutoSize = true;
            this.txt_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stock.Location = new System.Drawing.Point(274, 168);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(62, 25);
            this.txt_stock.TabIndex = 2;
            this.txt_stock.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(274, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Id Venta";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_product
            // 
            this.txt_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product.Location = new System.Drawing.Point(277, 113);
            this.txt_product.Name = "txt_product";
            this.txt_product.Size = new System.Drawing.Size(273, 30);
            this.txt_product.TabIndex = 4;
            // 
            // txt_idSold
            // 
            this.txt_idSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idSold.Location = new System.Drawing.Point(277, 320);
            this.txt_idSold.Name = "txt_idSold";
            this.txt_idSold.Size = new System.Drawing.Size(273, 30);
            this.txt_idSold.TabIndex = 6;
            // 
            // num_stock
            // 
            this.num_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_stock.Location = new System.Drawing.Point(277, 216);
            this.num_stock.Name = "num_stock";
            this.num_stock.Size = new System.Drawing.Size(273, 30);
            this.num_stock.TabIndex = 7;
            // 
            // EditSoldProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.num_stock);
            this.Controls.Add(this.txt_idSold);
            this.Controls.Add(this.txt_product);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_stock);
            this.Controls.Add(this.product);
            this.Controls.Add(this.btn_save);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.Name = "EditSoldProduct";
            this.Text = "EditSoldProduct";
            this.Load += new System.EventHandler(this.EditSoldProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label product;
        private System.Windows.Forms.Label txt_stock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_product;
        private System.Windows.Forms.TextBox txt_idSold;
        private System.Windows.Forms.NumericUpDown num_stock;
    }
}
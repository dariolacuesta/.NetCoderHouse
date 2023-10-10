namespace ProyectoEntregable
{
    partial class FormIndex
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstProductos = new System.Windows.Forms.Label();
            this.btnProducts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnProductSales = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstProductos
            // 
            this.lstProductos.AutoSize = true;
            this.lstProductos.Font = new System.Drawing.Font("Constantia", 18.25F);
            this.lstProductos.Location = new System.Drawing.Point(75, 45);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(241, 31);
            this.lstProductos.TabIndex = 1;
            this.lstProductos.Text = "Listado de Productos";
            this.lstProductos.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProducts.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.Location = new System.Drawing.Point(531, 45);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(90, 23);
            this.btnProducts.TabIndex = 2;
            this.btnProducts.Text = "Ver";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btn_listProducts);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 18.25F);
            this.label1.Location = new System.Drawing.Point(75, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Listado de Usuarios";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 18.25F);
            this.label2.Location = new System.Drawing.Point(75, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Listado de Productos Vendidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 18.25F);
            this.label3.Location = new System.Drawing.Point(75, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Listado de Ventas";
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUsers.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.Location = new System.Drawing.Point(531, 140);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(90, 23);
            this.btnUsers.TabIndex = 6;
            this.btnUsers.Text = "Ver";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnProductSales
            // 
            this.btnProductSales.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProductSales.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductSales.Location = new System.Drawing.Point(531, 227);
            this.btnProductSales.Name = "btnProductSales";
            this.btnProductSales.Size = new System.Drawing.Size(90, 23);
            this.btnProductSales.TabIndex = 7;
            this.btnProductSales.Text = "Ver";
            this.btnProductSales.UseVisualStyleBackColor = false;
            this.btnProductSales.Click += new System.EventHandler(this.btnProductSales_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSales.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.Location = new System.Drawing.Point(531, 312);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(90, 23);
            this.btnSales.TabIndex = 8;
            this.btnSales.Text = "Ver";
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // FormIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnProductSales);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.lstProductos);
            this.Font = new System.Drawing.Font("Forte", 8.25F);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.Name = "FormIndex";
            this.Text = "ListadoProductos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lstProductos;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnProductSales;
        private System.Windows.Forms.Button btnSales;
    }
}


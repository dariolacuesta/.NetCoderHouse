namespace ProyectoEntregable.Views.Edit
{
    partial class DeleteUser
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
            this.IdLlb = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IdLlb
            // 
            this.IdLlb.AutoSize = true;
            this.IdLlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLlb.Location = new System.Drawing.Point(112, 177);
            this.IdLlb.Name = "IdLlb";
            this.IdLlb.Size = new System.Drawing.Size(28, 25);
            this.IdLlb.TabIndex = 0;
            this.IdLlb.Text = "Id";
            // 
            // Id
            // 
            this.Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.Location = new System.Drawing.Point(117, 234);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(302, 30);
            this.Id.TabIndex = 1;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.LawnGreen;
            this.btn_save.Location = new System.Drawing.Point(117, 498);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(302, 40);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Guardar";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(611, 565);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.IdLlb);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.Name = "DeleteUser";
            this.Text = "DeleteUser";
            this.Load += new System.EventHandler(this.DeleteUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdLlb;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Button btn_save;
    }
}
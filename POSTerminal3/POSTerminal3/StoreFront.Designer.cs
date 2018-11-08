namespace POSTerminal3
{
    partial class StoreMain
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
            this.Cart = new System.Windows.Forms.Button();
            this.ViewProduct = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Cart
            // 
            this.Cart.BackgroundImage = global::POSTerminal3.Properties.Resources.download;
            this.Cart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cart.Location = new System.Drawing.Point(28, 92);
            this.Cart.Name = "Cart";
            this.Cart.Size = new System.Drawing.Size(54, 54);
            this.Cart.TabIndex = 1;
            this.Cart.UseVisualStyleBackColor = true;
            this.Cart.Click += new System.EventHandler(this.Cart_Click);
            // 
            // ViewProduct
            // 
            this.ViewProduct.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ViewProduct.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewProduct.Location = new System.Drawing.Point(323, 231);
            this.ViewProduct.Name = "ViewProduct";
            this.ViewProduct.Size = new System.Drawing.Size(227, 131);
            this.ViewProduct.TabIndex = 2;
            this.ViewProduct.Text = "CHECK OUT SOME BEATS";
            this.ViewProduct.UseVisualStyleBackColor = false;
            this.ViewProduct.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Font = new System.Drawing.Font("Ravie", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(129, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(676, 47);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "WELCOME TO BANGIN\' BEATS";
            // 
            // StoreMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::POSTerminal3.Properties.Resources.Storefront2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(873, 589);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ViewProduct);
            this.Controls.Add(this.Cart);
            this.DoubleBuffered = true;
            this.Name = "StoreMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Cart;
        private System.Windows.Forms.Button ViewProduct;
        private System.Windows.Forms.TextBox textBox1;
    }
}
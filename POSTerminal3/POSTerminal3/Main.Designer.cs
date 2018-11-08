namespace POSTerminal3
{
    partial class Main
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
            this.Begin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Begin
            // 
            this.Begin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Begin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Begin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Begin.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Begin.Location = new System.Drawing.Point(332, 411);
            this.Begin.Name = "Begin";
            this.Begin.Size = new System.Drawing.Size(181, 37);
            this.Begin.TabIndex = 0;
            this.Begin.Text = "ENTER . . .";
            this.Begin.UseVisualStyleBackColor = false;
            this.Begin.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::POSTerminal3.Properties.Resources.mainbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(855, 484);
            this.Controls.Add(this.Begin);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Begin;
    }
}


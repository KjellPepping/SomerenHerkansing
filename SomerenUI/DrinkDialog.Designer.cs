namespace SomerenUI
{
    partial class DrinkDialog
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
            this.lbl_EditDrink = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.lbl_drinkName = new System.Windows.Forms.Label();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.textBox_Supply = new System.Windows.Forms.TextBox();
            this.lbl_DrinkPrice = new System.Windows.Forms.Label();
            this.lbl_DrinkSupply = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_EditDrink
            // 
            this.lbl_EditDrink.AutoSize = true;
            this.lbl_EditDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lbl_EditDrink.Location = new System.Drawing.Point(22, 21);
            this.lbl_EditDrink.Name = "lbl_EditDrink";
            this.lbl_EditDrink.Size = new System.Drawing.Size(125, 30);
            this.lbl_EditDrink.TabIndex = 0;
            this.lbl_EditDrink.Text = "Edit Drink";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(27, 105);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(278, 20);
            this.textBox_Name.TabIndex = 1;
            // 
            // lbl_drinkName
            // 
            this.lbl_drinkName.AutoSize = true;
            this.lbl_drinkName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_drinkName.Location = new System.Drawing.Point(24, 86);
            this.lbl_drinkName.Name = "lbl_drinkName";
            this.lbl_drinkName.Size = new System.Drawing.Size(79, 16);
            this.lbl_drinkName.TabIndex = 2;
            this.lbl_drinkName.Text = "Drink name:";
            // 
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(27, 159);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(278, 20);
            this.textBox_Price.TabIndex = 3;
            // 
            // textBox_Supply
            // 
            this.textBox_Supply.Location = new System.Drawing.Point(27, 220);
            this.textBox_Supply.Name = "textBox_Supply";
            this.textBox_Supply.Size = new System.Drawing.Size(278, 20);
            this.textBox_Supply.TabIndex = 4;
            // 
            // lbl_DrinkPrice
            // 
            this.lbl_DrinkPrice.AutoSize = true;
            this.lbl_DrinkPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DrinkPrice.Location = new System.Drawing.Point(24, 140);
            this.lbl_DrinkPrice.Name = "lbl_DrinkPrice";
            this.lbl_DrinkPrice.Size = new System.Drawing.Size(75, 16);
            this.lbl_DrinkPrice.TabIndex = 5;
            this.lbl_DrinkPrice.Text = "Drink price:";
            // 
            // lbl_DrinkSupply
            // 
            this.lbl_DrinkSupply.AutoSize = true;
            this.lbl_DrinkSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DrinkSupply.Location = new System.Drawing.Point(24, 201);
            this.lbl_DrinkSupply.Name = "lbl_DrinkSupply";
            this.lbl_DrinkSupply.Size = new System.Drawing.Size(85, 16);
            this.lbl_DrinkSupply.TabIndex = 6;
            this.lbl_DrinkSupply.Text = "Drink supply:";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(24, 276);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 7;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(230, 276);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // DrinkDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(345, 330);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.lbl_DrinkSupply);
            this.Controls.Add(this.lbl_DrinkPrice);
            this.Controls.Add(this.textBox_Supply);
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.lbl_drinkName);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.lbl_EditDrink);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DrinkDialog";
            this.Text = "DrinkDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_EditDrink;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label lbl_drinkName;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.TextBox textBox_Supply;
        private System.Windows.Forms.Label lbl_DrinkPrice;
        private System.Windows.Forms.Label lbl_DrinkSupply;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Cancel;
    }
}
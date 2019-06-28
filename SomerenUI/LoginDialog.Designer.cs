namespace SomerenUI
{
    partial class LoginDialog
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
            this.btn_Login_Cancel = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.lbl_Warning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Login_Cancel
            // 
            this.btn_Login_Cancel.Location = new System.Drawing.Point(450, 269);
            this.btn_Login_Cancel.Name = "btn_Login_Cancel";
            this.btn_Login_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Login_Cancel.TabIndex = 17;
            this.btn_Login_Cancel.Text = "Cancel";
            this.btn_Login_Cancel.UseVisualStyleBackColor = true;
            this.btn_Login_Cancel.Click += new System.EventHandler(this.btn_Login_Cancel_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(247, 269);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 16;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(244, 193);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(71, 16);
            this.lbl_Password.TabIndex = 14;
            this.lbl_Password.Text = "Password:";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(247, 212);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(278, 20);
            this.textBox_Password.TabIndex = 12;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(244, 139);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(74, 16);
            this.lbl_Username.TabIndex = 11;
            this.lbl_Username.Text = "Username:";
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(247, 158);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(278, 20);
            this.textBox_Username.TabIndex = 10;
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lbl_Login.Location = new System.Drawing.Point(242, 74);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(75, 30);
            this.lbl_Login.TabIndex = 9;
            this.lbl_Login.Text = "Login";
            // 
            // lbl_Warning
            // 
            this.lbl_Warning.AutoSize = true;
            this.lbl_Warning.ForeColor = System.Drawing.Color.Red;
            this.lbl_Warning.Location = new System.Drawing.Point(247, 328);
            this.lbl_Warning.Name = "lbl_Warning";
            this.lbl_Warning.Size = new System.Drawing.Size(228, 15);
            this.lbl_Warning.TabIndex = 18;
            this.lbl_Warning.Text = "Username and/or password are not valid";
            this.lbl_Warning.Visible = false;
            // 
            // LoginDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Warning);
            this.Controls.Add(this.btn_Login_Cancel);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.lbl_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginDialog";
            this.Text = "LoginDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login_Cancel;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Label lbl_Warning;
    }
}
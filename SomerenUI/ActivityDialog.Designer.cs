namespace SomerenUI
{
    partial class ActivityDialog
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
            this.btn_Act_Cancel = new System.Windows.Forms.Button();
            this.btn_Act_Submit = new System.Windows.Forms.Button();
            this.lbl_StudentAmount = new System.Windows.Forms.Label();
            this.lbl_ActivityID = new System.Windows.Forms.Label();
            this.textBox_Act_Students = new System.Windows.Forms.TextBox();
            this.textBox_Act_ID = new System.Windows.Forms.TextBox();
            this.lbl_activityName = new System.Windows.Forms.Label();
            this.textBox_Act_Name = new System.Windows.Forms.TextBox();
            this.lbl_EditActivity = new System.Windows.Forms.Label();
            this.textBox_Act_Mentors = new System.Windows.Forms.TextBox();
            this.lbl_MentorAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Act_Cancel
            // 
            this.btn_Act_Cancel.Location = new System.Drawing.Point(230, 316);
            this.btn_Act_Cancel.Name = "btn_Act_Cancel";
            this.btn_Act_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Act_Cancel.TabIndex = 17;
            this.btn_Act_Cancel.Text = "Cancel";
            this.btn_Act_Cancel.UseVisualStyleBackColor = true;
            this.btn_Act_Cancel.Click += new System.EventHandler(this.btn_Act_Cancel_Click);
            // 
            // btn_Act_Submit
            // 
            this.btn_Act_Submit.Location = new System.Drawing.Point(24, 316);
            this.btn_Act_Submit.Name = "btn_Act_Submit";
            this.btn_Act_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Act_Submit.TabIndex = 16;
            this.btn_Act_Submit.Text = "Submit";
            this.btn_Act_Submit.UseVisualStyleBackColor = true;
            this.btn_Act_Submit.Click += new System.EventHandler(this.btn_Act_Submit_Click);
            // 
            // lbl_StudentAmount
            // 
            this.lbl_StudentAmount.AutoSize = true;
            this.lbl_StudentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StudentAmount.Location = new System.Drawing.Point(24, 205);
            this.lbl_StudentAmount.Name = "lbl_StudentAmount";
            this.lbl_StudentAmount.Size = new System.Drawing.Size(123, 16);
            this.lbl_StudentAmount.TabIndex = 15;
            this.lbl_StudentAmount.Text = "Amount of students:";
            // 
            // lbl_ActivityID
            // 
            this.lbl_ActivityID.AutoSize = true;
            this.lbl_ActivityID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ActivityID.Location = new System.Drawing.Point(24, 144);
            this.lbl_ActivityID.Name = "lbl_ActivityID";
            this.lbl_ActivityID.Size = new System.Drawing.Size(69, 16);
            this.lbl_ActivityID.TabIndex = 14;
            this.lbl_ActivityID.Text = "Activity ID:";
            // 
            // textBox_Act_Students
            // 
            this.textBox_Act_Students.Location = new System.Drawing.Point(27, 224);
            this.textBox_Act_Students.Name = "textBox_Act_Students";
            this.textBox_Act_Students.Size = new System.Drawing.Size(278, 20);
            this.textBox_Act_Students.TabIndex = 13;
            // 
            // textBox_Act_ID
            // 
            this.textBox_Act_ID.Location = new System.Drawing.Point(27, 163);
            this.textBox_Act_ID.Name = "textBox_Act_ID";
            this.textBox_Act_ID.Size = new System.Drawing.Size(278, 20);
            this.textBox_Act_ID.TabIndex = 12;
            // 
            // lbl_activityName
            // 
            this.lbl_activityName.AutoSize = true;
            this.lbl_activityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_activityName.Location = new System.Drawing.Point(24, 90);
            this.lbl_activityName.Name = "lbl_activityName";
            this.lbl_activityName.Size = new System.Drawing.Size(90, 16);
            this.lbl_activityName.TabIndex = 11;
            this.lbl_activityName.Text = "Activity name:";
            // 
            // textBox_Act_Name
            // 
            this.textBox_Act_Name.Location = new System.Drawing.Point(27, 109);
            this.textBox_Act_Name.Name = "textBox_Act_Name";
            this.textBox_Act_Name.Size = new System.Drawing.Size(278, 20);
            this.textBox_Act_Name.TabIndex = 10;
            // 
            // lbl_EditActivity
            // 
            this.lbl_EditActivity.AutoSize = true;
            this.lbl_EditActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lbl_EditActivity.Location = new System.Drawing.Point(22, 25);
            this.lbl_EditActivity.Name = "lbl_EditActivity";
            this.lbl_EditActivity.Size = new System.Drawing.Size(146, 30);
            this.lbl_EditActivity.TabIndex = 9;
            this.lbl_EditActivity.Text = "Edit Activity";
            // 
            // textBox_Act_Mentors
            // 
            this.textBox_Act_Mentors.Location = new System.Drawing.Point(27, 277);
            this.textBox_Act_Mentors.Name = "textBox_Act_Mentors";
            this.textBox_Act_Mentors.Size = new System.Drawing.Size(278, 20);
            this.textBox_Act_Mentors.TabIndex = 18;
            // 
            // lbl_MentorAmount
            // 
            this.lbl_MentorAmount.AutoSize = true;
            this.lbl_MentorAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MentorAmount.Location = new System.Drawing.Point(24, 258);
            this.lbl_MentorAmount.Name = "lbl_MentorAmount";
            this.lbl_MentorAmount.Size = new System.Drawing.Size(121, 16);
            this.lbl_MentorAmount.TabIndex = 19;
            this.lbl_MentorAmount.Text = "Amount of mentors:";
            // 
            // ActivityDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 450);
            this.Controls.Add(this.lbl_MentorAmount);
            this.Controls.Add(this.textBox_Act_Mentors);
            this.Controls.Add(this.btn_Act_Cancel);
            this.Controls.Add(this.btn_Act_Submit);
            this.Controls.Add(this.lbl_StudentAmount);
            this.Controls.Add(this.lbl_ActivityID);
            this.Controls.Add(this.textBox_Act_Students);
            this.Controls.Add(this.textBox_Act_ID);
            this.Controls.Add(this.lbl_activityName);
            this.Controls.Add(this.textBox_Act_Name);
            this.Controls.Add(this.lbl_EditActivity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActivityDialog";
            this.Text = "ActivityDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Act_Cancel;
        private System.Windows.Forms.Button btn_Act_Submit;
        private System.Windows.Forms.Label lbl_StudentAmount;
        private System.Windows.Forms.Label lbl_ActivityID;
        private System.Windows.Forms.TextBox textBox_Act_Students;
        private System.Windows.Forms.TextBox textBox_Act_ID;
        private System.Windows.Forms.Label lbl_activityName;
        private System.Windows.Forms.TextBox textBox_Act_Name;
        private System.Windows.Forms.Label lbl_EditActivity;
        private System.Windows.Forms.TextBox textBox_Act_Mentors;
        private System.Windows.Forms.Label lbl_MentorAmount;
    }
}
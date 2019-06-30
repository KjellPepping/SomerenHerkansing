﻿namespace SomerenUI
{
    partial class SomerenUI
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drankvoorraadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Dashboard = new System.Windows.Forms.Panel();
            this.lbl_Dashboard = new System.Windows.Forms.Label();
            this.img_Dashboard = new System.Windows.Forms.PictureBox();
            this.pnl_Students = new System.Windows.Forms.Panel();
            this.listViewStudents = new System.Windows.Forms.ListView();
            this.studentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentDOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Students = new System.Windows.Forms.Label();
            this.pnl_Drinks = new System.Windows.Forms.Panel();
            this.btn_Add_Drink = new System.Windows.Forms.Button();
            this.btn_Remove_Drink = new System.Windows.Forms.Button();
            this.btn_Edit_Drink = new System.Windows.Forms.Button();
            this.listViewDrinks = new System.Windows.Forms.ListView();
            this.DrinkName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DrinkPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DrinkSupply = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_Drinks = new System.Windows.Forms.Label();
            this.pnl_Activities = new System.Windows.Forms.Panel();
            this.btn_Add_Activity = new System.Windows.Forms.Button();
            this.btn_Remove_Activity = new System.Windows.Forms.Button();
            this.btn_Edit_Activities = new System.Windows.Forms.Button();
            this.listViewActivities = new System.Windows.Forms.ListView();
            this.ActivityStudents = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ActivityMentors = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ActivityID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ActivityDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_Activities = new System.Windows.Forms.Label();
            this.lbl_Act_Info = new System.Windows.Forms.Label();
            this.lbl_Drink_Info = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnl_Dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Dashboard)).BeginInit();
            this.pnl_Students.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_Drinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnl_Activities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.lecturersToolStripMenuItem,
            this.activitiesToolStripMenuItem,
            this.roomsToolStripMenuItem,
            this.drankvoorraadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(962, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem1,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(89, 23);
            this.dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            this.dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            this.dashboardToolStripMenuItem1.Size = new System.Drawing.Size(147, 24);
            this.dashboardToolStripMenuItem1.Text = "Dashboard";
            this.dashboardToolStripMenuItem1.Click += new System.EventHandler(this.dashboardToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(144, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(75, 23);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // lecturersToolStripMenuItem
            // 
            this.lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            this.lecturersToolStripMenuItem.Size = new System.Drawing.Size(77, 23);
            this.lecturersToolStripMenuItem.Text = "Lecturers";
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(75, 23);
            this.activitiesToolStripMenuItem.Text = "Activities";
            this.activitiesToolStripMenuItem.Click += new System.EventHandler(this.activitiesToolStripMenuItem_Click);
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(63, 23);
            this.roomsToolStripMenuItem.Text = "Rooms";
            // 
            // drankvoorraadToolStripMenuItem
            // 
            this.drankvoorraadToolStripMenuItem.Name = "drankvoorraadToolStripMenuItem";
            this.drankvoorraadToolStripMenuItem.Size = new System.Drawing.Size(113, 23);
            this.drankvoorraadToolStripMenuItem.Text = "Drankvoorraad";
            this.drankvoorraadToolStripMenuItem.Click += new System.EventHandler(this.drankvoorraadToolStripMenuItem_Click);
            // 
            // pnl_Dashboard
            // 
            this.pnl_Dashboard.Controls.Add(this.lbl_Dashboard);
            this.pnl_Dashboard.Controls.Add(this.img_Dashboard);
            this.pnl_Dashboard.Location = new System.Drawing.Point(12, 27);
            this.pnl_Dashboard.Name = "pnl_Dashboard";
            this.pnl_Dashboard.Size = new System.Drawing.Size(938, 466);
            this.pnl_Dashboard.TabIndex = 2;
            // 
            // lbl_Dashboard
            // 
            this.lbl_Dashboard.AutoSize = true;
            this.lbl_Dashboard.Location = new System.Drawing.Point(13, 13);
            this.lbl_Dashboard.Name = "lbl_Dashboard";
            this.lbl_Dashboard.Size = new System.Drawing.Size(212, 15);
            this.lbl_Dashboard.TabIndex = 1;
            this.lbl_Dashboard.Text = "Welcome to the Someren Application!";
            // 
            // img_Dashboard
            // 
            this.img_Dashboard.Location = new System.Drawing.Point(627, 0);
            this.img_Dashboard.Name = "img_Dashboard";
            this.img_Dashboard.Size = new System.Drawing.Size(311, 270);
            this.img_Dashboard.TabIndex = 0;
            this.img_Dashboard.TabStop = false;
            this.img_Dashboard.Click += new System.EventHandler(this.img_Dashboard_Click);
            // 
            // pnl_Students
            // 
            this.pnl_Students.Controls.Add(this.listViewStudents);
            this.pnl_Students.Controls.Add(this.pictureBox1);
            this.pnl_Students.Controls.Add(this.lbl_Students);
            this.pnl_Students.Location = new System.Drawing.Point(12, 27);
            this.pnl_Students.Name = "pnl_Students";
            this.pnl_Students.Size = new System.Drawing.Size(938, 466);
            this.pnl_Students.TabIndex = 4;
            // 
            // listViewStudents
            // 
            this.listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentName,
            this.studentID,
            this.studentDOB});
            this.listViewStudents.HideSelection = false;
            this.listViewStudents.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewStudents.Location = new System.Drawing.Point(16, 42);
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.Size = new System.Drawing.Size(766, 307);
            this.listViewStudents.TabIndex = 5;
            this.listViewStudents.UseCompatibleStateImageBehavior = false;
            this.listViewStudents.View = System.Windows.Forms.View.Details;
            // 
            // studentName
            // 
            this.studentName.Text = "Name";
            this.studentName.Width = 120;
            // 
            // studentID
            // 
            this.studentID.Text = "ID";
            this.studentID.Width = 100;
            // 
            // studentDOB
            // 
            this.studentDOB.Text = "Date of Birth";
            this.studentDOB.Width = 150;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(805, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 123);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Students
            // 
            this.lbl_Students.AutoSize = true;
            this.lbl_Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Students.Location = new System.Drawing.Point(10, 10);
            this.lbl_Students.Name = "lbl_Students";
            this.lbl_Students.Size = new System.Drawing.Size(113, 30);
            this.lbl_Students.TabIndex = 3;
            this.lbl_Students.Text = "Students";
            // 
            // pnl_Drinks
            // 
            this.pnl_Drinks.Controls.Add(this.lbl_Drink_Info);
            this.pnl_Drinks.Controls.Add(this.btn_Add_Drink);
            this.pnl_Drinks.Controls.Add(this.btn_Remove_Drink);
            this.pnl_Drinks.Controls.Add(this.btn_Edit_Drink);
            this.pnl_Drinks.Controls.Add(this.listViewDrinks);
            this.pnl_Drinks.Controls.Add(this.pictureBox2);
            this.pnl_Drinks.Controls.Add(this.lbl_Drinks);
            this.pnl_Drinks.Location = new System.Drawing.Point(12, 27);
            this.pnl_Drinks.Name = "pnl_Drinks";
            this.pnl_Drinks.Size = new System.Drawing.Size(938, 466);
            this.pnl_Drinks.TabIndex = 6;
            // 
            // btn_Add_Drink
            // 
            this.btn_Add_Drink.Location = new System.Drawing.Point(675, 372);
            this.btn_Add_Drink.Name = "btn_Add_Drink";
            this.btn_Add_Drink.Size = new System.Drawing.Size(107, 36);
            this.btn_Add_Drink.TabIndex = 9;
            this.btn_Add_Drink.Text = "Add";
            this.btn_Add_Drink.UseVisualStyleBackColor = true;
            this.btn_Add_Drink.Click += new System.EventHandler(this.btn_Add_Drink_Click);
            // 
            // btn_Remove_Drink
            // 
            this.btn_Remove_Drink.Enabled = false;
            this.btn_Remove_Drink.Location = new System.Drawing.Point(129, 372);
            this.btn_Remove_Drink.Name = "btn_Remove_Drink";
            this.btn_Remove_Drink.Size = new System.Drawing.Size(107, 36);
            this.btn_Remove_Drink.TabIndex = 8;
            this.btn_Remove_Drink.Text = "Remove";
            this.btn_Remove_Drink.UseVisualStyleBackColor = true;
            this.btn_Remove_Drink.Click += new System.EventHandler(this.btn_Remove_Drink_Click);
            // 
            // btn_Edit_Drink
            // 
            this.btn_Edit_Drink.Enabled = false;
            this.btn_Edit_Drink.Location = new System.Drawing.Point(16, 372);
            this.btn_Edit_Drink.Name = "btn_Edit_Drink";
            this.btn_Edit_Drink.Size = new System.Drawing.Size(107, 36);
            this.btn_Edit_Drink.TabIndex = 6;
            this.btn_Edit_Drink.Text = "Edit";
            this.btn_Edit_Drink.UseVisualStyleBackColor = true;
            this.btn_Edit_Drink.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // listViewDrinks
            // 
            this.listViewDrinks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DrinkName,
            this.DrinkPrice,
            this.DrinkSupply});
            this.listViewDrinks.HideSelection = false;
            this.listViewDrinks.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listViewDrinks.Location = new System.Drawing.Point(16, 42);
            this.listViewDrinks.Name = "listViewDrinks";
            this.listViewDrinks.Size = new System.Drawing.Size(766, 307);
            this.listViewDrinks.TabIndex = 5;
            this.listViewDrinks.UseCompatibleStateImageBehavior = false;
            this.listViewDrinks.View = System.Windows.Forms.View.Details;
            this.listViewDrinks.SelectedIndexChanged += new System.EventHandler(this.listViewDrinks_SelectedIndexChanged_1);
            // 
            // DrinkName
            // 
            this.DrinkName.Text = "Name";
            this.DrinkName.Width = 100;
            // 
            // DrinkPrice
            // 
            this.DrinkPrice.Text = "Price";
            this.DrinkPrice.Width = 100;
            // 
            // DrinkSupply
            // 
            this.DrinkSupply.Text = "Supply";
            this.DrinkSupply.Width = 100;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(805, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 123);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_Drinks
            // 
            this.lbl_Drinks.AutoSize = true;
            this.lbl_Drinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Drinks.Location = new System.Drawing.Point(10, 10);
            this.lbl_Drinks.Name = "lbl_Drinks";
            this.lbl_Drinks.Size = new System.Drawing.Size(87, 30);
            this.lbl_Drinks.TabIndex = 3;
            this.lbl_Drinks.Text = "Drinks";
            // 
            // pnl_Activities
            // 
            this.pnl_Activities.Controls.Add(this.lbl_Act_Info);
            this.pnl_Activities.Controls.Add(this.btn_Add_Activity);
            this.pnl_Activities.Controls.Add(this.btn_Remove_Activity);
            this.pnl_Activities.Controls.Add(this.btn_Edit_Activities);
            this.pnl_Activities.Controls.Add(this.listViewActivities);
            this.pnl_Activities.Controls.Add(this.pictureBox3);
            this.pnl_Activities.Controls.Add(this.lbl_Activities);
            this.pnl_Activities.Location = new System.Drawing.Point(12, 27);
            this.pnl_Activities.Name = "pnl_Activities";
            this.pnl_Activities.Size = new System.Drawing.Size(938, 466);
            this.pnl_Activities.TabIndex = 7;
            // 
            // btn_Add_Activity
            // 
            this.btn_Add_Activity.Location = new System.Drawing.Point(675, 372);
            this.btn_Add_Activity.Name = "btn_Add_Activity";
            this.btn_Add_Activity.Size = new System.Drawing.Size(107, 36);
            this.btn_Add_Activity.TabIndex = 8;
            this.btn_Add_Activity.Text = "Add";
            this.btn_Add_Activity.UseVisualStyleBackColor = false;
            this.btn_Add_Activity.Click += new System.EventHandler(this.btn_Add_Activity_Click);
            // 
            // btn_Remove_Activity
            // 
            this.btn_Remove_Activity.Enabled = false;
            this.btn_Remove_Activity.Location = new System.Drawing.Point(129, 372);
            this.btn_Remove_Activity.Name = "btn_Remove_Activity";
            this.btn_Remove_Activity.Size = new System.Drawing.Size(107, 36);
            this.btn_Remove_Activity.TabIndex = 7;
            this.btn_Remove_Activity.Text = "Remove";
            this.btn_Remove_Activity.UseVisualStyleBackColor = true;
            this.btn_Remove_Activity.Click += new System.EventHandler(this.btn_Remove_Activity_Click);
            // 
            // btn_Edit_Activities
            // 
            this.btn_Edit_Activities.Enabled = false;
            this.btn_Edit_Activities.Location = new System.Drawing.Point(16, 372);
            this.btn_Edit_Activities.Name = "btn_Edit_Activities";
            this.btn_Edit_Activities.Size = new System.Drawing.Size(107, 36);
            this.btn_Edit_Activities.TabIndex = 6;
            this.btn_Edit_Activities.Text = "Edit";
            this.btn_Edit_Activities.UseVisualStyleBackColor = true;
            this.btn_Edit_Activities.Click += new System.EventHandler(this.btn_Edit_Activities_Click);
            // 
            // listViewActivities
            // 
            this.listViewActivities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ActivityStudents,
            this.ActivityMentors,
            this.ActivityID,
            this.ActivityDesc});
            this.listViewActivities.HideSelection = false;
            this.listViewActivities.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.listViewActivities.Location = new System.Drawing.Point(16, 42);
            this.listViewActivities.Name = "listViewActivities";
            this.listViewActivities.Size = new System.Drawing.Size(766, 307);
            this.listViewActivities.TabIndex = 5;
            this.listViewActivities.UseCompatibleStateImageBehavior = false;
            this.listViewActivities.View = System.Windows.Forms.View.Details;
            this.listViewActivities.SelectedIndexChanged += new System.EventHandler(this.listViewActivities_SelectedIndexChanged);
            // 
            // ActivityStudents
            // 
            this.ActivityStudents.Text = "Student Count";
            this.ActivityStudents.Width = 80;
            // 
            // ActivityMentors
            // 
            this.ActivityMentors.Text = "Mentor Count";
            this.ActivityMentors.Width = 80;
            // 
            // ActivityID
            // 
            this.ActivityID.Text = "ID";
            this.ActivityID.Width = 30;
            // 
            // ActivityDesc
            // 
            this.ActivityDesc.Text = "Description";
            this.ActivityDesc.Width = 300;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(805, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(130, 123);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_Activities
            // 
            this.lbl_Activities.AutoSize = true;
            this.lbl_Activities.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Activities.Location = new System.Drawing.Point(10, 10);
            this.lbl_Activities.Name = "lbl_Activities";
            this.lbl_Activities.Size = new System.Drawing.Size(115, 30);
            this.lbl_Activities.TabIndex = 3;
            this.lbl_Activities.Text = "Activities";
            // 
            // lbl_Act_Info
            // 
            this.lbl_Act_Info.AutoSize = true;
            this.lbl_Act_Info.Location = new System.Drawing.Point(16, 429);
            this.lbl_Act_Info.Name = "lbl_Act_Info";
            this.lbl_Act_Info.Size = new System.Drawing.Size(314, 15);
            this.lbl_Act_Info.TabIndex = 9;
            this.lbl_Act_Info.Text = "Selecteer een Activity door op de eerste kolom te klikken.";
            // 
            // lbl_Drink_Info
            // 
            this.lbl_Drink_Info.AutoSize = true;
            this.lbl_Drink_Info.Location = new System.Drawing.Point(16, 434);
            this.lbl_Drink_Info.Name = "lbl_Drink_Info";
            this.lbl_Drink_Info.Size = new System.Drawing.Size(308, 15);
            this.lbl_Drink_Info.TabIndex = 10;
            this.lbl_Drink_Info.Text = "Selecteer een Drink door op de eerste kolom te klikken.";
            // 
            // SomerenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 505);
            this.Controls.Add(this.pnl_Students);
            this.Controls.Add(this.pnl_Activities);
            this.Controls.Add(this.pnl_Drinks);
            this.Controls.Add(this.pnl_Dashboard);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SomerenUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SomerenApp";
            this.Load += new System.EventHandler(this.SomerenUI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_Dashboard.ResumeLayout(false);
            this.pnl_Dashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Dashboard)).EndInit();
            this.pnl_Students.ResumeLayout(false);
            this.pnl_Students.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_Drinks.ResumeLayout(false);
            this.pnl_Drinks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnl_Activities.ResumeLayout(false);
            this.pnl_Activities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_Dashboard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Dashboard;
        private System.Windows.Forms.Label lbl_Dashboard;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Students;
        private System.Windows.Forms.Label lbl_Students;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.ColumnHeader studentName;
        private System.Windows.Forms.ColumnHeader studentID;
        private System.Windows.Forms.ColumnHeader studentDOB;
        private System.Windows.Forms.ToolStripMenuItem drankvoorraadToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Drinks;
        private System.Windows.Forms.ListView listViewDrinks;
        private System.Windows.Forms.ColumnHeader DrinkName;
        private System.Windows.Forms.ColumnHeader DrinkPrice;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_Drinks;
        private System.Windows.Forms.ColumnHeader DrinkSupply;
        private System.Windows.Forms.Button btn_Edit_Drink;
        private System.Windows.Forms.Panel pnl_Activities;
        private System.Windows.Forms.Button btn_Edit_Activities;
        private System.Windows.Forms.ListView listViewActivities;
        private System.Windows.Forms.ColumnHeader ActivityStudents;
        private System.Windows.Forms.ColumnHeader ActivityMentors;
        private System.Windows.Forms.ColumnHeader ActivityID;
        private System.Windows.Forms.ColumnHeader ActivityDesc;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_Activities;
        private System.Windows.Forms.Button btn_Remove_Drink;
        private System.Windows.Forms.Button btn_Add_Drink;
        private System.Windows.Forms.Button btn_Add_Activity;
        private System.Windows.Forms.Button btn_Remove_Activity;
        private System.Windows.Forms.Label lbl_Drink_Info;
        private System.Windows.Forms.Label lbl_Act_Info;
    }
}


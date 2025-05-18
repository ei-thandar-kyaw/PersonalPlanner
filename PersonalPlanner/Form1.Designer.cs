namespace PersonalPlanner
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbTask = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.tbTask = new System.Windows.Forms.TextBox();
            this.cmbCateogry = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTaskDetails = new System.Windows.Forms.Label();
            this.rtbTaskDetails = new System.Windows.Forms.RichTextBox();
            this.lvTasks = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(291, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personal Planner";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbTask
            // 
            this.lbTask.AutoSize = true;
            this.lbTask.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTask.Location = new System.Drawing.Point(12, 18);
            this.lbTask.Name = "lbTask";
            this.lbTask.Size = new System.Drawing.Size(52, 19);
            this.lbTask.TabIndex = 1;
            this.lbTask.Text = "Task: ";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.Location = new System.Drawing.Point(12, 59);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(88, 19);
            this.lbCategory.TabIndex = 2;
            this.lbCategory.Text = "Category: ";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(12, 102);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(44, 19);
            this.lbDate.TabIndex = 3;
            this.lbDate.Text = "Due:";
            // 
            // tbTask
            // 
            this.tbTask.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTask.Location = new System.Drawing.Point(81, 15);
            this.tbTask.Name = "tbTask";
            this.tbTask.Size = new System.Drawing.Size(250, 26);
            this.tbTask.TabIndex = 4;
            // 
            // cmbCateogry
            // 
            this.cmbCateogry.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCateogry.FormattingEnabled = true;
            this.cmbCateogry.Items.AddRange(new object[] {
            "Personal",
            "Work",
            "School"});
            this.cmbCateogry.Location = new System.Drawing.Point(126, 59);
            this.cmbCateogry.Name = "cmbCateogry";
            this.cmbCateogry.Size = new System.Drawing.Size(205, 27);
            this.cmbCateogry.TabIndex = 5;
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(71, 102);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(260, 26);
            this.dtpDate.TabIndex = 6;
            // 
            // btnAddTask
            // 
            this.btnAddTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddTask.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.Location = new System.Drawing.Point(16, 363);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(315, 37);
            this.btnAddTask.TabIndex = 7;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lbTaskDetails);
            this.panel1.Controls.Add(this.rtbTaskDetails);
            this.panel1.Controls.Add(this.btnAddTask);
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.cmbCateogry);
            this.panel1.Controls.Add(this.tbTask);
            this.panel1.Controls.Add(this.lbDate);
            this.panel1.Controls.Add(this.lbCategory);
            this.panel1.Controls.Add(this.lbTask);
            this.panel1.Location = new System.Drawing.Point(33, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 414);
            this.panel1.TabIndex = 8;
            // 
            // lbTaskDetails
            // 
            this.lbTaskDetails.AutoSize = true;
            this.lbTaskDetails.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaskDetails.Location = new System.Drawing.Point(12, 150);
            this.lbTaskDetails.Name = "lbTaskDetails";
            this.lbTaskDetails.Size = new System.Drawing.Size(102, 19);
            this.lbTaskDetails.TabIndex = 9;
            this.lbTaskDetails.Text = "Task Details:";
            // 
            // rtbTaskDetails
            // 
            this.rtbTaskDetails.Location = new System.Drawing.Point(16, 183);
            this.rtbTaskDetails.Name = "rtbTaskDetails";
            this.rtbTaskDetails.Size = new System.Drawing.Size(314, 158);
            this.rtbTaskDetails.TabIndex = 8;
            this.rtbTaskDetails.Text = "| ";
            // 
            // lvTasks
            // 
            this.lvTasks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lvTasks.CheckBoxes = true;
            this.lvTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvTasks.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvTasks.FullRowSelect = true;
            this.lvTasks.GridLines = true;
            this.lvTasks.HideSelection = false;
            this.lvTasks.Location = new System.Drawing.Point(408, 90);
            this.lvTasks.Name = "lvTasks";
            this.lvTasks.Size = new System.Drawing.Size(482, 414);
            this.lvTasks.TabIndex = 10;
            this.lvTasks.UseCompatibleStateImageBehavior = false;
            this.lvTasks.View = System.Windows.Forms.View.Details;
            this.lvTasks.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvTasks_ItemChecked);
            this.lvTasks.DoubleClick += new System.EventHandler(this.lvTasks_DoubleClick);
            this.lvTasks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvTasks_KeyDown);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Task";
            this.columnHeader4.Width = 114;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Status";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 112;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Due Date";
            this.columnHeader6.Width = 190;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(902, 544);
            this.Controls.Add(this.lvTasks);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTask;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.TextBox tbTask;
        private System.Windows.Forms.ComboBox cmbCateogry;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTaskDetails;
        private System.Windows.Forms.RichTextBox rtbTaskDetails;
        private System.Windows.Forms.ListView lvTasks;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}


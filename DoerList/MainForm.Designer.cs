namespace DoerList
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnAddTaskMain = new Button();
            btnRemoveTaskMain = new Button();
            progressBar = new ProgressBar();
            monthCalendar = new MonthCalendar();
            lblCompletedTasks = new Label();
            listViewTask = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            button1 = new Button();
            btnClearAllMain = new Button();
            lblPendingTasks = new Label();
            button2 = new Button();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            btnEdit = new Button();
            UpdateDailyDoersProgress = new ProgressBar();
            datePickerTask = new DateTimePicker();
            timePickerTaskTime = new DateTimePicker();
            label1 = new Label();
            label3 = new Label();
            MarkAsCompleted = new Button();
            lblTotalTasks = new Label();
            lvDailyDoer = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // btnAddTaskMain
            // 
            btnAddTaskMain.Location = new Point(272, 192);
            btnAddTaskMain.Name = "btnAddTaskMain";
            btnAddTaskMain.Size = new Size(75, 23);
            btnAddTaskMain.TabIndex = 2;
            btnAddTaskMain.Text = "Add Task";
            btnAddTaskMain.UseVisualStyleBackColor = true;
            btnAddTaskMain.Click += btnAddTaskMain_Click;
            // 
            // btnRemoveTaskMain
            // 
            btnRemoveTaskMain.Location = new Point(363, 192);
            btnRemoveTaskMain.Name = "btnRemoveTaskMain";
            btnRemoveTaskMain.Size = new Size(87, 23);
            btnRemoveTaskMain.TabIndex = 3;
            btnRemoveTaskMain.Text = "Remove Task";
            btnRemoveTaskMain.UseVisualStyleBackColor = true;
            btnRemoveTaskMain.Click += btnRemoveTaskMain_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(508, 12);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(209, 27);
            progressBar.TabIndex = 4;
            // 
            // monthCalendar
            // 
            monthCalendar.Location = new Point(100, 9);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 5;
            // 
            // lblCompletedTasks
            // 
            lblCompletedTasks.AccessibleRole = AccessibleRole.None;
            lblCompletedTasks.AutoSize = true;
            lblCompletedTasks.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCompletedTasks.Location = new Point(495, 80);
            lblCompletedTasks.Name = "lblCompletedTasks";
            lblCompletedTasks.Size = new Size(89, 25);
            lblCompletedTasks.TabIndex = 6;
            lblCompletedTasks.Text = "Progress:";
            // 
            // listViewTask
            // 
            listViewTask.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listViewTask.Location = new Point(49, 256);
            listViewTask.Margin = new Padding(2);
            listViewTask.Name = "listViewTask";
            listViewTask.Size = new Size(402, 124);
            listViewTask.TabIndex = 17;
            listViewTask.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Task";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Due Date";
            columnHeader2.Width = 150;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(53, 214);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(36, 32);
            button1.TabIndex = 19;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnClearAllMain
            // 
            btnClearAllMain.Location = new Point(371, 226);
            btnClearAllMain.Margin = new Padding(2);
            btnClearAllMain.Name = "btnClearAllMain";
            btnClearAllMain.Size = new Size(78, 20);
            btnClearAllMain.TabIndex = 20;
            btnClearAllMain.Text = "Clear All task";
            btnClearAllMain.UseVisualStyleBackColor = true;
            btnClearAllMain.Click += btnClearAllMain_Click;
            // 
            // lblPendingTasks
            // 
            lblPendingTasks.AccessibleRole = AccessibleRole.None;
            lblPendingTasks.AutoSize = true;
            lblPendingTasks.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPendingTasks.Location = new Point(451, 116);
            lblPendingTasks.Name = "lblPendingTasks";
            lblPendingTasks.Size = new Size(133, 25);
            lblPendingTasks.TabIndex = 21;
            lblPendingTasks.Text = "Pending Tasks:";
            // 
            // button2
            // 
            button2.Location = new Point(11, 50);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(78, 20);
            button2.TabIndex = 22;
            button2.Text = "Log out";
            button2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(1376, 448);
            numericUpDown1.Margin = new Padding(2);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(126, 23);
            numericUpDown1.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 24);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 41;
            label2.Text = "User: ";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(251, 399);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(99, 32);
            btnEdit.TabIndex = 42;
            btnEdit.Text = "Edit Daily Doers";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // UpdateDailyDoersProgress
            // 
            UpdateDailyDoersProgress.Location = new Point(508, 50);
            UpdateDailyDoersProgress.Name = "UpdateDailyDoersProgress";
            UpdateDailyDoersProgress.Size = new Size(209, 27);
            UpdateDailyDoersProgress.TabIndex = 43;
            // 
            // datePickerTask
            // 
            datePickerTask.CustomFormat = "MM/dd/yyyy hh:mm tt";
            datePickerTask.Format = DateTimePickerFormat.Custom;
            datePickerTask.Location = new Point(577, 276);
            datePickerTask.Name = "datePickerTask";
            datePickerTask.Size = new Size(200, 23);
            datePickerTask.TabIndex = 44;
            // 
            // timePickerTaskTime
            // 
            timePickerTaskTime.Location = new Point(577, 357);
            timePickerTaskTime.Name = "timePickerTaskTime";
            timePickerTaskTime.Size = new Size(200, 23);
            timePickerTaskTime.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(577, 246);
            label1.Name = "label1";
            label1.Size = new Size(44, 21);
            label1.TabIndex = 46;
            label1.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(577, 323);
            label3.Name = "label3";
            label3.Size = new Size(46, 21);
            label3.TabIndex = 47;
            label3.Text = "Time";
            // 
            // MarkAsCompleted
            // 
            MarkAsCompleted.Location = new Point(272, 223);
            MarkAsCompleted.Name = "MarkAsCompleted";
            MarkAsCompleted.Size = new Size(75, 23);
            MarkAsCompleted.TabIndex = 48;
            MarkAsCompleted.Text = "Mark as Done";
            MarkAsCompleted.UseVisualStyleBackColor = true;
            MarkAsCompleted.Click += MarkAsCompleted_Click;
            // 
            // lblTotalTasks
            // 
            lblTotalTasks.AccessibleRole = AccessibleRole.None;
            lblTotalTasks.AutoSize = true;
            lblTotalTasks.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalTasks.Location = new Point(483, 161);
            lblTotalTasks.Name = "lblTotalTasks";
            lblTotalTasks.Size = new Size(101, 25);
            lblTotalTasks.TabIndex = 49;
            lblTotalTasks.Text = "Total Task: ";
            // 
            // lvDailyDoer
            // 
            lvDailyDoer.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4 });
            lvDailyDoer.Location = new Point(49, 384);
            lvDailyDoer.Margin = new Padding(2);
            lvDailyDoer.Name = "lvDailyDoer";
            lvDailyDoer.Size = new Size(197, 124);
            lvDailyDoer.TabIndex = 50;
            lvDailyDoer.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Task";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Due Date";
            columnHeader4.Width = 150;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 532);
            Controls.Add(lvDailyDoer);
            Controls.Add(lblTotalTasks);
            Controls.Add(MarkAsCompleted);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(timePickerTaskTime);
            Controls.Add(datePickerTask);
            Controls.Add(UpdateDailyDoersProgress);
            Controls.Add(btnEdit);
            Controls.Add(label2);
            Controls.Add(numericUpDown1);
            Controls.Add(button2);
            Controls.Add(lblPendingTasks);
            Controls.Add(btnClearAllMain);
            Controls.Add(button1);
            Controls.Add(listViewTask);
            Controls.Add(lblCompletedTasks);
            Controls.Add(monthCalendar);
            Controls.Add(progressBar);
            Controls.Add(btnRemoveTaskMain);
            Controls.Add(btnAddTaskMain);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DoerList";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAddTaskMain;
        private Button btnRemoveTaskMain;
        private ProgressBar progressBar;
        private MonthCalendar monthCalendar;
        private Label lblCompletedTasks;
        private ListView listViewTask;
        private Button button1;
        private Button btnClearAllMain;
        private Label lblPendingTasks;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button button2;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Button btnEdit;
        private ProgressBar UpdateDailyDoersProgress;
        private DateTimePicker datePickerTask;
        private DateTimePicker timePickerTaskTime;
        private Label label1;
        private Label label3;
        private Button MarkAsCompleted;
        private Label lblTotalTasks;
        private ListView lvDailyDoer;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}

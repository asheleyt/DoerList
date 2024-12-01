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
            lblProgress = new Label();
            listViewTask = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            textBox1 = new TextBox();
            button1 = new Button();
            btnClearAllMain = new Button();
            lblPendingTasks = new Label();
            button2 = new Button();
            numericUpDown1 = new NumericUpDown();
            label69 = new Label();
            label2 = new Label();
            btnEdit = new Button();
            UpdateDailyDoersProgress = new ProgressBar();
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
            // lblProgress
            // 
            lblProgress.AccessibleRole = AccessibleRole.None;
            lblProgress.AutoSize = true;
            lblProgress.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProgress.Location = new Point(495, 78);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(89, 25);
            lblProgress.TabIndex = 6;
            lblProgress.Text = "Progress:";
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
            // textBox1
            // 
            textBox1.Location = new Point(24, 204);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(106, 23);
            textBox1.TabIndex = 18;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(133, 197);
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
            // label69
            // 
            label69.AutoSize = true;
            label69.Font = new Font("Segoe UI", 14.25F);
            label69.Location = new Point(485, 146);
            label69.Margin = new Padding(2, 0, 2, 0);
            label69.Name = "label69";
            label69.Size = new Size(99, 25);
            label69.TabIndex = 23;
            label69.Text = "DailyDoer:";
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
            btnEdit.Location = new Point(485, 174);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(99, 32);
            btnEdit.TabIndex = 42;
            btnEdit.Text = "Edit Daily Doers";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // UpdateDailyDoersProgress
            // 
            UpdateDailyDoersProgress.Location = new Point(508, 43);
            UpdateDailyDoersProgress.Name = "UpdateDailyDoersProgress";
            UpdateDailyDoersProgress.Size = new Size(209, 27);
            UpdateDailyDoersProgress.TabIndex = 43;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 426);
            Controls.Add(UpdateDailyDoersProgress);
            Controls.Add(btnEdit);
            Controls.Add(label2);
            Controls.Add(numericUpDown1);
            Controls.Add(label69);
            Controls.Add(button2);
            Controls.Add(lblPendingTasks);
            Controls.Add(btnClearAllMain);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(listViewTask);
            Controls.Add(lblProgress);
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
        private Label lblProgress;
        private ListView listViewTask;
        private TextBox textBox1;
        private Button button1;
        private Button btnClearAllMain;
        private Label lblPendingTasks;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button button2;
        private NumericUpDown numericUpDown1;
        private Label label69;
        private Label label2;
        private Button btnEdit;
        private ProgressBar UpdateDailyDoersProgress;
    }
}

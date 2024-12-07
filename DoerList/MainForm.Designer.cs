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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnAddTaskMain = new Button();
            btnRemoveTaskMain = new Button();
            progressBar = new ProgressBar();
            monthCalendar = new MonthCalendar();
            lblCompletedTasks = new Label();
            listViewTask = new ListView();
            button1 = new Button();
            btnClearAllMain = new Button();
            lblPendingTasks = new Label();
            button2 = new Button();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            UpdateDailyDoersProgress = new ProgressBar();
            MarkAsCompleted = new Button();
            timer = new System.Windows.Forms.Timer(components);
            btnRefresh = new Button();
            lblTotalTasks = new Label();
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
            progressBar.Click += progressBar_Click;
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
            listViewTask.Location = new Point(49, 256);
            listViewTask.Margin = new Padding(2);
            listViewTask.Name = "listViewTask";
            listViewTask.Size = new Size(402, 124);
            listViewTask.TabIndex = 17;
            listViewTask.UseCompatibleStateImageBehavior = false;
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
            // UpdateDailyDoersProgress
            // 
            UpdateDailyDoersProgress.Location = new Point(508, 50);
            UpdateDailyDoersProgress.Name = "UpdateDailyDoersProgress";
            UpdateDailyDoersProgress.Size = new Size(209, 27);
            UpdateDailyDoersProgress.TabIndex = 43;
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
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(100, 219);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 50;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 391);
            Controls.Add(btnRefresh);
            Controls.Add(lblTotalTasks);
            Controls.Add(MarkAsCompleted);
            Controls.Add(UpdateDailyDoersProgress);
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
        private Button button2;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private ProgressBar UpdateDailyDoersProgress;
        private Button MarkAsCompleted;
        private System.Windows.Forms.Timer timer;
        private Button btnRefresh;
        private Label lblTotalTasks;
    }
}

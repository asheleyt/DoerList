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
            btnLogout = new Button();
            numericUpDown1 = new NumericUpDown();
            lblUser = new Label();
            MarkAsCompleted = new Button();
            timer = new System.Windows.Forms.Timer(components);
            btnRefresh = new Button();
            lblTotalTasks = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // btnAddTaskMain
            // 
            btnAddTaskMain.BackColor = Color.Gainsboro;
            btnAddTaskMain.Font = new Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddTaskMain.Location = new Point(456, 255);
            btnAddTaskMain.Name = "btnAddTaskMain";
            btnAddTaskMain.Size = new Size(75, 30);
            btnAddTaskMain.TabIndex = 2;
            btnAddTaskMain.Text = "Add Task";
            btnAddTaskMain.UseVisualStyleBackColor = false;
            btnAddTaskMain.Click += btnAddTaskMain_Click;
            // 
            // btnRemoveTaskMain
            // 
            btnRemoveTaskMain.BackColor = Color.Gainsboro;
            btnRemoveTaskMain.Font = new Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemoveTaskMain.Location = new Point(456, 316);
            btnRemoveTaskMain.Name = "btnRemoveTaskMain";
            btnRemoveTaskMain.Size = new Size(82, 30);
            btnRemoveTaskMain.TabIndex = 3;
            btnRemoveTaskMain.Text = "Remove Task";
            btnRemoveTaskMain.UseVisualStyleBackColor = false;
            btnRemoveTaskMain.Click += btnRemoveTaskMain_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(565, 219);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(209, 27);
            progressBar.TabIndex = 4;
            progressBar.Click += progressBar_Click;
            // 
            // monthCalendar
            // 
            monthCalendar.BackColor = SystemColors.MenuBar;
            monthCalendar.Location = new Point(321, 80);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 5;
            // 
            // lblCompletedTasks
            // 
            lblCompletedTasks.AccessibleRole = AccessibleRole.None;
            lblCompletedTasks.AutoSize = true;
            lblCompletedTasks.Font = new Font("Rockwell", 14.25F);
            lblCompletedTasks.Location = new Point(565, 264);
            lblCompletedTasks.Name = "lblCompletedTasks";
            lblCompletedTasks.Size = new Size(95, 21);
            lblCompletedTasks.TabIndex = 6;
            lblCompletedTasks.Text = "Progress:";
            // 
            // listViewTask
            // 
            listViewTask.BackColor = SystemColors.AppWorkspace;
            listViewTask.Font = new Font("Rockwell", 10F);
            listViewTask.Location = new Point(49, 255);
            listViewTask.Margin = new Padding(2);
            listViewTask.Name = "listViewTask";
            listViewTask.Size = new Size(402, 124);
            listViewTask.TabIndex = 17;
            listViewTask.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Font = new Font("Rockwell", 10F);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(53, 214);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(36, 32);
            button1.TabIndex = 19;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnClearAllMain
            // 
            btnClearAllMain.BackColor = Color.Gainsboro;
            btnClearAllMain.Font = new Font("Rockwell", 11F);
            btnClearAllMain.Location = new Point(456, 351);
            btnClearAllMain.Margin = new Padding(2);
            btnClearAllMain.Name = "btnClearAllMain";
            btnClearAllMain.Size = new Size(82, 28);
            btnClearAllMain.TabIndex = 20;
            btnClearAllMain.Text = "Clear All Tasks";
            btnClearAllMain.UseVisualStyleBackColor = false;
            btnClearAllMain.Click += btnClearAllMain_Click;
            // 
            // lblPendingTasks
            // 
            lblPendingTasks.AccessibleRole = AccessibleRole.None;
            lblPendingTasks.AutoSize = true;
            lblPendingTasks.Font = new Font("Rockwell", 14.25F);
            lblPendingTasks.Location = new Point(565, 306);
            lblPendingTasks.Name = "lblPendingTasks";
            lblPendingTasks.Size = new Size(145, 21);
            lblPendingTasks.TabIndex = 21;
            lblPendingTasks.Text = "Pending Tasks:";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Gainsboro;
            btnLogout.Font = new Font("Rockwell", 11F);
            btnLogout.Location = new Point(733, 11);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(72, 34);
            btnLogout.TabIndex = 22;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(1376, 448);
            numericUpDown1.Margin = new Padding(2);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(126, 23);
            numericUpDown1.TabIndex = 27;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Rockwell", 14F);
            lblUser.Location = new Point(456, 17);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(62, 21);
            lblUser.TabIndex = 41;
            lblUser.Text = "User: ";
            // 
            // MarkAsCompleted
            // 
            MarkAsCompleted.BackColor = Color.Gainsboro;
            MarkAsCompleted.Font = new Font("Rockwell", 11F);
            MarkAsCompleted.Location = new Point(181, 215);
            MarkAsCompleted.Name = "MarkAsCompleted";
            MarkAsCompleted.Size = new Size(128, 28);
            MarkAsCompleted.TabIndex = 48;
            MarkAsCompleted.Text = "Mark as Done";
            MarkAsCompleted.UseVisualStyleBackColor = false;
            MarkAsCompleted.Click += MarkAsCompleted_Click;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Gainsboro;
            btnRefresh.Font = new Font("Rockwell", 11F);
            btnRefresh.Location = new Point(94, 215);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(81, 28);
            btnRefresh.TabIndex = 50;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblTotalTasks
            // 
            lblTotalTasks.AccessibleRole = AccessibleRole.None;
            lblTotalTasks.AutoSize = true;
            lblTotalTasks.Font = new Font("Rockwell", 14.25F);
            lblTotalTasks.Location = new Point(565, 351);
            lblTotalTasks.Name = "lblTotalTasks";
            lblTotalTasks.Size = new Size(111, 21);
            lblTotalTasks.TabIndex = 49;
            lblTotalTasks.Text = "Total Task: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Unispace", 39.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(283, 64);
            label1.TabIndex = 51;
            label1.Text = "DoerList";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 130);
            label2.Name = "label2";
            label2.Size = new Size(272, 18);
            label2.TabIndex = 52;
            label2.Text = "(Get Started By Adding Tasks Below)";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(807, 391);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRefresh);
            Controls.Add(lblTotalTasks);
            Controls.Add(MarkAsCompleted);
            Controls.Add(lblUser);
            Controls.Add(numericUpDown1);
            Controls.Add(btnLogout);
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
        private Button btnLogout;
        private NumericUpDown numericUpDown1;
        private Label lblUser;
        private Button MarkAsCompleted;
        private System.Windows.Forms.Timer timer;
        private Button btnRefresh;
        private Label lblTotalTasks;
        private Label label1;
        private Label label2;
    }
}

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
            label1 = new Label();
            listViewTask = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            textBox1 = new TextBox();
            button1 = new Button();
            btnClearAllMain = new Button();
            lblPendingTasks = new Label();
            button2 = new Button();
            comboBox2 = new ComboBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            btnReloadDailyTasks = new Button();
            chkDaily = new CheckBox();
            listBoxTasks = new ListBox();
            btnRemoveAll = new Button();
            btnRemove = new Button();
            btnAdd = new Button();
            txtTask = new TextBox();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // btnAddTaskMain
            // 
            btnAddTaskMain.Location = new Point(620, 163);
            btnAddTaskMain.Name = "btnAddTaskMain";
            btnAddTaskMain.Size = new Size(75, 23);
            btnAddTaskMain.TabIndex = 2;
            btnAddTaskMain.Text = "Add Task";
            btnAddTaskMain.UseVisualStyleBackColor = true;
            btnAddTaskMain.Click += btnAddTaskMain_Click;
            // 
            // btnRemoveTaskMain
            // 
            btnRemoveTaskMain.Location = new Point(711, 163);
            btnRemoveTaskMain.Name = "btnRemoveTaskMain";
            btnRemoveTaskMain.Size = new Size(87, 23);
            btnRemoveTaskMain.TabIndex = 3;
            btnRemoveTaskMain.Text = "Remove Task";
            btnRemoveTaskMain.UseVisualStyleBackColor = true;
            btnRemoveTaskMain.Click += btnRemoveTaskMain_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(590, 19);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(209, 27);
            progressBar.TabIndex = 4;
            // 
            // monthCalendar
            // 
            monthCalendar.Location = new Point(121, 9);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 5;
            // 
            // lblProgress
            // 
            lblProgress.AccessibleRole = AccessibleRole.None;
            lblProgress.AutoSize = true;
            lblProgress.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProgress.Location = new Point(590, 54);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(89, 25);
            lblProgress.TabIndex = 6;
            lblProgress.Text = "Progress:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 15;
            label1.Text = "Profile";
            // 
            // listViewTask
            // 
            listViewTask.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listViewTask.Location = new Point(397, 227);
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
            textBox1.Location = new Point(372, 175);
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
            button1.Location = new Point(481, 168);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(36, 32);
            button1.TabIndex = 19;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnClearAllMain
            // 
            btnClearAllMain.Location = new Point(719, 197);
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
            lblPendingTasks.Location = new Point(582, 107);
            lblPendingTasks.Name = "lblPendingTasks";
            lblPendingTasks.Size = new Size(133, 25);
            lblPendingTasks.TabIndex = 21;
            lblPendingTasks.Text = "Pending Tasks:";
            // 
            // button2
            // 
            button2.Location = new Point(104, 331);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(78, 20);
            button2.TabIndex = 22;
            button2.Text = "Log out";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(959, 508);
            comboBox2.Margin = new Padding(2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(129, 23);
            comboBox2.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(901, 509);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 39;
            label4.Text = "Priority: ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(959, 448);
            textBox2.Margin = new Padding(2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(129, 39);
            textBox2.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(881, 450);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 37;
            label3.Text = "Description:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(959, 409);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(106, 23);
            textBox3.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(884, 410);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 35;
            label5.Text = "Task Name:";
            // 
            // btnReloadDailyTasks
            // 
            btnReloadDailyTasks.Location = new Point(1070, 706);
            btnReloadDailyTasks.Name = "btnReloadDailyTasks";
            btnReloadDailyTasks.Size = new Size(104, 36);
            btnReloadDailyTasks.TabIndex = 34;
            btnReloadDailyTasks.Text = "Relaod Dailys";
            btnReloadDailyTasks.UseVisualStyleBackColor = true;
            // 
            // chkDaily
            // 
            chkDaily.AutoSize = true;
            chkDaily.Location = new Point(1201, 473);
            chkDaily.Name = "chkDaily";
            chkDaily.Size = new Size(83, 19);
            chkDaily.TabIndex = 33;
            chkDaily.Text = "checkBox1";
            chkDaily.UseVisualStyleBackColor = true;
            // 
            // listBoxTasks
            // 
            listBoxTasks.FormattingEnabled = true;
            listBoxTasks.ItemHeight = 15;
            listBoxTasks.Location = new Point(732, 569);
            listBoxTasks.Name = "listBoxTasks";
            listBoxTasks.Size = new Size(211, 124);
            listBoxTasks.TabIndex = 32;
            // 
            // btnRemoveAll
            // 
            btnRemoveAll.Location = new Point(960, 706);
            btnRemoveAll.Name = "btnRemoveAll";
            btnRemoveAll.Size = new Size(104, 36);
            btnRemoveAll.TabIndex = 31;
            btnRemoveAll.Text = "Remove All";
            btnRemoveAll.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(838, 706);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(104, 36);
            btnRemove.TabIndex = 30;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(728, 706);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(104, 36);
            btnAdd.TabIndex = 29;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtTask
            // 
            txtTask.Location = new Point(1201, 448);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(100, 23);
            txtTask.TabIndex = 28;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(1376, 448);
            numericUpDown1.Margin = new Padding(2);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(126, 23);
            numericUpDown1.TabIndex = 27;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1373, 410);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(129, 23);
            comboBox1.TabIndex = 26;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(1119, 407);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(211, 23);
            dateTimePicker1.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(711, 400);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(112, 30);
            label6.TabIndex = 23;
            label6.Text = "DailyDoer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 43);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 41;
            label2.Text = "label2";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1557, 772);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(btnReloadDailyTasks);
            Controls.Add(chkDaily);
            Controls.Add(listBoxTasks);
            Controls.Add(btnRemoveAll);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(txtTask);
            Controls.Add(numericUpDown1);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(lblPendingTasks);
            Controls.Add(btnClearAllMain);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(listViewTask);
            Controls.Add(label1);
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
        private Label label1;
        private ListView listViewTask;
        private TextBox textBox1;
        private Button button1;
        private Button btnClearAllMain;
        private Label lblPendingTasks;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button button2;
        private ComboBox comboBox2;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label5;
        private Button btnReloadDailyTasks;
        private CheckBox chkDaily;
        private ListBox listBoxTasks;
        private Button btnRemoveAll;
        private Button btnRemove;
        private Button btnAdd;
        private TextBox txtTask;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private Label label2;
    }
}

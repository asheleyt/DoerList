namespace DoerList
{
    partial class AddTaskForm
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
            label1 = new Label();
            label2 = new Label();
            txtTaskName = new TextBox();
            datePickerDueDate = new DateTimePicker();
            btnAddTask = new Button();
            btnCancel = new Button();
            timePickerDueTime = new DateTimePicker();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 11F);
            label1.Location = new Point(56, 59);
            label1.Name = "label1";
            label1.Size = new Size(90, 17);
            label1.TabIndex = 0;
            label1.Text = "Task Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 11F);
            label2.Location = new Point(64, 118);
            label2.Name = "label2";
            label2.Size = new Size(82, 17);
            label2.TabIndex = 1;
            label2.Text = "Due Date: ";
            // 
            // txtTaskName
            // 
            txtTaskName.Font = new Font("Rockwell", 11F);
            txtTaskName.Location = new Point(146, 54);
            txtTaskName.Name = "txtTaskName";
            txtTaskName.Size = new Size(179, 25);
            txtTaskName.TabIndex = 2;
            // 
            // datePickerDueDate
            // 
            datePickerDueDate.CustomFormat = "MM/dd/yyyy hh:mm tt";
            datePickerDueDate.Font = new Font("Rockwell", 11F);
            datePickerDueDate.Format = DateTimePickerFormat.Custom;
            datePickerDueDate.Location = new Point(146, 118);
            datePickerDueDate.Name = "datePickerDueDate";
            datePickerDueDate.Size = new Size(200, 25);
            datePickerDueDate.TabIndex = 3;
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = Color.Gainsboro;
            btnAddTask.Font = new Font("Rockwell", 11F);
            btnAddTask.Location = new Point(146, 236);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(92, 30);
            btnAddTask.TabIndex = 4;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = false;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Gainsboro;
            btnCancel.Font = new Font("Rockwell", 11F);
            btnCancel.Location = new Point(283, 236);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 30);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // timePickerDueTime
            // 
            timePickerDueTime.CustomFormat = "HH:mm";
            timePickerDueTime.Font = new Font("Rockwell", 11F);
            timePickerDueTime.Format = DateTimePickerFormat.Custom;
            timePickerDueTime.Location = new Point(146, 176);
            timePickerDueTime.Name = "timePickerDueTime";
            timePickerDueTime.ShowUpDown = true;
            timePickerDueTime.Size = new Size(200, 25);
            timePickerDueTime.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 11F);
            label3.Location = new Point(61, 176);
            label3.Name = "label3";
            label3.Size = new Size(85, 17);
            label3.TabIndex = 46;
            label3.Text = "Due Time: ";
            // 
            // AddTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(508, 321);
            Controls.Add(label3);
            Controls.Add(timePickerDueTime);
            Controls.Add(btnCancel);
            Controls.Add(btnAddTask);
            Controls.Add(datePickerDueDate);
            Controls.Add(txtTaskName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddTaskForm";
            Text = "AddTaskForm";
            Load += AddTaskForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTaskName;
        private DateTimePicker datePickerDueDate;
        private Button btnAddTask;
        private Button btnCancel;
        private DateTimePicker timePickerDueTime;
        private Label label3;
    }
}
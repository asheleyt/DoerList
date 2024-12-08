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
            label1.Location = new Point(83, 48);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "Task Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 153);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 1;
            label2.Text = "Due Date: ";
            // 
            // txtTaskName
            // 
            txtTaskName.Location = new Point(157, 45);
            txtTaskName.Name = "txtTaskName";
            txtTaskName.Size = new Size(100, 23);
            txtTaskName.TabIndex = 2;
            // 
            // datePickerDueDate
            // 
            datePickerDueDate.CustomFormat = "MM/dd/yyyy hh:mm tt";
            datePickerDueDate.Format = DateTimePickerFormat.Custom;
            datePickerDueDate.Location = new Point(146, 147);
            datePickerDueDate.Name = "datePickerDueDate";
            datePickerDueDate.Size = new Size(200, 23);
            datePickerDueDate.TabIndex = 3;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(83, 264);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(75, 23);
            btnAddTask.TabIndex = 4;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(256, 264);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // timePickerDueTime
            // 
            timePickerDueTime.CustomFormat = "HH:mm";
            timePickerDueTime.Format = DateTimePickerFormat.Custom;
            timePickerDueTime.Location = new Point(146, 196);
            timePickerDueTime.Name = "timePickerDueTime";
            timePickerDueTime.ShowUpDown = true;
            timePickerDueTime.Size = new Size(200, 23);
            timePickerDueTime.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 202);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 46;
            label3.Text = "Due Time: ";
            // 
            // AddTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
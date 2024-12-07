namespace DoerList
{
    partial class DailyDoerUI
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
            label4 = new Label();
            txtTask = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btnBack = new Button();
            chkDaily = new CheckBox();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            listViewDailyTasks = new ListView();
            numericUpDown2 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(20, 20);
            label4.Name = "label4";
            label4.Size = new Size(93, 19);
            label4.TabIndex = 0;
            label4.Text = "Daily Task List";
            // 
            // txtTask
            // 
            txtTask.Location = new Point(20, 270);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(300, 23);
            txtTask.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(340, 270);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(359, 20);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.Click += btnBack_Click;
            // 
            // chkDaily
            // 
            chkDaily.AutoSize = true;
            chkDaily.Location = new Point(20, 310);
            chkDaily.Name = "chkDaily";
            chkDaily.Size = new Size(129, 19);
            chkDaily.TabIndex = 5;
            chkDaily.Text = "Mark as Completed";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(0, 0);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.Location = new Point(0, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // label5
            // 
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 0;
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 0;
            // 
            // listViewDailyTasks
            // 
            listViewDailyTasks.Location = new Point(20, 50);
            listViewDailyTasks.Name = "listViewDailyTasks";
            listViewDailyTasks.Size = new Size(300, 200);
            listViewDailyTasks.TabIndex = 0;
            listViewDailyTasks.UseCompatibleStateImageBehavior = false;
            listViewDailyTasks.View = View.Details;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(408, 84);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 6;
            // 
            // DailyDoerUI
            // 
            ClientSize = new Size(569, 333);
            Controls.Add(numericUpDown2);
            Controls.Add(listViewDailyTasks);
            Controls.Add(label4);
            Controls.Add(txtTask);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnBack);
            Controls.Add(chkDaily);
            Name = "DailyDoerUI";
            Text = "Daily Doers";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox txtTask;
        private DateTimePicker dateTimePicker1;
        private Button btnBack;
        private CheckBox chkDaily;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private Label label5;
        private Label label3;
        private ListView listViewDailyTasks;
        private NumericUpDown numericUpDown2;
    }
}
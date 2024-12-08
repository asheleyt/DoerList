
using Tulpep.NotificationWindow;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.VisualBasic;


namespace DoerList
{
    public partial class MainForm : Form
    {
        public string TaskName { get; private set; }
        public DateTime DueDate { get; private set; }
        public TimeSpan DueTime { get; private set; }


        private List<TaskItem> tasks = new List<TaskItem>();
        private PopupNotifier notification;
        private string loggedInUsername;
        private string taskFilePath = "tasks.txt";
        private System.Windows.Forms.Timer taskTimer;
        private string currentUsername;
        public MainForm(String username)
        {
            InitializeComponent();
            InitializeTaskTimer();
            loggedInUsername = username;
            UpdateTaskSummary();
            taskFilePath = Path.Combine(Application.StartupPath, "tasks.txt");
            currentUsername = username;
            lblUser.Text = $"User: {currentUsername}";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBoxNewTask_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            notification = new PopupNotifier
            {
                TitleText = "Task Manager",
                Delay = 5000
            };

            LoadTasksFromFile();
            UpdateTaskList();
            UpdateProgressBar();
            HighlightTaskDates();
            StartTaskReminderTimer();

            listViewTask.View = View.Details;
            listViewTask.Columns.Add("Task Name", 200);
            listViewTask.Columns.Add("Due Date", 100);
            listViewTask.Columns.Add("Due Time", 100);


            listViewTask.FullRowSelect = true;
            listViewTask.GridLines = true;

        

        }

        private void StartTaskReminderTimer()
        {
            System.Windows.Forms.Timer taskReminderTimer = new System.Windows.Forms.Timer
            {
                Interval = 60000
            };
            taskReminderTimer.Tick += TaskReminderTimer_Tick;
            taskReminderTimer.Start();
        }
        private void TaskReminderTimer_Tick(object sender, EventArgs e)
        {
            foreach (var task in tasks)
            {
                if (!task.IsCompleted)
                {
                    if (task.DueDate.Date == DateTime.Today.AddDays(1))
                    {
                        ShowNotification($"Task '{task.Name}' is due tomorrow!", NotificationType.Warning);
                    }
                    else if (task.DueDate.Date == DateTime.Today && task.DueDate.Hour == DateTime.Now.Hour)
                    {
                        ShowNotification($"Task '{task.Name}' is due soon at {task.DueDate.ToShortTimeString()}!", NotificationType.Info);
                    }
                    else if (task.DueDate.Date < DateTime.Today)
                    {
                        ShowNotification($"Task '{task.Name}' is overdue!", NotificationType.Error);
                    }
                }
            }
        }

        private void UpdateTaskList()
        {
            listViewTask.Items.Clear();
            foreach (var task in tasks)
            {
                if (!task.IsCompleted)
                {
                    ListViewItem item = new ListViewItem(task.Name);
                    item.SubItems.Add(task.DueDate.ToShortDateString());
                    item.SubItems.Add(task.DueTime.ToString(@"hh\:mm"));
                    listViewTask.Items.Add(item);
                }
            }
        }
        private void UpdateProgressBar()
        {
            DateTime currentTime = DateTime.Now;

            int totalTasks = tasks.Count;
            int completedTasks = tasks.Count(t => t.IsCompleted);
            int progressValue = totalTasks > 0 ? (completedTasks * 100) / totalTasks : 0;

            progressBar.Value = Math.Min(progressValue, 100);
            lblCompletedTasks.Text = $"Completed: {completedTasks}/{totalTasks}";

            Debug.WriteLine($"Progress Updated: Total={totalTasks}, Completed={completedTasks}, Progress={progressValue}%");

            foreach (var task in tasks.ToList())
            {

                if (!task.IsCompleted &&
                    task.DueDate.Date == currentTime.Date &&
                    task.DueTime - currentTime.TimeOfDay <= TimeSpan.FromMinutes(5) &&
                    !task.Notified)
                {
                    ShowNotification($"Task Due Soon: {task.Name}", NotificationType.Warning);
                    task.Notified = true; 
                }

            
                if (!task.IsCompleted &&
                    task.DueDate.Date == currentTime.Date &&
                    task.DueTime <= currentTime.TimeOfDay)
                {
                    task.IsCompleted = true;
                    SaveTasksToFile(); 
                    UpdateProgressBar();
                    RemoveTask(task); 
                }
            }

            RefreshListView();
        }

        private void UpdateTaskCounts()
        {
            int totalTasks = tasks.Count;
            int pendingTasks = tasks.Count(t => !t.IsCompleted);

            lblTotalTasks.Text = $"Total Tasks: {totalTasks}";
            lblPendingTasks.Text = $"Pending Tasks: {pendingTasks}";
        }

        private void UpdatePendingTasks()
        {
            int pendingTasks = tasks.Count(t => !t.IsCompleted);
            lblPendingTasks.Text = $"Pending Tasks: {pendingTasks}";
        }
        private void HighlightTaskDates()
        {
            monthCalendar.RemoveAllBoldedDates();
            foreach (var task in tasks)
            {
                if (!task.IsCompleted)
                {
                    monthCalendar.AddBoldedDate(task.DueDate);
                }
            }
            monthCalendar.UpdateBoldedDates();
        }

        private void btnAddTaskMain_Click(object sender, EventArgs e)
        {
            using (AddTaskForm addTaskForm = new AddTaskForm())
            {
                if (addTaskForm.ShowDialog() == DialogResult.OK)
                {
                    string taskName = addTaskForm.TaskName;
                    DateTime dueDate = addTaskForm.DueDate;
                    TimeSpan dueTime = addTaskForm.DueTime;

                    if (tasks.Any(task => task.Name.Equals(taskName, StringComparison.OrdinalIgnoreCase)))
                    {
                        MessageBox.Show("A task with the same name already exists.", "Duplicate Task", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    tasks.Add(new TaskItem(taskName, dueDate, dueTime)
                    {
                        IsCompleted = false
                    });

                    SaveTasksToFile();
                    UpdateTaskList();
                    UpdateProgressBar();
                    UpdateTaskCounts(); 
                    HighlightTaskDates();
                    ShowNotification("Task added successfully!", NotificationType.Success);
                }
            }
        }


        private void btnRemoveTaskMain_Click(object sender, EventArgs e)
        {
            if (listViewTask.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewTask.SelectedItems[0];
                string taskName = selectedItem.Text;

                TaskItem taskToRemove = tasks.FirstOrDefault(t => t.Name == taskName);
                if (taskToRemove != null)
                {
 
                    RemoveTask(taskToRemove);
                }
            }
            else
            {
                MessageBox.Show("Please select a task to remove.", "Remove Task", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            UpdateProgressBar();
        }

        private void btnClearAllMain_Click(object sender, EventArgs e)
        {
            if (tasks.Count > 0)
            {
                DialogResult confirmResult = MessageBox.Show(
                    "Are you sure you want to clear all tasks?",
                    "Confirm Clear All",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    tasks.Clear();
                    SaveTasksToFile();
                    UpdateTaskList();
                    UpdateProgressBar();
                    ShowNotification("All tasks cleared successfully!", NotificationType.Success);
                }
            }
            else
            {
                ShowNotification("No tasks to clear!", NotificationType.Info);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {//btnSearch
            string searchTerm = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter search term:", "Search Task", "", -1, -1);

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                foreach (ListViewItem item in listViewTask.Items)
                {
                    item.Selected = item.Text.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0;
                }

                int selectedCount = listViewTask.SelectedItems.Count;
                if (selectedCount > 0)
                {
                    ShowNotification($"Found {selectedCount} matching task(s).", NotificationType.Info);
                }
                else
                {
                    ShowNotification($"No tasks found matching \"{searchTerm}\".", NotificationType.Info);
                }
            }
            else
            {
                ShowNotification("Search term cannot be empty!", NotificationType.Warning);
            }

        }

        private void ShowNotification(string message, NotificationType type)
        {
            notification.TitleText = "Task Manager";
            notification.ContentText = message;

            switch (type)
            {
                case NotificationType.Success:
                    notification.BodyColor = Color.LightGreen;
                    break;
                case NotificationType.Warning:
                    notification.BodyColor = Color.Orange;
                    break;
                case NotificationType.Error:
                    notification.BodyColor = Color.Red;
                    break;
                case NotificationType.Info:
                    notification.BodyColor = Color.LightBlue;
                    break;
            }

            notification.Delay = 5000;
            notification.Popup();
        }

        private void SaveTasksToFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(taskFilePath))
                {
                    foreach (var task in tasks)
                    {

                        string line = $"{task.Name}|{task.DueDate:yyyy-MM-dd}|{task.DueTime}|{task.IsCompleted}";
                        writer.WriteLine(line);
                    }
                }
                ShowNotification("Tasks saved successfully!", NotificationType.Success);
            }
            catch (Exception ex)
            {
                ShowNotification($"Error saving tasks: {ex.Message}", NotificationType.Error);
            }
        }
        private void LoadTasksFromFile()
        {
            try
            {
                if (File.Exists(taskFilePath))
                {
                    tasks.Clear(); 

                    using (StreamReader reader = new StreamReader(taskFilePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {

                            var parts = line.Split('|');
                            if (parts.Length == 4)
                            {
                                string name = parts[0];
                                DateTime dueDate = DateTime.Parse(parts[1]);
                                TimeSpan dueTime = TimeSpan.Parse(parts[2]);
                                bool isCompleted = bool.Parse(parts[3]);

                                tasks.Add(new TaskItem(name, dueDate, dueTime) { IsCompleted = isCompleted });
                            }
                        }
                    }

                   
                    UpdateTaskList();
                    UpdateProgressBar();
                    UpdateTaskCounts(); 
                    ShowNotification("Tasks loaded successfully!", NotificationType.Success);
                }
                else
                {
                    ShowNotification("No tasks file found. Starting fresh.", NotificationType.Info);
                }
            }
            catch (Exception ex)
            {
                ShowNotification($"Error loading tasks: {ex.Message}", NotificationType.Error);
            }
        }

        public enum NotificationType
        {
            Success,
            Warning,
            Error,
            Info
        }
        public class TaskItem
        {
            public string Name { get; set; }
            public DateTime DueDate { get; set; }
            public TimeSpan DueTime { get; set; }
            public bool IsCompleted { get; set; }
            public bool IsNotified { get; set; }

            public bool Notified { get; set; } = false;

            public TaskItem(string name, DateTime dueDate, TimeSpan dueTime, bool isCompleted = false)
            {
                Name = name ?? throw new ArgumentNullException(nameof(name));
                DueDate = dueDate;
                DueTime = dueTime;
                IsCompleted = isCompleted;
                IsNotified = false;
            }

        }
        private void DisplayDailySummary()
        {
            int pendingTasks = tasks.Count(t => !t.IsCompleted && t.DueDate.Date == DateTime.Today);
            int completedTasks = tasks.Count(t => t.IsCompleted && t.DueDate.Date == DateTime.Today);

            ShowNotification($"Today's Summary:\nPending Tasks: {pendingTasks}\nCompleted Tasks: {completedTasks}", NotificationType.Info);
        }

        private void MarkAsCompleted_Click(object sender, EventArgs e)
        {
            if (listViewTask.SelectedItems.Count > 0)
            {
                foreach (ListViewItem selectedItem in listViewTask.SelectedItems)
                {
                    var task = tasks.FirstOrDefault(t => t.Name == selectedItem.Text);
                    if (task != null)
                    {
                        task.IsCompleted = true;
                    }
                }
                SaveTasksToFile();
                UpdateTaskList();
                UpdateProgressBar();
                UpdatePendingTasks();
                ShowNotification("Selected task(s) marked as completed!", NotificationType.Success);
            }
            else
            {
                ShowNotification("Please select a task to mark as completed!", NotificationType.Warning);
            }
        }

        private void UpdateTaskSummary()
        {

            int totalTasks = tasks.Count;
            int completedTasks = tasks.Count(t => t.IsCompleted);
            int pendingTasks = totalTasks - completedTasks;


            lblTotalTasks.Text = $"Total Tasks: {totalTasks}";
            lblCompletedTasks.Text = $"Completed Tasks: {completedTasks}";
            lblPendingTasks.Text = $"Pending Tasks: {pendingTasks}";
        }

        private void DisplayTasks()
        {
            listViewTask.Items.Clear();

            foreach (var task in tasks)
            {
                ListViewItem listItem = new ListViewItem(task.Name);
                listItem.SubItems.Add(task.DueDate.ToShortDateString());
                listItem.SubItems.Add(task.DueTime.ToString(@"hh\:mm"));
                listItem.SubItems.Add(task.IsCompleted ? "Completed" : "Pending");

                listViewTask.Items.Add(listItem);
            }
        }

        private void InitializeTaskTimer()
        {
            taskTimer = new System.Windows.Forms.Timer();
            taskTimer.Interval = 60000;
            taskTimer.Tick += timer_Tick;
            taskTimer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;

            foreach (var task in tasks.ToList())
            {
                if (!task.IsCompleted && DateTime.Now >= task.DueDate + task.DueTime)
                {
                    task.IsCompleted = true;
                    RemoveTask(task); 
                    ShowNotification($"Task '{task.Name}' marked as completed!", NotificationType.Info);
                }


             
                if (!task.IsCompleted &&
                        task.DueDate.Date == currentTime.Date &&
                        task.DueTime <= currentTime.TimeOfDay)
                {
                    task.IsCompleted = true;
                    UpdateProgressBar();
                    RemoveTask(task); 
                }
            }
            RefreshListView();
        }





        private void RemoveTaskFromListView(TaskItem task)
        {
            tasks.Remove(task);


            foreach (ListViewItem item in listViewTask.Items)
            {
                if (item.Text == task.Name)
                {
                    listViewTask.Items.Remove(item);
                    break;
                }
            }
            UpdateProgressBar();
        }

        private void RefreshListView()
        {
       
            listViewTask.Items.Clear();

           
            foreach (var task in tasks)
            {
                ListViewItem listItem = new ListViewItem(task.Name);
                listItem.SubItems.Add(task.DueDate.ToShortDateString());
                listItem.SubItems.Add(task.DueTime.ToString(@"hh\:mm"));
                listViewTask.Items.Add(listItem);
            }
            foreach (var task in tasks)
            {
                if (!task.IsCompleted && task.DueDate.Date == DateTime.Today)
                {
                    ListViewItem listItem = new ListViewItem(task.Name);
                    listItem.SubItems.Add(task.DueDate.ToShortDateString());
                    listItem.SubItems.Add(task.DueTime.ToString(@"hh\:mm"));
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            listViewTask.Items.Clear();

            foreach (var task in tasks)
            {
                if (!task.IsCompleted)
                {
                    var listItem = new ListViewItem(task.Name);
                    listItem.SubItems.Add(task.DueDate.ToShortDateString());
                    listItem.SubItems.Add(task.DueTime.ToString(@"hh\:mm"));
                    listViewTask.Items.Add(listItem);
                }
            }
        }

        private void RemoveTask(TaskItem task)
        {
            if (tasks.Remove(task)) 
            {
                
                foreach (ListViewItem item in listViewTask.Items)
                {
                    if (item.Text == task.Name)
                    {
                        listViewTask.Items.Remove(item);
                        break;
                    }
                }
                tasks.Remove(task);
                SaveTasksToFile();
                UpdateTaskList();
                UpdateProgressBar();
                ShowNotification($"Task '{task.Name}' removed successfully!", NotificationType.Success);
            }
            else
            {
                ShowNotification("Error: Task not found!", NotificationType.Error);
            }
        }


        private void CompleteTask(TaskItem task)
        {
            task.IsCompleted = true; 
            SaveTasksToFile(); 
            UpdateTaskList(); 
            UpdateProgressBar(); 
            Debug.WriteLine($"Task Completed: {task.Name}");
        }

        private void progressBar_Click(object sender, EventArgs e)
        {
            tasks.Add(new TaskItem("Test Task 1", DateTime.Now, TimeSpan.Zero) { IsCompleted = false });
            tasks.Add(new TaskItem("Test Task 2", DateTime.Now, TimeSpan.Zero) { IsCompleted = false });
            tasks.Add(new TaskItem("Test Task 3", DateTime.Now, TimeSpan.Zero) { IsCompleted = true });

            Debug.WriteLine($"Tasks: {tasks.Count}, Completed: {tasks.Count(t => t.IsCompleted)}");
            UpdateProgressBar(); 
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close(); 
            }
            else
            {
              return;
            }
        }







    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static DoerList.MainForm;

namespace DoerList
{
    public static class FileDatabaseHelper
    {
        private static string usersFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.txt");
        private static string tasksFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tasks.txt");

        public static void Initialize()
        {
            if (!File.Exists(usersFile))
                File.Create(usersFile).Close();

            if (!File.Exists(tasksFile))
                File.Create(tasksFile).Close();
        }

        public static bool RegisterUser(string username, string password)
        {
            if (!IsValidPassword(password))
            {
                System.Windows.Forms.MessageBox.Show(
                    "Password must be at least 8 characters long, with a letter, number, and special character.",
                    "Invalid Password",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Warning);
                return false;
            }

            foreach (var line in File.ReadLines(usersFile))
            {
                var parts = line.Split('|');
                if (parts[0] == username)
                    return false;
            }

            File.AppendAllText(usersFile, $"{username}|{password}{Environment.NewLine}");
            return true;
        }

        public static bool ValidateUser(string username, string password)
        {
            foreach (var line in File.ReadLines(usersFile))
            {
                var parts = line.Split('|');
                if (parts[0] == username && parts[1] == password)
                    return true;
            }
            return false;
        }

        public static bool ChangePassword(string username, string currentPassword, string newPassword)
        {
            var lines = File.ReadAllLines(usersFile);
            for (int i = 0; i < lines.Length; i++)
            {
                var parts = lines[i].Split('|');
                if (parts[0] == username && parts[1] == currentPassword)
                {
                    if (!IsValidPassword(newPassword))
                    {
                        System.Windows.Forms.MessageBox.Show(
                            "Password must be at least 8 characters long, with a letter, number, and special character.",
                            "Invalid Password",
                            System.Windows.Forms.MessageBoxButtons.OK,
                            System.Windows.Forms.MessageBoxIcon.Warning);
                        return false;
                    }

                    lines[i] = $"{username}|{newPassword}";
                    File.WriteAllLines(usersFile, lines);
                    return true;
                }
            }

            return false;
        }

        public static bool IsValidPassword(string password)
        {
            if (password.Length < 8)
                return false;

            bool hasLetter = false, hasDigit = false, hasSpecial = false;
            foreach (char ch in password)
            {
                if (char.IsLetter(ch)) hasLetter = true;
                if (char.IsDigit(ch)) hasDigit = true;
                if (!char.IsLetterOrDigit(ch)) hasSpecial = true;
            }

            return hasLetter && hasDigit && hasSpecial;
        }


        public static List<TaskItem> LoadTasks(string username)
        {
            var tasks = new List<TaskItem>();

            foreach (var line in File.ReadLines(tasksFile))
            {
                var parts = line.Split('|');
                if (parts.Length == 4) // Ensure the file matches the new format
                {
                    string name = parts[0];
                    DateTime dueDate = DateTime.Parse(parts[1]);
                    TimeSpan dueTime = TimeSpan.Parse(parts[2]);
                    bool isCompleted = bool.Parse(parts[3]);

                    tasks.Add(new TaskItem(name, dueDate, dueTime, isCompleted));
                }
            }

            return tasks;
        }

        public static void SaveTask(string username, TaskItem task)
        {
            File.AppendAllText(tasksFile, $"{username}|{task.Name}|{task.DueDate:yyyy-MM-dd}|{task.IsCompleted}{Environment.NewLine}");
        }

        public static void RemoveTask(string username, string taskName)
        {
            var lines = new List<string>(File.ReadAllLines(tasksFile));
            lines.RemoveAll(line =>
            {
                var parts = line.Split('|');
                return parts[0] == username && parts[1] == taskName;
            });

            File.WriteAllLines(tasksFile, lines);
        }
    }
}

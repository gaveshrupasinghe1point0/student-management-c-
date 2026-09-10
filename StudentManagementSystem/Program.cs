using StudentManagementSystem.Forms;
using System;
using System.IO;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Point |DataDirectory| to the project root directory when running inside bin\Debug
            // so database changes persist to StudentDB.mdf directly in the project folder.
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string projectDir = Path.GetFullPath(Path.Combine(baseDir, @"..\..\"));
            if (File.Exists(Path.Combine(projectDir, "StudentDB.mdf")))
            {
                AppDomain.CurrentDomain.SetData("DataDirectory", projectDir);
            }
            else
            {
                AppDomain.CurrentDomain.SetData("DataDirectory", baseDir);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Show login first. Only open the main menu if login succeeds.
            using (var login = new LoginForm())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new AdminDashboardForm());
                }
            }
        }
    }
}

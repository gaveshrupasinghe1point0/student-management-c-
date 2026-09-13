using StudentManagementSystem.Forms;
using System;
using System.IO;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
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

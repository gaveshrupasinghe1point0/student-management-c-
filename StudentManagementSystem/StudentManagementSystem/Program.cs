using System;
using System.Windows.Forms;
using StudentManagementSystem.Forms;

namespace StudentManagementSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // TODO (Member 1 - Auth module): show a LoginForm first,
            // and only open MainMenuForm after a successful login.
            Application.Run(new MainMenuForm());
        }
    }
}

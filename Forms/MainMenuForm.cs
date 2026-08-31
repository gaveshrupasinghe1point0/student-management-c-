using System;
using System.Windows.Forms;

namespace StudentManagementSystem.Forms
{
    /// <summary>
    /// Central hub form. Owned by: Member 1 (or the Leader) as part of shared infrastructure.
    /// Each member adds ONE button here that opens their own form.
    /// This is the ONLY file where merge conflicts are likely (everyone adds a button) -
    /// coordinate before editing this file, or use separate methods per person.
    /// </summary>
    public class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            Text = "Student Management System";
            Width = 500;
            Height = 500;

            AddMenuButton("Student Records", 20, (s, e) =>
            {
                // Member 2: replace with `new StudentRecordsForm().Show();`
                MessageBox.Show("Student Records module - not implemented yet.");
            });

            AddMenuButton("Courses", 70, (s, e) =>
            {
                // Member 3: replace with `new CourseManagementForm().Show();`
                MessageBox.Show("Course Management module - not implemented yet.");
            });

            AddMenuButton("Attendance", 120, (s, e) =>
            {
                // Member 4: replace with `new AttendanceForm().Show();`
                MessageBox.Show("Attendance module - not implemented yet.");
            });

            AddMenuButton("Grades", 170, (s, e) =>
            {
                // Member 5: replace with `new GradesForm().Show();`
                MessageBox.Show("Grades module - not implemented yet.");
            });

            AddMenuButton("Fees", 220, (s, e) =>
            {
                // Member 6: replace with `new FeesForm().Show();`
                MessageBox.Show("Fees module - not implemented yet.");
            });

            AddMenuButton("Timetable", 270, (s, e) =>
            {
                // Member 7: replace with `new TimetableForm().Show();`
                MessageBox.Show("Timetable module - not implemented yet.");
            });

            AddMenuButton("Reports & Dashboard", 320, (s, e) =>
            {
                // Member 8: replace with `new DashboardForm().Show();`
                MessageBox.Show("Reports module - not implemented yet.");
            });
        }

        private void AddMenuButton(string label, int top, EventHandler onClick)
        {
            var button = new Button
            {
                Text = label,
                Top = top,
                Left = 130,
                Width = 220,
                Height = 35
            };
            button.Click += onClick;
            Controls.Add(button);
        }
    }
}

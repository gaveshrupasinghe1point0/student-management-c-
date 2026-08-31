# Student Management System — Project Skeleton

This is the shared "bone structure" for CS107.3 coursework. It contains the
core classes, interfaces, exceptions, and DB helper that **everyone builds
on top of**. Nobody should duplicate these — extend them instead.

## How to use this

1. Create a new **Windows Forms App (.NET Framework or .NET)** project in
   Visual Studio.
2. Copy these folders into your project: `Core/`, `Forms/`, `Program.cs`.
3. Install NuGet package `System.Data.SqlClient` (for `DatabaseHelper.cs`).
4. Run the app — `MainMenuForm` should open with 7 placeholder buttons.
5. Push this to the shared GitHub repo as the first commit. Everyone clones
   from here and creates their own feature branch.

## Folder structure

```
StudentManagementSystem/
├── Core/
│   ├── Models/          <- Person, Student, Teacher, Admin, Course
│   ├── Interfaces/      <- IAttendable, IGradable, IPayable
│   ├── Exceptions/      <- Custom exceptions used across modules
│   └── Data/            <- DatabaseHelper (single shared DB access point)
├── Forms/
│   └── MainMenuForm.cs  <- Hub that launches every member's form
├── Program.cs
└── README.md
```

## Who owns what (map this to your 8 members)

| Member | Module            | Where to add your code                                             |
|--------|-------------------|----------------------------------------------------------------------|
| 1      | Auth / Roles       | New `Forms/LoginForm.cs`; wire into `Program.cs` before MainMenu     |
| 2      | Student Records    | New `Forms/StudentRecordsForm.cs`; extend `Models/Student.cs`        |
| 3      | Courses            | New `Forms/CourseManagementForm.cs`; extend `Models/Course.cs`       |
| 4      | Attendance         | New `Forms/AttendanceForm.cs`; use `IAttendable` on `Student`        |
| 5      | Grades             | New `Forms/GradesForm.cs`; use `IGradable` on `Student`              |
| 6      | Fees               | New `Forms/FeesForm.cs`; use `IPayable` on `Student`                 |
| 7      | Timetable          | New `Forms/TimetableForm.cs`; use `Course.AssignedTeacher`           |
| 8      | Reports/Dashboard  | New `Forms/DashboardForm.cs`; queries across all of the above        |

## Ground rules

- **Don't edit `Core/Models`, `Core/Interfaces`, or `Core/Data` alone** —
  these are shared. If you need a new field/method, ask in the group chat
  first so nobody's changes overwrite someone else's.
- **Your own form file is yours** — create it under `Forms/YourModuleForm.cs`
  and only you should be editing it day-to-day.
- Wire your finished form into `MainMenuForm.cs` by replacing your
  placeholder `MessageBox.Show(...)` line with `new YourForm().Show();`.
  Coordinate with the leader before pushing changes to this file since
  everyone touches it.
- Always wrap DB calls in try/catch and throw one of the custom exceptions
  in `Core/Exceptions` where appropriate — this is graded.
- Commit under your own name/account regularly — this is your evidence
  for the "Individual Contribution" rubric line.

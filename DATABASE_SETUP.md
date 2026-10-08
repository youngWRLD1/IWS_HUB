# IWS Hub Database Setup

The project has been standardized on **SQL Server / SQL Express**. The previous `Database.cs` was using SQLite while the forms were using `System.Data.SqlClient`, which made the project incompatible.

## What was fixed

- One connection system is now used by every form: `Database.GetConnection()`.
- `DatabaseMode` in `App.config` controls Local vs Remote connection selection.
- Replaced the old/mismatched `Groups` table references with `GroupPosts`.
- Replaced the misspelled `Descriptin` field with `Description`.
- Added the fields already collected by Sign Up: phone number, title and gender.
- Added `CourseCode` and `Semester` for the Past Papers library.
- Added `UploadedAt` and `CreatedAt` timestamps.
- Added `Admin` and `SearchHistory` tables.
- Added indexes for common searches.
- Fixed the duplicate `UserData` class.
- Updated startup to initialize the required tables before opening the application.
- Updated the Admin Dashboard queries to use the actual database columns.
- Updated Past Papers queries to use explicit columns instead of `SELECT *`.

## Setup

1. Open `SQLQuery1.sql` in SQL Server Management Studio.
2. Execute the entire script.
3. Check `App.config` and make sure the `IWSHubConnectionLocal` server name matches the SQL Server instance on the computer.
4. Keep `DatabaseMode` as `Local` for the local connection, or change it to `Remote` when using the remote connection.
5. Build and run the Visual Studio project.

The application will also create any missing tables when it starts, provided the configured database already exists.

## Important

The demo administrator credentials are only for development/testing:

- Username: `admin`
- Password: `Admin@123`

Change the administrator password before real deployment. Passwords are currently stored as plain text because the existing login/reset code expects plain-text comparison; password hashing should be the next security improvement.

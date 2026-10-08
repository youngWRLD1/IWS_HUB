using System;
using System.Configuration;
using System.Data.SqlClient;

namespace IwsHub2
{
    /// <summary>
    /// Central database connection and schema setup.
    /// CHANGED: supports Local/Remote mode from App.config and applies safe schema upgrades.
    /// </summary>
    internal static class Database
    {
        public static SqlConnection GetConnection()
        {
            string mode = ConfigurationManager.AppSettings["DatabaseMode"] ?? "Local";
            string connectionName = mode.Equals("Remote", StringComparison.OrdinalIgnoreCase)
                ? "IWSHubConnectionRemote"
                : "IWSHubConnectionLocal";

            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[connectionName];
            if (settings == null)
                throw new ConfigurationErrorsException("Connection string '" + connectionName + "' was not found in App.config.");

            return new SqlConnection(settings.ConnectionString);
        }

        public static void Initialize()
        {
            const string schema = @"
IF OBJECT_ID(N'dbo.Users', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Users
    (
        StudentNumber NVARCHAR(20) NOT NULL CONSTRAINT PK_Users PRIMARY KEY,
        FullName NVARCHAR(200) NOT NULL,
        StudentMail NVARCHAR(254) NULL,
        PhoneNumber NVARCHAR(20) NULL,
        Title NVARCHAR(20) NULL,
        Gender NVARCHAR(30) NULL,
        Course NVARCHAR(150) NULL,
        CourseYear NVARCHAR(30) NULL,
        Password NVARCHAR(255) NOT NULL,
        CreatedAt DATETIME2 NOT NULL CONSTRAINT DF_Users_CreatedAt DEFAULT SYSDATETIME()
    );
END;

IF COL_LENGTH(N'dbo.Users', N'Course') IS NULL
    ALTER TABLE dbo.Users ADD Course NVARCHAR(150) NULL;

IF COL_LENGTH(N'dbo.Users', N'CourseYear') IS NULL
    ALTER TABLE dbo.Users ADD CourseYear NVARCHAR(30) NULL;

IF OBJECT_ID(N'dbo.GroupPosts', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.GroupPosts
    (
        PostID INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_GroupPosts PRIMARY KEY,
        StudentNumber NVARCHAR(20) NOT NULL,
        StudentName NVARCHAR(200) NOT NULL,
        PostContent NVARCHAR(MAX) NOT NULL,
        PostedAt DATETIME2 NOT NULL CONSTRAINT DF_GroupPosts_PostedAt DEFAULT SYSDATETIME()
    );
END;

IF OBJECT_ID(N'dbo.PastPapers', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.PastPapers
    (
        PaperID INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_PastPapers PRIMARY KEY,
        Module NVARCHAR(150) NOT NULL,
        CourseCode NVARCHAR(50) NULL,
        CourseYear NVARCHAR(30) NULL,
        Semester NVARCHAR(30) NULL,
        [Year] INT NULL,
        [Description] NVARCHAR(500) NULL,
        FilePath NVARCHAR(1000) NULL,
        FileName NVARCHAR(260) NULL,
        FileData VARBINARY(MAX) NULL,
        UploadedBy NVARCHAR(20) NULL,
        UploadedAt DATETIME2 NOT NULL CONSTRAINT DF_PastPapers_UploadedAt DEFAULT SYSDATETIME()
    );
END;

IF COL_LENGTH(N'dbo.PastPapers', N'FileName') IS NULL
    ALTER TABLE dbo.PastPapers ADD FileName NVARCHAR(260) NULL;

IF COL_LENGTH(N'dbo.PastPapers', N'FileData') IS NULL
    ALTER TABLE dbo.PastPapers ADD FileData VARBINARY(MAX) NULL;

IF OBJECT_ID(N'dbo.Admin', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Admin
    (
        AdminID INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Admin PRIMARY KEY,
        Username NVARCHAR(100) NOT NULL CONSTRAINT UQ_Admin_Username UNIQUE,
        FullName NVARCHAR(200) NOT NULL,
        Password NVARCHAR(255) NOT NULL,
        CreatedAt DATETIME2 NOT NULL CONSTRAINT DF_Admin_CreatedAt DEFAULT SYSDATETIME()
    );
END;

IF OBJECT_ID(N'dbo.SearchHistory', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.SearchHistory
    (
        SearchID INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_SearchHistory PRIMARY KEY,
        StudentNumber NVARCHAR(20) NOT NULL,
        SearchTerm NVARCHAR(200) NOT NULL,
        SearchDate DATETIME2 NOT NULL CONSTRAINT DF_SearchHistory_SearchDate DEFAULT SYSDATETIME()
    );
END;

IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'IX_GroupPosts_StudentNumber' AND object_id = OBJECT_ID(N'dbo.GroupPosts'))
    CREATE INDEX IX_GroupPosts_StudentNumber ON dbo.GroupPosts(StudentNumber);

IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'IX_GroupPosts_PostedAt' AND object_id = OBJECT_ID(N'dbo.GroupPosts'))
    CREATE INDEX IX_GroupPosts_PostedAt ON dbo.GroupPosts(PostedAt DESC);

IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'IX_PastPapers_Module_Year' AND object_id = OBJECT_ID(N'dbo.PastPapers'))
    CREATE INDEX IX_PastPapers_Module_Year ON dbo.PastPapers(Module, [Year]);

IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'IX_PastPapers_UploadedBy' AND object_id = OBJECT_ID(N'dbo.PastPapers'))
    CREATE INDEX IX_PastPapers_UploadedBy ON dbo.PastPapers(UploadedBy);

IF NOT EXISTS (SELECT 1 FROM dbo.Admin WHERE Username = N'admin')
BEGIN
    INSERT INTO dbo.Admin (Username, FullName, Password)
    VALUES (N'admin', N'IWS Hub Administrator', N'Admin@123');
END;
";

            using (SqlConnection connection = GetConnection())
            using (SqlCommand command = new SqlCommand(schema, connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}

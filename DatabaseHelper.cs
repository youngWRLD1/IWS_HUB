using System.Data.SqlClient;

namespace IwsHub2
{
    /// <summary>
    /// Backwards-compatible wrapper for older forms that may use DatabaseHelper.
    /// All database connections now come from the same central Database class.
    /// </summary>
    public static class DatabaseHelper
    {
        public static SqlConnection GetConnection()
        {
            return Database.GetConnection();
        }
    }
}

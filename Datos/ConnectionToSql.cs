namespace Datos
{
    using System.Data.SqlClient;
    public abstract class ConnectionToSql
    {
        private readonly string connectionString;
        public ConnectionToSql()
        {
            connectionString = "Server=DILAN\\SQLEXPRESS;Database=SharksGymDB;Trusted_Connection=true;MultipleActiveResultSets=true";
        }

        protected SqlConnection GetConnection()
        { 
            return new SqlConnection(connectionString);
        }
    }
}

namespace WebApplication1.Helper
{
    public class SqlConnectionContext :ISqlConnectionContext
    {
        public string GetConnectionString()
        {
            string connectionString = "Server=KARTHIK\\SQLEXPRESS;Database=abc;TrustServerCertificate=True;Integrated Security=True;";
            return connectionString;
        }
    }
}

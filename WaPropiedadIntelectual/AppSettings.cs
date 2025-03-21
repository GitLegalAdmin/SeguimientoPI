using Microsoft.Data.SqlClient;

namespace WaPropiedadIntelectual
{
    public class AppSettings
    {
        public static string DefaultConnectionString;
        public static SqlConnection GetConnection()
        {
            try
            {
                SqlConnection connection = new SqlConnection(DefaultConnectionString);
                return connection;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }

}

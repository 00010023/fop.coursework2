using System.Data.SqlServerCe;

namespace CW.DAL
{
    public class DbManager
    {
        protected SqlCeConnection Connection
        {
            get
            {
                return new SqlCeConnection(Properties.Settings.Default.ConnectionString);
            }
        }

    }
}

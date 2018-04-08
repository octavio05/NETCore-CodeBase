using Microsoft.Extensions.Options;
using NetCore_ProjectBase.Interfaces;
using CoreConnection;

namespace NetCore_ProjectBase.Class
{
    public class DataAccess : IDataAccess
    {
        #region Private variables
        private readonly AppSettings _settings;
        private readonly ICorePostgreSql _connection;
        #endregion

        #region Constructor
        public DataAccess(IOptions<AppSettings> settings, ICorePostgreSql connection)
        {
            _settings = settings.Value;
            _connection = connection;
        }
        #endregion

        #region Public Methods
        public string GetConnectionString()
        {
            return _settings.Data.ConnectionString;
        }
        #endregion
    }
}

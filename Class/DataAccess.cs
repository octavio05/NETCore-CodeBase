using Microsoft.Extensions.Options;
using NetCore_ProjectBase.Interfaces;

namespace NetCore_ProjectBase.Class
{
    public class DataAccess : IDataAccess
    {
        #region Private variables
        private readonly AppSettings _settings;
        #endregion

        #region Constructor
        public DataAccess(IOptions<AppSettings> settings)
        {
            _settings = settings.Value;
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

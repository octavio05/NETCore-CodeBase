using NetCore_ProjectBase.Interfaces;

namespace NetCore_ProjectBase.Class
{
    public class BusinessLogic : IBusinessLogic
    {
        #region Private Variables
        private readonly IDataAccess _data;
        #endregion

        #region Constructor
        public BusinessLogic(IDataAccess data)
        {
            _data = data;
        }
        #endregion

        #region Public Methods
        public string GetConnectionString()
        {
            return _data.GetConnectionString();
        }
        #endregion
    }
}

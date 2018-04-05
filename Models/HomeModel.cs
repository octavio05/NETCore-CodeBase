namespace NetCore_ProjectBase.Models
{
    public class HomeModel
    {
        #region Properties
        public string ConnectionString { get; } = "";
        #endregion

        #region Constructor
        public HomeModel(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }
        #endregion
    }
}

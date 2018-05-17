using Microsoft.AspNetCore.Mvc;
using NetCore_ProjectBase.Interfaces;
using NetCore_ProjectBase.Models;
using Microsoft.Extensions.Logging;

namespace NetCore_ProjectBase.Controllers
{
    public class HomeController : Controller
    {
        #region Private variables
        private readonly IBusinessLogic _businness;
        private readonly ILoggerManager _logger;
        #endregion

        #region Constructor
        public HomeController(IBusinessLogic business, ILoggerManager logger)
        {
            _businness = business;
            _logger = logger;
        }
        #endregion

        #region Public Methods
        public IActionResult Index()
        {
            _logger.LogInfo("Test Log");
            return View(new HomeModel(_businness.GetConnectionString()));
        }
        #endregion
    }
}
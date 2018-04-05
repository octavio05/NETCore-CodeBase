using Microsoft.AspNetCore.Mvc;
using NetCore_ProjectBase.Interfaces;
using NetCore_ProjectBase.Models;

namespace NetCore_ProjectBase.Controllers
{
    public class HomeController : Controller
    {
        #region Private variables
        private readonly IBusinessLogic _businness;
        #endregion

        #region Constructor
        public HomeController(IBusinessLogic business)
        {
            _businness = business;
        }
        #endregion

        #region Public Methods
        public IActionResult Index()
        {
            return View(new HomeModel(_businness.GetConnectionString()));
        }
        #endregion
    }
}
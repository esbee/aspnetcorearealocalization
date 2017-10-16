using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AreaLocalization.Controllers
{
    using Microsoft.Extensions.Localization;
    
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly IStringLocalizer<HomeController> _stringLocalizer;
        private readonly IStringLocalizer<ControllerSharedResource> _sharedLocalizer;

        public HomeController(IStringLocalizer<HomeController> stringLocalizer, IStringLocalizer<ControllerSharedResource> sharedLocalizer) {
            _stringLocalizer = stringLocalizer;
            _sharedLocalizer = sharedLocalizer;
        }

        // GET: /<controller>/
        public IActionResult Index() {
            ViewBag.ControllerShared = _sharedLocalizer["ControllerShared"];
            ViewBag.ControllerSpecific = _stringLocalizer["ControllerSpecific"];
            return View();
        }
    }
}

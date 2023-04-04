using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SpryStore.DataAccessLayer.Concrete;
using System.Linq;
using System.Runtime.CompilerServices;

namespace SpryStore.PresentationLayer.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;

        public RoleController(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var values=_roleManager.Roles.ToList();
            return View(values);
        }
    }
}

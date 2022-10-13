using MAQS.Web.Data;
using MAQS.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace MAQS.Web.Controllers
{
    public class CompanyContactController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CompanyContactController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<CompanyContact> objCategoryList = _db.CompanyContact;
            return View(objCategoryList);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MAQS.Web.Models;
using Microsoft.Data.SqlClient;

namespace MAQS.Web.Controllers
{
    public class CorpsController : Controller
    {
        private readonly maqsdbContext _context;

        public CorpsController(maqsdbContext context)
        {
            _context = context;
        }

        // GET: Corps
        public async Task<IActionResult> Index()
        {
            return View(await _context.Corps.ToListAsync());
        }
        
        [HttpGet]
        public async Task<IEnumerable<ContactDetails>> ContactDetails([FromQuery] Guid id)
        {
            var contactdetails = await _context.ContactDetailss.FromSqlInterpolated($"Exec MAQS_ContactNotesQuotes @corpid= {id}").ToListAsync();

            return contactdetails;
        }


        private bool CorpExists(Guid id)
        {
          return _context.Corps.Any(e => e.Corpid == id);
        }
    }
}

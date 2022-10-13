using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MAQS.Web.Models;

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

        // GET: Corps/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Corps == null)
            {
                return NotFound();
            }

            var corp = await _context.Corps
                .FirstOrDefaultAsync(m => m.Corpid == id);
            if (corp == null)
            {
                return NotFound();
            }

            return View(corp);
        }

        // GET: Corps/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Corps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Corpid,Rowid,Created,Createdby,Updated,Updatedby,Timestamp,Delrec,Company,Contact,Title,Address1,Address2,City,State,Zip,Country,Pharea,Phone,Phext,Phtype,Altpharea,Altphone,Altphext,Altphtype,Pharea800,Phone800,Faxarea,Fax,Email,Urlweb,Agcorpid,Prvemp,Skillset,Status,Lpcode,Contactid2,Parentid,Persemail,Urlcareers,Position")] Corp corp)
        {
            if (ModelState.IsValid)
            {
                corp.Corpid = Guid.NewGuid();
                _context.Add(corp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(corp);
        }

        // GET: Corps/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Corps == null)
            {
                return NotFound();
            }

            var corp = await _context.Corps.FindAsync(id);
            if (corp == null)
            {
                return NotFound();
            }
            return View(corp);
        }

        // POST: Corps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Corpid,Rowid,Created,Createdby,Updated,Updatedby,Timestamp,Delrec,Company,Contact,Title,Address1,Address2,City,State,Zip,Country,Pharea,Phone,Phext,Phtype,Altpharea,Altphone,Altphext,Altphtype,Pharea800,Phone800,Faxarea,Fax,Email,Urlweb,Agcorpid,Prvemp,Skillset,Status,Lpcode,Contactid2,Parentid,Persemail,Urlcareers,Position")] Corp corp)
        {
            if (id != corp.Corpid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(corp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CorpExists(corp.Corpid))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(corp);
        }

        // GET: Corps/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Corps == null)
            {
                return NotFound();
            }

            var corp = await _context.Corps
                .FirstOrDefaultAsync(m => m.Corpid == id);
            if (corp == null)
            {
                return NotFound();
            }

            return View(corp);
        }

        // POST: Corps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Corps == null)
            {
                return Problem("Entity set 'maqsdbContext.Corps'  is null.");
            }
            var corp = await _context.Corps.FindAsync(id);
            if (corp != null)
            {
                _context.Corps.Remove(corp);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CorpExists(Guid id)
        {
          return _context.Corps.Any(e => e.Corpid == id);
        }
    }
}

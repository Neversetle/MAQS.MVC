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
        public IActionResult Index()
        {
            CorpList corpList = new CorpList();
            List<CorpData> corpListList = new List<CorpData>();
            corpList.corps = corpListList;
            return View(corpList);
        }
        [HttpPost]
        public IActionResult Index(CorpList corp)
        {
            CorpList corpList = new CorpList();

            List<SqlParameter> param = new List<SqlParameter>()
            {
                new SqlParameter("@Company", corp.Company),
                new SqlParameter("@City", corp.City == null ? DBNull.Value : corp.City),
                new SqlParameter("@State", corp.State == null ? DBNull.Value : corp.State),
                new SqlParameter("@Zip", corp.Zip == null ? DBNull.Value : corp.Zip),
                new SqlParameter("@Email", corp.Email == null ? DBNull.Value : corp.Email ),
                new SqlParameter("@Contact", corp.Contact == null ? DBNull.Value : corp.Contact ),
            };

            string StroedProc = " EXEC [MAQS_SearchResult]@Company,@City,@State,@Zip,@Email,@Contact";

            var corpResult = _context.CorpDatas.FromSqlRaw(StroedProc, param.ToArray()).ToList();
            corpList.corps = corpResult;

            return View(corpList);
        }

        [HttpGet]
        public IEnumerable<ContactDetails> ContactDetails([FromQuery] Guid id)
        {

            var contactdetails = new List<ContactDetails>();
            try
            {
                List<SqlParameter> param = new List<SqlParameter>()
            {
                new SqlParameter("@corpid", id)
            };

                string StroedProc = " EXEC [MAQS_ContactNotesQuotes]@corpid";

                contactdetails = _context.ContactDetailss.FromSqlRaw(StroedProc, param.ToArray()).ToList();

            }
            catch (Exception e)
            {

            }
            return contactdetails;
        }

        [HttpGet]
        public async Task<IEnumerable<QuotesPopup>> QuotesPopup([FromQuery] int id)
        {
            var quotespopup = new List<QuotesPopup>();
            try
            {
                List<SqlParameter> param = new List<SqlParameter>()
            {
                new SqlParameter("@quotenum", id)
            };

                string StroedProc = " EXEC [MAQS_ModalPopup]@quotenum";

                quotespopup = await _context.QuotesPopups.FromSqlRaw(StroedProc, param.ToArray()).ToListAsync();

            }
            catch (Exception e)
            {

            }
            return quotespopup;

        }

    }
}

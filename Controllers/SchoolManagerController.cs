using SchoolManager.Models;
using System.Web.Mvc;

namespace SchoolManager.Controllers
{
    public class SchoolManagerController : Controller
    {
        protected SchoolManagerDataContext dbContext = new SchoolManagerDataContext();

        protected override void Dispose(bool disposing)
        {
            if(dbContext != null)
            {
                dbContext.Dispose();
            }

            base.Dispose(disposing);
        }

        [Route("", Name = "schoolmanager.index"), HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}
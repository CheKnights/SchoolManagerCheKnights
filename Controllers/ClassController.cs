using SchoolManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SchoolManager.Controllers
{
    [RoutePrefix("class")]
    public class ClassController : SchoolManagerController
    {
        [Route("list", Name = "class.list"), HttpGet]
        public ActionResult List()
        {
            IEnumerable<Class> classes = dbContext.Classes;

            return View(classes);
        }

        [Route("edit", Name = "class.edit"), HttpGet]
        public ActionResult Edit(string token)
        {
            Class @class = null;

            if (!string.IsNullOrEmpty(token))
            {
                @class = dbContext.Classes.FirstOrDefault(c => c.Token == token);

                if(@class == null)
                {
                    TempData["error"] = "Class not found";
                    return RedirectToRoute("class.list");
                }
            }

            return View(@class);
        }

        [Route("edit", Name = "class.edit.post"), HttpPost]
        public ActionResult Edit(string token, string name)
        {
            Class @class = null;

            if (!string.IsNullOrEmpty(token))
            {
                @class = dbContext.Classes.FirstOrDefault(c => c.Token == token);

                if (@class == null)
                {
                    TempData["error"] = "Class not found";
                    return RedirectToRoute("class.list");
                }
            }
            else
            {
                @class = new Class();

                do
                {
                    @class.Token = Guid.NewGuid().ToString("N");
                }
                while (dbContext.Classes.Any(c => c.Token == @class.Token));

                dbContext.Classes.InsertOnSubmit(@class);
                // [TODO] I'm sure there's an easy way to hook the following method up, 
                // [TODO] I just don't know how to do it.  
                // dbContext.Classes.UpdateOnSubmit(@class);
            }

            @class.Name = name;

            dbContext.SubmitChanges();

            return RedirectToRoute("class.list");
        }

        [Route("edit", Name = "class.edit.post"), HttpPost]
        public ActionResult Delete(string token, string name)
        {
            Class @class = null;

            if (!string.IsNullOrEmpty(token))
            {
                @class = dbContext.Classes.FirstOrDefault(c => c.Token == token);

                if (@class == null)
                {
                    TempData["error"] = "Class not found";
                    return RedirectToRoute("class.list");
                }
            }
            else
            {
                do
                {
                    @class.Token = Guid.NewGuid().ToString("N");
                }
                while (dbContext.Classes.Any(c => c.Token == @class.Token));

                dbContext.Classes.DeleteOnSubmit(@class);
            }

            @class.Name = name;

            dbContext.SubmitChanges();

            return RedirectToRoute("class.list");
        }
    }
}
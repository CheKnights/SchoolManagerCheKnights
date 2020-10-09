using SchoolManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SchoolManager.Controllers
{
    [RoutePrefix("student")]
    public class StudentController : SchoolManagerController
    {
        [Route("list", Name = "student.list"), HttpGet]
        public ActionResult List()
        {
            IEnumerable<Student> students = dbContext.Students;

            return View(students);
        }

        [Route("edit", Name = "student.edit"), HttpGet]
        public ActionResult Edit(string token)
        {
            Student student = null;

            if (!string.IsNullOrEmpty(token))
            {
                student = dbContext.Students.FirstOrDefault(s => s.Token == token);

                if (student == null)
                {
                    TempData["error"] = "Student not found";
                    return RedirectToRoute("student.list");
                }
            }

            return View(student);
        }

        [Route("edit", Name = "student.edit.post"), HttpPost]
        public ActionResult Edit(string token, string firstName, string lastName)
        {
            Student student = null;

            if (!string.IsNullOrEmpty(token))
            {
                student = dbContext.Students.FirstOrDefault(s => s.Token == token);

                if (student == null)
                {
                    TempData["error"] = "Student not found";
                    return RedirectToRoute("class.list");
                }
            }
            else
            {
                student = new Student();

                do
                {
                    student.Token = Guid.NewGuid().ToString("N");
                }
                while (dbContext.Students.Any(s => s.Token == student.Token));
            }

            student.FirstName = firstName;
            student.LastName = lastName;

            return RedirectToRoute("student.list");
        }
    }
}
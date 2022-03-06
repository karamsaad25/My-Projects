using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using CRUDStudent.Models;
using CRUDStudent.KS;

namespace CRUDStudent.Controllers
{
    public class StudentController : Controller
    {
        StudentContext Sd = new StudentContext();

        // GET: Student
        public ActionResult Index(Student s)
        {
            return View( s);
        }

        public ActionResult Student()
        {

            var Resault = Sd.Students.ToList();
            return View(Resault);
        }

        [HttpPost]
        public ActionResult AddStudent(Student model)
        {
            Student s = new Student();


            if (ModelState.IsValid)
            {
                s.FirstName = model.FirstName;
                s.LastName = model.LastName;
                s.Email = model.Email;
                s.Mobile = model.Mobile;

            }
            if (model.ID == 0)
            {
                Sd.Students.Add(s);
                Sd.SaveChanges();
            }
            else
            {
                Sd.Entry(s).State = EntityState.Modified;
                Sd.SaveChanges();
            }


            ModelState.Clear();
            return View("Index");

        }


        public ActionResult Delete(int id)
        {
            var res = Sd.Students.Where(x => x.ID == id).First();
            Sd.Students.Remove(res);
            Sd.SaveChanges();

            var list = Sd.Students.ToList();
            return View("Student", list);
        }

     

    }
}
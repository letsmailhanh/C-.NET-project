using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebsiteFAP.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace WebsiteFAP.Controllers
{

    public class DefaultController : Controller
    {
        public object Session { get; private set; }


        public IActionResult Home()
        {
            var view = View("Views/Home.cshtml");
            PRN_FAPProjectContext context = new PRN_FAPProjectContext();
            string id = HttpContext.Session.GetString("sid");
            Students s = context.Students.Find(id);
            view.ViewData.Model = s;
            return view;
            //return s.Email + " " + s.Address + " " + s.Phone + s.FullName;
        }
        [HttpGet]
        public IActionResult SendApp()
        {
            var view = View("Views/SendApp.cshtml");
            PRN_FAPProjectContext context = new PRN_FAPProjectContext();
            List<ApplicationType> types = context.ApplicationType.ToList<ApplicationType>();
            ViewBag.typeid = new MultiSelectList(types, "TypeId", "TypeName");
            return view;
        }

        [HttpPost]
        public IActionResult SendApp(Applications newapp)
        {
            PRN_FAPProjectContext context = new PRN_FAPProjectContext();
            newapp.StatusId = 3;
            newapp.StudentId = HttpContext.Session.GetString("sid");
            newapp.CreateDate = DateTime.Today;
            context.Applications.Add(newapp);
            context.SaveChanges();
            return RedirectToAction("SendApp");
        }

        public IActionResult ViewSem()
        {
            var view = View("Views/ViewSem.cshtml");
            PRN_FAPProjectContext context = new PRN_FAPProjectContext();
            var mysems = context.Semester.ToList();
            view.ViewData.Model = mysems;
            return view;
        }

        [HttpGet]
        public IActionResult ListApp()
        {
            var view = View("Views/ListApp.cshtml");
            PRN_FAPProjectContext context = new PRN_FAPProjectContext();
            //List<ApplicationType> types = context.ApplicationType.ToList<ApplicationType>();
            //ViewBag.typeid = new MultiSelectList(types, "TypeId", "TypeName");
            String id = HttpContext.Session.GetString("sid");
            var myapps = context.Applications.Where(s => s.StudentId == id).ToList();
            view.ViewData.Model = myapps;
            return view;
        }
        public IActionResult Login()
        {
            return View("Views/Login.cshtml");
        }

        [HttpPost]
        public ActionResult CheckLogin(string email, string password)
        {
            if (email == "admin" && password == "1234")
            {
                return View("Views/AdminHome.cshtml");
            }

            PRN_FAPProjectContext context = new PRN_FAPProjectContext();
            Students s = context.Students.Where(s => s.Email == email && s.Password == password).FirstOrDefault();
            if (!(s == null))
            {
                HttpContext.Session.SetString("sid", s.StudentId);
                return RedirectToAction("Home");
            }
            else
            {
                ViewBag.Message = "Login failed!";
                return View("Views/Login.cshtml");
            }
        }

        [HttpPost]
        public IActionResult EditStudent(Students s)
        {
            PRN_FAPProjectContext context = new PRN_FAPProjectContext();
            var stu = context.Students.Where(x => x.StudentId == s.StudentId).FirstOrDefault();
            stu.Address = s.Address;
            stu.Phone = s.Phone;
            context.SaveChanges();
            return RedirectToAction("Home");
        }

        [HttpGet]
        public IActionResult TestUpFile()
        {
            return View("Views/UpFile.cshtml");
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("sid");
            return RedirectToAction("Login");
        }



        //File
        //[HttpGet]
        //public IActionResult CreateFile()
        //{
        //    return View(new AppFile());
        //}
        //[HttpPost]
        //public IActionResult CreateFile(AppFile model)
        //{
        //    var img = model.MyFile;
          

        //    //Getting file meta data
        //    var fileName = Path.GetFileName(model.MyFile.FileName);
        //    var contentType = model.MyFile.ContentType;

        //    // do something with the above data
        //    // to do : return something
        //    //return "img" + img + " fileName" + fileName + " content" + contentType;
        //    return RedirectToAction("Home");
        //}
    }
}

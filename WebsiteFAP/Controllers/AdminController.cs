using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebsiteFAP.Models;

namespace WebsiteFAP.Controllers
{

    public class AdminController : Controller
    {
        public IActionResult Home()
        {
            return View("Views/AdminHome.cshtml");
        }

        [HttpGet]
        public IActionResult ManageApp()
        {
            PRN_FAPProjectContext context = new PRN_FAPProjectContext();
            var view = View("Views/AdminManageApp.cshtml");
            view.ViewData.Model = context.Applications.ToList<Applications>();
            return view;
        }

        [HttpPost]
        public IActionResult ChangeStatus(int status, int appid, string ProcessNote)
        {
            PRN_FAPProjectContext context = new PRN_FAPProjectContext();
            Applications current = context.Applications.Find(appid);
            current.ProcessNote = ProcessNote;
            current.StatusId = status;
            current.ChangeStatusTime = DateTime.Now;
            context.Applications.Update(current);
            context.SaveChanges();
            return RedirectToAction("ManageApp");

        }
    }
}

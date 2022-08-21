using u21520659_HW4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u21520659_HW4.Controllers
{
    public class HomeController : Controller
    {
        // Link the views inorder to display 
       
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Home()
        {
           
            return View(List.Recycles());
        }

        public ActionResult Goal()
        {

            return View();
        }

        public ActionResult Education()
        {
            
            return View();
        }
        public ActionResult Partnership()
        {

            return View();
        }

        public ActionResult SignUp()
        {

            return View();
        }

        public ActionResult UseCases()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Education(string sponsor, int duration, double donation, string educationType, string schoolName, int schoolGrade)
        {
            Random random = new Random();
            int id = random.Next(1, 10000000);
            Education education = new Education(id, sponsor, duration, donation, educationType, schoolName, schoolGrade);
            List.Add(education);
            
            return View();
        }

        [HttpPost]
        public ActionResult Partnership(string sponsor, string programme, double donation, int duration, string partnershipType)
        {
            int id = 0;
            Partnership partnership = new Partnership(id, sponsor, programme , donation, partnershipType, duration);
            List.Add(partnership);
            id++;
            return View();
        }

        public ActionResult Delete(int id)
        {
            List.Delete(id);
           return RedirectToAction("Home");
        }

        public ActionResult EditNonEntry(int id)
        {

            Education education = (Education)List.recycles.FirstOrDefault(x => x.SDGID == id);
            return View(education);
        }

        public ActionResult EditreEntry(int id)
        {

            Partnership partnership = (Partnership)List.recycles.FirstOrDefault(x => x.SDGID == id);
            return View(partnership);
        }

        [HttpPost]
        public ActionResult EditreEntry(Partnership partnership)
        {
            List.Edit(partnership);

            return RedirectToAction("Home");
        }

        [HttpPost]
        public ActionResult EditNonEntry(Education education)
        {
            List.Edit(education);

            return RedirectToAction("Home");
        }

        public ActionResult ViewEnergy()
        {
            ViewBag.Message = "Your contact page.";

            return RedirectToAction("Home");
        }
    }
}
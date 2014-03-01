using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using Proyecto1WEB2.Models;

namespace Proyecto1WEB2.Controllers
{
    public class HomeController : Controller
    {
        private RecommendationDb db = new RecommendationDb();
        //
        // GET: /Home/

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Recommendations()
        {
            List<Recommendation> recommendations = db.Recommendations.ToList();
            ViewBag.recommendations = recommendations;
            return View();
        }

        public ActionResult Recommend()
        {
            List<Recommendation> recommendations = db.Recommendations.ToList();
            ViewBag.recommendations = recommendations;
            return View();
        }

        [HttpPost]
        public ActionResult Recommend(string name = "", int phone = 0, string email = "", string recomendation1 = "")
        {
            Recommendation newRecommendation = new Recommendation();
            newRecommendation.Name = name;
            newRecommendation.Phone = phone;
            newRecommendation.Email = email;
            newRecommendation.Recomendation1 = recomendation1;
            if (ModelState.IsValid)
            {
                db.Recommendations.Add(newRecommendation);
                db.SaveChanges();
                return RedirectToAction("Home");
            }
            return View();
        }
    }
}

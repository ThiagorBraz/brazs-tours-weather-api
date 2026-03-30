using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BrazsToursWeatherWebApi;

namespace BrazsToursWeatherWebApi.Controllers
{
    public class WeatherActionsController : Controller
    {
        private ConToStringAPIBrazsToursWeatherDB db = new ConToStringAPIBrazsToursWeatherDB();

        // GET: WeatherActions
        public ActionResult Index()
        {
            return View(db.WeatherForecasts.ToList());
        }

        // GET: WeatherActions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WeatherForecast weatherForecast = db.WeatherForecasts.Find(id);
            if (weatherForecast == null)
            {
                return HttpNotFound();
            }
            return View(weatherForecast);
        }

        // GET: WeatherActions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WeatherActions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Location,Date,Condition,Temperature")] WeatherForecast weatherForecast)
        {
            if (ModelState.IsValid)
            {
                db.WeatherForecasts.Add(weatherForecast);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(weatherForecast);
        }

        // GET: WeatherActions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WeatherForecast weatherForecast = db.WeatherForecasts.Find(id);
            if (weatherForecast == null)
            {
                return HttpNotFound();
            }
            return View(weatherForecast);
        }

        // POST: WeatherActions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Location,Date,Condition,Temperature")] WeatherForecast weatherForecast)
        {
            if (ModelState.IsValid)
            {
                db.Entry(weatherForecast).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(weatherForecast);
        }

        // GET: WeatherActions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WeatherForecast weatherForecast = db.WeatherForecasts.Find(id);
            if (weatherForecast == null)
            {
                return HttpNotFound();
            }
            return View(weatherForecast);
        }

        // POST: WeatherActions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WeatherForecast weatherForecast = db.WeatherForecasts.Find(id);
            db.WeatherForecasts.Remove(weatherForecast);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

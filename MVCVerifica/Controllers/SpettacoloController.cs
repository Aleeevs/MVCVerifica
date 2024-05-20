using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MVCVerifica.Data;
using MVCVerifica.Models;

namespace MVCVerifica.Controllers {
    public class SpettacoloController(ApplicationDbContext db) : Controller {

        private readonly ApplicationDbContext _db = db;

        public IActionResult Index() {
            var result = _db.Database.SqlQuery<Spettacolo>($"SELECT * FROM spettacoli").ToList();
            // oppure 
            //var result = _db.Spettacoli.ToList();

            return View(result);
        }

        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Spettacolo spettacolo) {
            if (ModelState.IsValid) {
                _db.Database.ExecuteSql($"INSERT INTO spettacoli(Name, Description) VALUES ({spettacolo.Name}, {spettacolo.Description})");
                // oppure
                // _db.Spettacoli.Add(spettacolo);

                return RedirectToAction("Index");
            }

            return View(spettacolo);
        }

    }
}

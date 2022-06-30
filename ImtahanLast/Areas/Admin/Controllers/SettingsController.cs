using ImtahanLast.DAL;
using ImtahanLast.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImtahanLast.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class SettingsController : Controller
    {
        public readonly AppDbContext _context;
        public SettingsController(AppDbContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            List<LServices> settings = _context.services.ToList();
            return View(settings);
        }

        // GET: SettingsController/Edit/5
        public ActionResult Edit(int id)
        {
            LServices s = _context.services.Find(id);
            return View(s);
        }

        // POST: SettingsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, LServices s)
        {
            if (s.Id != id )
            {
                return View();
            }
            LServices Dbs = _context.services.Find(id);
            if (Dbs == null)
            {
                return BadRequest();
            }
            Dbs.Value = s.Value;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}

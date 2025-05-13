using CMRS.Data;
using CMRS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CMRS.Controllers
{
    public class RegistarController : Controller
    {
        private readonly CMRSContext _context;
        public RegistarController(CMRSContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Medijatori()
        {
            var medijator = await _context.Medijatori.ToListAsync();
            return View(medijator);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Institucije()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Id, Ime, Prezime, Prebivaliste, Email, Telefon, Aktivan")] Medijator medijator)
        {
            if (ModelState.IsValid)
            {
                _context.Medijatori.Add(medijator);
                await _context.SaveChangesAsync();
                return RedirectToAction("index");
            }
            return View(medijator);
        }
    }
}

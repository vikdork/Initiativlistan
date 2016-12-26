using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Initiativlistan.Data;
using Initiativlistan.Models;

namespace Initiativlistan.Controllers
{
    public class PriolistanController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PriolistanController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Priolistan
        public async Task<IActionResult> Index()
        {
            return View(await _context.Priolista.ToListAsync());
        }

        // GET: Priolistan/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var priolista = await _context.Priolista.SingleOrDefaultAsync(m => m.ID == id);
            if (priolista == null)
            {
                return NotFound();
            }

            return View(priolista);
        }

        // GET: Priolistan/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Priolistan/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,akut,beroende,beskrivAkut,beskrivning,beställare,budget,finnsIPlan,framtidaPåverkan,förvaltning,kategorisering,kostnader,namnPåAktvivitet,nuvarandePåverkan,tidasram,typAvFörändring,verksamhetspåverkarn,ärendeägare,önskatDatum")] Priolista priolista)
        {
            if (ModelState.IsValid)
            {
                _context.Add(priolista);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(priolista);
        }

        // GET: Priolistan/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var priolista = await _context.Priolista.SingleOrDefaultAsync(m => m.ID == id);
            if (priolista == null)
            {
                return NotFound();
            }
            return View(priolista);
        }

        // POST: Priolistan/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,akut,beroende,beskrivAkut,beskrivning,beställare,budget,finnsIPlan,framtidaPåverkan,förvaltning,kategorisering,kostnader,namnPåAktvivitet,nuvarandePåverkan,tidasram,typAvFörändring,verksamhetspåverkarn,ärendeägare,önskatDatum")] Priolista priolista)
        {
            if (id != priolista.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(priolista);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PriolistaExists(priolista.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(priolista);
        }

        // GET: Priolistan/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var priolista = await _context.Priolista.SingleOrDefaultAsync(m => m.ID == id);
            if (priolista == null)
            {
                return NotFound();
            }

            return View(priolista);
        }

        // POST: Priolistan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var priolista = await _context.Priolista.SingleOrDefaultAsync(m => m.ID == id);
            _context.Priolista.Remove(priolista);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool PriolistaExists(int id)
        {
            return _context.Priolista.Any(e => e.ID == id);
        }
    }
}

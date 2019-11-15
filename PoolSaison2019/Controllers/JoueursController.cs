using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PoolSaison2019.Models;

namespace PoolSaison2019.Controllers
{
    public class JoueursController : Controller
    {
        private readonly IRepository<Joueur> _repository;

        public JoueursController(IRepository<Joueur> repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> Index()
        {
            var joueurs = await _repository.GetAll();
            if (joueurs == null)
            {
                return NotFound();
            }

            return View(joueurs);
        }


        /*
        // GET: Joueurs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Joueurs.ToListAsync());
        }

        // GET: Joueurs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var joueurs = await _context.Joueurs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (joueurs == null)
            {
                return NotFound();
            }

            return View(joueurs);
        }

        // GET: Joueurs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Joueurs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nom,Equipe,Position,Salaire")] Joueurs joueurs)
        {
            if (ModelState.IsValid)
            {
                _context.Add(joueurs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(joueurs);
        }

        // GET: Joueurs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var joueurs = await _context.Joueurs.FindAsync(id);
            if (joueurs == null)
            {
                return NotFound();
            }
            return View(joueurs);
        }

        // POST: Joueurs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nom,Equipe,Position,Salaire")] Joueurs joueurs)
        {
            if (id != joueurs.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(joueurs);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JoueursExists(joueurs.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(joueurs);
        }

        // GET: Joueurs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var joueurs = await _context.Joueurs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (joueurs == null)
            {
                return NotFound();
            }

            return View(joueurs);
        }

        // POST: Joueurs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var joueurs = await _context.Joueurs.FindAsync(id);
            _context.Joueurs.Remove(joueurs);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JoueursExists(int id)
        {
            return _context.Joueurs.Any(e => e.Id == id);
        }*/
    }
}

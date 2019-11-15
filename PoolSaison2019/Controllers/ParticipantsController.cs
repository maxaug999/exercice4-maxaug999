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
    public class ParticipantsController : Controller
    {
        private readonly IRepository<Participant> _repository;

        public ParticipantsController(IRepository<Participant> repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> Index(string sortOrder = "rang")
        {
            var participants = await _repository.GetAll();
            if (participants == null)
            {
                return NotFound();
            }

            ViewBag.NameSortParm = sortOrder == "nom" ? "nom_desc" : "nom";
            ViewBag.GainsSortParm = sortOrder == "gains" ? "gains_desc" : "gains";
            ViewBag.PointsSortParm = sortOrder == "points" ? "points_desc" : "points";
            ViewBag.LastRankSortParm = sortOrder == "dernierRang" ? "dernierRang_desc" : "dernierRang";
            ViewBag.RankSortParm = sortOrder == "rang" || string.IsNullOrEmpty(sortOrder) ? "rang_desc" : "rang";
            switch (sortOrder)
            {
                case "nom":
                    participants = participants.OrderBy(s => s.Nom);
                    break;
                case "nom_desc":
                    participants = participants.OrderByDescending(s => s.Nom);
                    break;
                case "gains":
                    participants = participants.OrderByDescending(s => s.Gains);
                    break;
                case "gains_desc":
                    participants = participants.OrderBy(s => s.Gains);
                    break;
                case "points":
                    participants = participants.OrderBy(s => s.Points);
                    break;
                case "points_desc":
                    participants = participants.OrderByDescending(s => s.Points);
                    break;
                case "dernierRang":
                    participants = participants.OrderBy(s => s.DernierRang);
                    break;
                case "dernierRang_desc":
                    participants = participants.OrderByDescending(s => s.DernierRang);
                    break;
                case "rang":
                    participants = participants.OrderBy(s => s.Rang);
                    break;
                case "rang_desc":
                    participants = participants.OrderByDescending(s => s.Rang);
                    break;
            }
            return View(participants);
        }
       
        /*
        private readonly PoolSaison2019Context _context;

        public ParticipantsController(PoolSaison2019Context context)
        {
            _context = context;
        }

        
        // GET: Participants
        public async Task<IActionResult> Index()
        {
            return View(await _context.Participant.ToListAsync());
        }
        
        // GET: Participants/Details/5
        
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var participant = await _context.Participant
                .FirstOrDefaultAsync(m => m.Id == id);
            if (participant == null)
            {
                return NotFound();
            }

            return View(participant);
        }

        // GET: Participants/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Participants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nom,Gains")] Participant participant)
        {
            if (ModelState.IsValid)
            {
                _context.Add(participant);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(participant);
        }

        // GET: Participants/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var participant = await _context.Participant.FindAsync(id);
            if (participant == null)
            {
                return NotFound();
            }
            return View(participant);
        }

        // POST: Participants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nom,Gains")] Participant participant)
        {
            if (id != participant.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(participant);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParticipantExists(participant.Id))
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
            return View(participant);
        }

        // GET: Participants/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var participant = await _context.Participant
                .FirstOrDefaultAsync(m => m.Id == id);
            if (participant == null)
            {
                return NotFound();
            }

            return View(participant);
        }

        // POST: Participants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var participant = await _context.Participant.FindAsync(id);
            _context.Participant.Remove(participant);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParticipantExists(int id)
        {
            return _context.Participant.Any(e => e.Id == id);
        }*/
    }
}

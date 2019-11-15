using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PoolSaison2019.Models;

namespace PoolSaison2019.Controllers
{
    public class SignaturesController : Controller
    {
        private readonly IRepository<Signature> _repository;

        public SignaturesController(IRepository<Signature> repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> Index()
        {
            ViewData["Title"] = "PoolSaison2019";
            var signatures = await _repository.GetAll();
            if (signatures == null)
            {
                return NotFound();
            }
            return View(signatures.Last());
        }
        /*
        public IActionResult DerniereSignature(string id, string nom, string team)
        {
            ViewData["Title"] = "PoolSaison2019";
            if(id == null)
            {
                ViewData["id"] = "-1";
            }
            else
            {
                ViewData["id"] = id;
            }

            if (nom == null)
            {
                ViewData["nom"] = "";
            }
            else
            {
                ViewData["nom"] = nom;
            }

            if (team == null)
            {
                ViewData["team"] = "";
            }
            else
            {
                ViewData["team"] = team;
            }
            return View();
        }*/
    }
}
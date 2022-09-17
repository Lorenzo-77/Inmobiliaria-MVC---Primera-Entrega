using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using inmobiliaria_Lorenzo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace inmobiliaria_Lorenzo.Controllers
{
    public class InquilinosController : Controller
    {
        private RepositorioInquilino repo;
        public InquilinosController()
        {
            repo = new RepositorioInquilino();
        }
        // GET: inquilinos
        public ActionResult Index()
        {
            var inquilinos = repo.ObtenerInquilinos();
            return View(inquilinos);
        }

        // GET: inquilinos/Details/5
        public ActionResult Details(int id)
        {
            var inquilino = repo.ObtenerPorId(id);
            return View(inquilino);
        }

        // GET: inquilinos/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: inquilinos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Inquilino inquilino)
        {
            try
            {
                repo.AltaInquilino(inquilino);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                throw;
            }
        }

        // GET: inquilinos/Edit/5y
        public ActionResult Edit(int id)
        {
            var inquilino = repo.ObtenerPorId(id);
            return View(inquilino);
        }

        // POST: inquilinos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Inquilino inquilino)
        {
            Inquilino p = null;
            try
            {
                p = repo.ObtenerPorId(id);
                p.Nombre = inquilino.Nombre;
                p.Apellido = inquilino.Apellido;
                p.DNI = inquilino.DNI;
                p.Telefono = inquilino.Telefono;
                p.Email = inquilino.Email;
                repo.ModificacionInquilino(p);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                throw;
            }
        }

        // GET: inquilinos/Delete/5
        public ActionResult Delete(int id)
        {
            var inquilino = repo.ObtenerPorId(id);
            return View(inquilino);
        }

        // POST: inquilinos/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Inquilino inquilino)
        {
            try
            {

                repo.BajaInquilino(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
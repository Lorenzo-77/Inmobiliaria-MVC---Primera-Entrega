using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using inmobiliaria_Lorenzo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace inmobiliaria_Lorenzo.Controllers
{
    public class PropietariosController : Controller
    {
        private RepositorioPropietario repo;
        public PropietariosController()
        {
            repo = new RepositorioPropietario();
        }
        // GET: Propietarios
        public ActionResult Index()
        {
            var propietarios = repo.ObtenerPropietarios();
            return View(propietarios);
        }

        // GET: Propietarios/Details/5
        public ActionResult Details(int id)
        {
            var propietario = repo.ObtenerPorId(id);
            return View(propietario);
        }

        // GET: Propietarios/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Propietarios/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Propietario propietario)
        {
            try
            {
                repo.AltaPropietario(propietario);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                throw;
            }
        }

        // GET: Propietarios/Edit/5y
        public ActionResult Edit(int id)
        {
            var propietario = repo.ObtenerPorId(id);
            return View(propietario);
        }

        // POST: Propietarios/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Propietario propietario)
        {
            Propietario p = null;
            try
            {
                p = repo.ObtenerPorId(id);
                p.Nombre = propietario.Nombre;
                p.Apellido = propietario.Apellido;
                p.DNI = propietario.DNI;
                p.Telefono = propietario.Telefono;
                p.Email = propietario.Email;
                repo.ModificacionPropietario(p);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                throw;
            }
        }

        // GET: Propietarios/Delete/5
        public ActionResult Delete(int id)
        {
            var propietario = repo.ObtenerPorId(id);
            return View(propietario);
        }

        // POST: Propietarios/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Propietario propietario)
        {
            try
            {

                repo.BajaPropietario(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
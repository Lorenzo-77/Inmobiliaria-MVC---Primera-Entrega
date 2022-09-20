using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using inmobiliaria_Lorenzo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace inmobiliaria_Lorenzo.Controllers
{
    public class TipoInmueblesController : Controller
    {
        private RepositorioTipoInmueble repoTipoInmueble;
        public TipoInmueblesController(IConfiguration configuration)
        {
            repoTipoInmueble = new RepositorioTipoInmueble(configuration);
        }
        // GET: TipoInmuebles
        public ActionResult Index()
        {
            var tipoInmuebles = repoTipoInmueble.ObtenerTipoInmueble();
            return View(tipoInmuebles);

        }

        // GET: TipoInmuebles/Details/5
        public ActionResult Details(int id)
        {
            var tipoInmuebles = repoTipoInmueble.ObtenerPorId(id);
            return View(tipoInmuebles);
        }

        // GET: TipoInmuebles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoInmuebles/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TipoInmueble tipoInmueble)
        {
            try
            {
                repoTipoInmueble.AltaTipoInmueble(tipoInmueble);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                throw;
            }
        }

        // GET: TipoInmuebles/Edit/5
        public ActionResult Edit(int id)
        {
            var tipoInmuebles = repoTipoInmueble.ObtenerPorId(id);
            return View(tipoInmuebles);
        }

        // POST: TipoInmuebles/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TipoInmueble tipoInmueble)
        {
            TipoInmueble t = null;
            try
            {
                t = repoTipoInmueble.ObtenerPorId(id);
                t.Descripcion = tipoInmueble.Descripcion;
                repoTipoInmueble.ModificacionTipoInmueble(t);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                throw;
            }
        }

        // GET: TipoInmuebles/Delete/5
        public ActionResult Delete(int id)
        {
            var tipoInmuebles = repoTipoInmueble.ObtenerPorId(id);
            return View(tipoInmuebles);
        }

        // POST: TipoInmuebles/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, TipoInmueble tipoInmueble)
        {
            try
            {
                repoTipoInmueble.BajaTipoInmueble(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
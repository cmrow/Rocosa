using Microsoft.AspNetCore.Mvc;
using Rocosa.Datos;
using Rocosa.Models;
using System.Collections.Generic;

namespace Rocosa.Controllers
{
    public class TipoAplicacionController : Controller
    {
        private readonly ApplicationDbContext _db;

        public TipoAplicacionController(ApplicationDbContext db)
        {
            _db = db;
        }
    
        public IActionResult Index()
        {
            IEnumerable<TipoAplicacion> Lista = _db.TipoAplicacion;
            return View(Lista);
        }
        //Get
        public IActionResult Crear()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Crear(TipoAplicacion tipoAplicacion)
        {
            _db.TipoAplicacion.Add(tipoAplicacion);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
    }
}

using Inventario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventario.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Reporte()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Crear(Producto producto)
        {
            return View();
        }
    }
}
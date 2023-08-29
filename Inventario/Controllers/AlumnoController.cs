using Inventario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventario.Controllers
{
    public class AlumnoController : Controller
    {
        // GET: Alumno
        public ActionResult Index()
        {
            Alumno a = new Alumno();
            a.Id = 1;
            a.Nombre = "Jorge";

            Alumno b = new Alumno();
            b.Id = 2;
            b.Nombre = "Isidora";

            Alumno c = new Alumno();
            c.Id = 3;
            c.Nombre = "Juan";

            List<Alumno> alumnos = new List<Alumno>
            {
                a,
                b,
                c
            };

            return View(alumnos);
        }
    }
}
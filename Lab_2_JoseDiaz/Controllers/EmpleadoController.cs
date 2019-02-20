using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Lab_2_JoseDiaz.Models;
using Lab_2_JoseDiaz.Controllers;
using Lab_2_JoseDiaz.Repository;
using Lab_2_JoseDiaz.Entities;

namespace Lab_2_JoseDiaz.Controllers
{
    public class EmpleadoController : Controller
    {
        readonly IEmpleadoRepository empleadoRepository;
        public EmpleadoController(IEmpleadoRepository empleadoRepository)
        {
            this.empleadoRepository = empleadoRepository;
        }

        // GET: Empleado con todo y busqueda implementada 
        public ActionResult Index(string SearchString)
        {
            if (string.IsNullOrEmpty(SearchString))
            {
                List<EmpleadoViewModel> listaEmpleados = empleadoRepository.ObtenerEmpleados();
                return View(listaEmpleados);
            }
            else
            {
                List<EmpleadoViewModel> listaEmpleados = empleadoRepository.ObtenerEmpleados().FindAll(x => x.Nombre.Contains(SearchString) || x.Id == Convert.ToInt32(SearchString) || x.horas_trabajadas == Convert.ToDouble(SearchString));
                ViewBag.SearchString = SearchString;
                return View(listaEmpleados);
            }
        }
        

        // GET: Empleado/Details/5
        public ActionResult Details(int id)
        {
            EmpleadoViewModel empleado = empleadoRepository.ObtenerEmpleado(id);
            return View(empleado);
        }
        //Todo esto crea un nuevo empleado
        // GET: Empleado/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Empleado/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm]EmpleadoViewModel empleado)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    // TODO: Add insert logic here
                    empleadoRepository.CrearEmpleado(empleado);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(empleado);
                }

            }
            catch
            {
                return View();
            }
        }
                      

        // GET: Empleado/Edit/5
        public ActionResult Edit(int id)
        {
            EmpleadoViewModel empleado = empleadoRepository.ObtenerEmpleado(id);
            return View(empleado);
        }

        // POST: Empleado/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [FromForm]EmpleadoViewModel empleado)
        {
            try
            {
                empleadoRepository.ModificarEmpleado(empleado);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Empleado/Delete/5
        public ActionResult Delete(int id)
        {
            EmpleadoViewModel empleado = empleadoRepository.ObtenerEmpleado(id);
            return View(empleado);
        }

        // POST: Empleado/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, [FromForm] EmpleadoViewModel empleado)
        {
            try
            {
                // TODO: Add delete logic here
                empleadoRepository.QuitarEmpleado(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
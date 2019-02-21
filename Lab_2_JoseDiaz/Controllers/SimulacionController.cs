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
    public class SimulacionController : Controller
    {
        readonly IEmpleadoRepository empleadoRepository;
        public SimulacionController(IEmpleadoRepository empleadoRepository)
        {
            this.empleadoRepository = empleadoRepository;
        }

        // GET: Simulacion
        public ActionResult Index()
        {
            List<EmpleadoViewModel> listaEmpleados = empleadoRepository.ObtenerEmpleados();
            empleadoRepository.SimularSalidas();
            return View(listaEmpleados);
        }

        public ActionResult Terminar()
        {
            List<EmpleadoViewModel> listaEmpleados = empleadoRepository.ObtenerEmpleados();
                       
            empleadoRepository.CalcularSalario();
            return View(listaEmpleados);
        }

        // GET: Simulacion/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Simulacion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Simulacion/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Simulacion/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Simulacion/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Simulacion/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Simulacion/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
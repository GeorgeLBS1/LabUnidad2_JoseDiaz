using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Lab_2_JoseDiaz.Models;
using Lab_2_JoseDiaz.Repository;
using Lab_2_JoseDiaz.ArbolValanceadoUtils;
using Lab_2_JoseDiaz.Entities;

namespace Lab_2_JoseDiaz.Controllers
{
    public class AVLController : Controller
    {
        public static int total;
        readonly IAVLRepository aVLRepository;
        public static List<CarritoEntity> carritoDeCompras = new List<CarritoEntity>();
        public static List<FarmacoEntity> s = new List<FarmacoEntity>();
        public static List<FarmacoEntity> SinInventario = new List<FarmacoEntity>();
        public static ClienteViewModel persona = new ClienteViewModel();

        public AVLController(IAVLRepository aVLRepository)
        {
            this.aVLRepository = aVLRepository;
            aVLRepository.LoadFile();
        }

        // GET: AVL
        public ActionResult Index(string SearchString, int page = 1)
        {
            ViewBag.PageNum = page;
            List<FarmacoEntity> listafarmacos = new List<FarmacoEntity>();

            if (string.IsNullOrEmpty(SearchString))
            {
                listafarmacos.Clear();

                return View(listafarmacos);
            }
            else
            {
                listafarmacos.Clear();
                ViewBag.SearchString = SearchString;

                listafarmacos = aVLRepository.BuscarFarmacos(SearchString, page, 5);
                ViewBag.ele = aVLRepository.Buscar(SearchString).Count;
                ViewBag.total = ((aVLRepository.Buscar(SearchString).Count) / 5) + 1;
                s = listafarmacos;
                return View(listafarmacos.FindAll(x => x.Existencia > 0));

            }
        }

        // GET: AVL/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AVL/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AVL/Create
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

        // GET: AVL/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AVL/Edit/5
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

        // GET: AVL/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AVL/Delete/5
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
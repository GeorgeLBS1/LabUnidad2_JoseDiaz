﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Lab_2_JoseDiaz.Models;
using Lab_2_JoseDiaz.Repository;
using Lab_2_JoseDiaz.ArbolBinarioUtils;
using Lab_2_JoseDiaz.Entities;

namespace Lab_2_JoseDiaz.Controllers
{
    public class ArbolBinarioController : Controller
    {
        readonly IArbolBinarioRepository arbolBinarioRepository;
        public ArbolBinarioController(IArbolBinarioRepository arbolBinarioRepository)
        {
            this.arbolBinarioRepository = arbolBinarioRepository;
        }
        // GET: ArbolBinario
        public ActionResult Index(string SearchString)
        {
            arbolBinarioRepository.LoadFile();
            if (string.IsNullOrEmpty(SearchString))
            {
                List<FarmacoEntity> l = new List<FarmacoEntity>();
                l.Add(new FarmacoEntity() {Precio = 0, Existencia = 0, Nombre = "", CasaProductora = "", Descripcion = ""});

                return View(l);
            }
            else
            {
                ViewBag.SearchString = SearchString;
                List<FarmacoEntity> listafarmacos = arbolBinarioRepository.BuscarFarmacos(SearchString, 1, 5);
                return View(listafarmacos);
                
            }            
            
        }

        // GET: ArbolBinario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ArbolBinario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ArbolBinario/Create
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

        // GET: ArbolBinario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ArbolBinario/Edit/5
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

        // GET: ArbolBinario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ArbolBinario/Delete/5
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
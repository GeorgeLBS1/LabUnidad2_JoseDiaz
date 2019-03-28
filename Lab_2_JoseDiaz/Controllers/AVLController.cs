﻿using System;
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

        public ActionResult Productos()
        {
            string total;
            total = aVLRepository.Total_compra(carritoDeCompras);
            ViewBag.precioFinal = total;
            persona.total = total;
            return View(carritoDeCompras);
        }

        
        public ActionResult Details(string id, int SearchInt)
        {
            FarmacoEntity farmaco = s.Find(x => x.Nombre == id);
            if (SearchInt == 0 || string.IsNullOrEmpty(Convert.ToString(SearchInt)))
            {

                return View(farmaco);
            }
            else
            {
                CarritoEntity carrito = new CarritoEntity();
                ViewBag.SearchInt = SearchInt;

                //Metodo para editar los valores del arbol y del archivo de texto va aquí
                farmaco.Existencia -= SearchInt;
                aVLRepository.Modificar(id, farmaco.Existencia);

                carrito.Nombre = farmaco.Nombre;
                carrito.Precio = farmaco.Precio;
                carrito.Descripcion = farmaco.Descripcion;
                carrito.CasaProductora = farmaco.CasaProductora;
                carrito.cantidad = SearchInt;
                carrito.total = carrito.Precio * carrito.cantidad;
                carritoDeCompras.Add(carrito);
                TempData["msg"] = "<script>alert('Añadido al carrito');</script>";
                return View(farmaco);
            }


        }
                
        public ActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm]ClienteViewModel cliente)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    Facturacion f = new Facturacion();
                    // TODO: Add insert logic here
                    persona.nombre = cliente.nombre;
                    persona.nit = cliente.nit;
                    persona.direccion = cliente.nit;
                    cliente.total = persona.total;
                    f.CrearFactura(cliente, carritoDeCompras);
                    TempData["a"] = "<script>alert('Compra realizada con éxito');</script>";
                    carritoDeCompras.Clear();
                    cliente.total = "0";

                    return Redirect("Productos");

                }
                else
                {
                    return Redirect("Index");
                }
            }
            catch
            {
                return View();
            }
        }

    }
}
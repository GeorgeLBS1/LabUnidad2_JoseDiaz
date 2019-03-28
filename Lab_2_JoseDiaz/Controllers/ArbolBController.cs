using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Lab_2_JoseDiaz.Models;
using Lab_2_JoseDiaz.Repository;
using Lab_2_JoseDiaz.ArbolBUtils;
using Lab_2_JoseDiaz.Entities;
using Lab_2_JoseDiaz.ArbolBinarioUtils;

namespace Lab_2_JoseDiaz.Controllers
{
    public class ArbolBController : Controller
    {

        public static int total;
        readonly IArbolBRepository arbolBRepository;
        public static List<CarritoEntity> carritoDeCompras = new List<CarritoEntity>();
        public static List<FarmacoEntity> s = new List<FarmacoEntity>();
        public static List<FarmacoEntity> SinInventario = new List<FarmacoEntity>();
        public static ClienteViewModel persona = new ClienteViewModel();

        public ArbolBController(IArbolBRepository arbolBRepository)
        {
            this.arbolBRepository = arbolBRepository;
            arbolBRepository.LoadFile();
        }

        // GET: ArbolB
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

                listafarmacos = arbolBRepository.BuscarFarmacos(SearchString, page, 5);
                ViewBag.ele = arbolBRepository.Buscar(SearchString).Count;
                ViewBag.total = ((arbolBRepository.Buscar(SearchString).Count) / 5) + 1;
                s = listafarmacos;
                return View(listafarmacos.FindAll(x => x.Existencia > 0));

            }


        }

        public ActionResult Productos()
        {
            string total;
            total = arbolBRepository.Total_compra(carritoDeCompras);
            ViewBag.precioFinal = total;
            persona.total = total;
            return View(carritoDeCompras);
        }

        // GET: ArbolBinario/Details/5
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
                arbolBRepository.Modificar(id, farmaco.Existencia);

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

        // GET: ArbolBinario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ArbolBinario/Create
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
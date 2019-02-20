using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab_2_JoseDiaz.Models;
using Lab_2_JoseDiaz.Controllers;
using Lab_2_JoseDiaz.Repository;
using Lab_2_JoseDiaz.Entities;
using Newtonsoft.Json;

namespace Lab_2_JoseDiaz.Repository
{
    public class EmpleadoFileRepository : IEmpleadoRepository
    {
        List<EmpleadoViewModel> listaEmpleados = new List<EmpleadoViewModel>();
        public EmpleadoFileRepository()
        {
            string texto = System.IO.File.ReadAllText("Empleados.json");
            listaEmpleados = JsonConvert.DeserializeObject<List<EmpleadoViewModel>>(texto);

        }

        public EmpleadoViewModel ObtenerEmpleado(int id)
        {
            EmpleadoViewModel empleado =
                listaEmpleados.FirstOrDefault(x => x.Id == id);
            return empleado;
        }

        public List<EmpleadoViewModel> ObtenerEmpleados()
        {
            return listaEmpleados;
        }

        public void CrearEmpleado(EmpleadoViewModel nuevo)
        {
            listaEmpleados.Add(nuevo);
            try
            {
                string texto = JsonConvert.SerializeObject(listaEmpleados);
                System.IO.File.WriteAllText("Empleados.json", texto);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
        }

        public void ModificarEmpleado(EmpleadoViewModel nuevo)
        {
            for (int i = 0; i < listaEmpleados.Count; i++)
            {
                if (listaEmpleados[i].Id == nuevo.Id)
                {
                    listaEmpleados[i].Nombre = nuevo.Nombre;
                    listaEmpleados[i].Estado = nuevo.Estado;
                    listaEmpleados[i].horas_trabajadas = nuevo.horas_trabajadas;
                    listaEmpleados[i].hora_deEntrada = nuevo.hora_deEntrada;
                }
                try
                {
                    string texto = JsonConvert.SerializeObject(listaEmpleados);
                    System.IO.File.WriteAllText("Empleados.json", texto);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    throw;
                }
            }
        }

        public void QuitarEmpleado(int id)
        {
            listaEmpleados.RemoveAt(listaEmpleados.FindIndex(x => x.Id == id));
            try
            {
                string texto = JsonConvert.SerializeObject(listaEmpleados);
                System.IO.File.WriteAllText("Empleados.json", texto);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
        }
    }
}

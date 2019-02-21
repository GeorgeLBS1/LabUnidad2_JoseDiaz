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

        void IEmpleadoRepository.CalcularSalario()
        {
            string resetHora = "2019-02-08T07:00:55.714";
            for (int i = 0; i < listaEmpleados.Count; i++)
            {
                
                int final;
                final = Math.Abs(listaEmpleados[i].hora_deEntrada.Hour - listaEmpleados[i].hora_deRegreso.Hour);
                listaEmpleados[i].horas_trabajadas = final;
                listaEmpleados[i].Sueldo = listaEmpleados[i].Sueldo + Math.Abs(listaEmpleados[i].horas_trabajadas * 38.0);
                listaEmpleados[i].hora_deEntrada = Convert.ToDateTime(resetHora);
            }
        }

        

        void IEmpleadoRepository.SimularSalidas()
        {
            Random r = new Random();
            double horas, minutos;
            
            for (int i = 0; i < listaEmpleados.Count; i++)
            {
                if (listaEmpleados[i].Estado == true)
                {
                    horas = Convert.ToDouble(r.Next(1, 4));
                    horas = 1.5 * horas;
                    minutos =  (Math.Abs(Convert.ToInt32(Math.Truncate(horas)) - horas))*60;

                    TimeSpan s = new TimeSpan(Convert.ToInt32(horas), Convert.ToInt32(minutos), 0);
                    listaEmpleados[i].hora_deRegreso = listaEmpleados[i].hora_deEntrada.Date + s;
                    listaEmpleados[i].Estado = false;
                }
            }
        }
    }
}

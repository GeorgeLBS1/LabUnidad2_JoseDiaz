using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab_2_JoseDiaz.Models;
using Lab_2_JoseDiaz.Entities;
namespace Lab_2_JoseDiaz.Repository
{
    public class EmpleadoRepository : IEmpleadoRepository
    {
        List<EmpleadoViewModel> listaEmpleados = new List<EmpleadoViewModel>();
        public EmpleadoRepository()
        {

            listaEmpleados.Add(new EmpleadoViewModel()
            {
                Id = 1,
                Nombre = "Willy",
                Estado = false,
                hora_deEntrada = DateTime.Now,
                horas_trabajadas = 0
                
                
            });
            EmpleadoViewModel est2 = new EmpleadoViewModel()
            {
                Id = 2,
                Nombre = "Miriam",
                Estado = true,
                hora_deEntrada = DateTime.Now,
                horas_trabajadas = 5.0
            };
            listaEmpleados.Add(est2);
            EmpleadoViewModel est3 = new EmpleadoViewModel();
            est3.Id = 3;
            est3.Nombre = "Juan";
            est3.Estado = false;
            est3.hora_deEntrada = DateTime.Now;
            est3.horas_trabajadas = 0;
           
            listaEmpleados.Add(est3);

        }
        public EmpleadoViewModel ObtenerEmpleado(int id)
        {
            EmpleadoViewModel Empleado =
                listaEmpleados.FirstOrDefault(x => x.Id == id);
            
            return Empleado;
        }                            

        public List<EmpleadoViewModel> ObtenerEmpleados()
        {
            return listaEmpleados;
        }
        
        public void CrearEmpleado(EmpleadoViewModel nuevo)
        {
            listaEmpleados.Add(nuevo);
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
            }
        }
        public void QuitarEmpleado(int id)
        {
            listaEmpleados.RemoveAt(listaEmpleados.FindIndex(x => x.Id == id));
        }
        
    }
}

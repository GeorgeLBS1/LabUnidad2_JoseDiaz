using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab_2_JoseDiaz.Models;
using Lab_2_JoseDiaz.Controllers;
using Lab_2_JoseDiaz.Repository;
using Lab_2_JoseDiaz.Entities;

namespace Lab_2_JoseDiaz.Repository
{
    public interface IEmpleadoRepository
    {
        List<EmpleadoViewModel> ObtenerEmpleados();        
        EmpleadoViewModel ObtenerEmpleado(int id);        
        void CrearEmpleado(EmpleadoViewModel nuevo);
        void ModificarEmpleado(EmpleadoViewModel nuevo);
        void QuitarEmpleado(int id);
        void CalcularSalario();
        void SimularSalidas();
        

    }
}

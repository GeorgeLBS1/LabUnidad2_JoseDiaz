using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab_2_JoseDiaz.Models;
using Lab_2_JoseDiaz.Controllers;
using Lab_2_JoseDiaz.Repository;

namespace Lab_2_JoseDiaz.Entities
{
    public class OficinaEntity
    {
        public string Nombre { get; set; }
        public bool Estado { get; set; }
        public int Id { get; set; }
        public double horas_trabajadas { get; set; }
        public DateTime hora_deEntrada { get; set; }
        public List<EmpleadoViewModel> Empleados { get; set; }
    }
}

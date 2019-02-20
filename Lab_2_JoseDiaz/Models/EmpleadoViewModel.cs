using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Lab_2_JoseDiaz.Models;
using Lab_2_JoseDiaz.Entities;

namespace Lab_2_JoseDiaz.Models
{
    public class EmpleadoViewModel
    {
        [Required(ErrorMessage = "El nombre del empleado es requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El código del empleado es requerido")]
        public int Id { get; set; }
        [Required(ErrorMessage = "El estado del empleado es requerido")]
        public bool Estado { get; set; }
        [Required(ErrorMessage = "El numero de horas es requerido")]
        public double horas_trabajadas { get; set; }
        public DateTime hora_deEntrada { get; set; }

    }
}

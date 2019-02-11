using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Timers;

namespace Lab_2_JoseDiaz
{
    public class Empleado
    {
        public string nombre;
        public int codigo_empleado;
        public double horas_trabajadas;
        public bool Esta_En_La_Oficina;
        public double Sueldo;
        const double Pago_Hora = 38.00;
    }
}

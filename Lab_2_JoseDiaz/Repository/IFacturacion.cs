using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab_2_JoseDiaz.Models;
using Lab_2_JoseDiaz.Entities;
namespace Lab_2_JoseDiaz.Repository
{
    interface IFacturacion
    {
        void CrearFactura(ClienteViewModel cliente, List<CarritoEntity> carrito);
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Lab_2_JoseDiaz.ArbolBinarioUtils;
using Lab_2_JoseDiaz.Entities;
using Lab_2_JoseDiaz.ArbolBUtils;

namespace Lab_2_JoseDiaz.Repository
{
    public interface IArbolBRepository
    {
        void LoadFile();
        FarmacoEntity ObtenerFarmaco(int linea);
        List<FarmacoEntity> BuscarFarmacos(string valor, int numeroDePagina, int noElementos);
        List<FarmacoEntity> Recorrer(int valor);
        List<FarmacoEntity> Buscar(string valor);
        void Modificar(string valor, int cantidad);
        void Simulacion(List<FarmacoEntity> a);
        string Total_compra(List<CarritoEntity> carritoDeCompras);
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Lab_2_JoseDiaz.ArbolBinarioUtils;
using Lab_2_JoseDiaz.Entities;

namespace Lab_2_JoseDiaz.Repository
{
    public interface IArbolBinarioRepository
    {
        void LoadFile();
        FarmacoEntity ObtenerFarmaco(int linea);
        List<FarmacoEntity> BuscarFarmacos(string valor, int numeroDePagina, int noElementos);
        List<FarmacoEntity> Buscar(string valor);

    }
}

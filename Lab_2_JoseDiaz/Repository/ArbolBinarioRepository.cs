using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Lab_2_JoseDiaz.ArbolBinarioUtils;
using Lab_2_JoseDiaz.Entities;

namespace Lab_2_JoseDiaz.Repository
{
    public class ArbolBinarioRepository : IArbolBinarioRepository
    {
        string path = @"MOCK_DATA.csv";
        ArbolBinario<InfoIndice> arbolBinario;

        public ArbolBinarioRepository()
        {
            arbolBinario = new ArbolBinario<InfoIndice>();
        }

        public void LoadFile()
        {
            
            System.IO.StreamReader lector = new System.IO.StreamReader(path);
            while (!lector.EndOfStream)
            {
                string linea = lector.ReadLine();
                string[] valores = linea.Split(",");
                //numero de linea valores[0]
                //llave nombre [1]
                //cantidad[5]

                InfoIndice nuevoIndice = new InfoIndice();
                nuevoIndice.Linea = Convert.ToInt32(valores[0]);
                nuevoIndice.Nombre = valores[1];
                nuevoIndice.Existencia = Convert.ToInt32(valores[5]);
                arbolBinario.Agregar(nuevoIndice, nuevoIndice.Nombre);
            }
            lector.Close();
        }

        public FarmacoEntity ObtenerFarmaco(int linea)
        {
            FarmacoEntity farmaco = new FarmacoEntity();
            //string line = File.ReadLines(path).Skip(linea).Take(1).First();
            string line = File.ReadAllLines(path)
                    .Where(x => x.StartsWith(Convert.ToString(linea)))
                    .FirstOrDefault();
            string[] valores = line.Split(",");
            farmaco.Nombre = valores[1];
            var cultura = new System.Globalization.CultureInfo("en-US");
            farmaco.Precio = double.Parse(valores[4], NumberStyles.Currency, cultura);
            farmaco.Existencia = Convert.ToInt32(valores[5]);
            farmaco.Descripcion = valores[2];
            farmaco.CasaProductora = valores[3];


            //TODO: Leer farmaco de archivo
            return farmaco;

        }

        public List<FarmacoEntity> BuscarFarmacos(string valor, int numeroDePagina, int noElementos)
        {

            List<InfoIndice> superior = arbolBinario.Buscar(valor);
            List<InfoIndice> SinRepetidos = superior.GroupBy(x => x.Nombre).Select(y => y.First()).ToList();
            List<InfoIndice> listaIndices = SinRepetidos.Skip(numeroDePagina - 1 * noElementos).Take(noElementos).ToList();            

            List<FarmacoEntity> farmacoEntities = new List<FarmacoEntity>();

            foreach (var item in listaIndices)
            {
                farmacoEntities.Add(ObtenerFarmaco(item.Linea));
            }
            return farmacoEntities;
        }
    }
}

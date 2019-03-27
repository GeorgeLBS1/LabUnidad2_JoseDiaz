﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Lab_2_JoseDiaz.ArbolValanceadoUtils;
using Lab_2_JoseDiaz.Entities;


namespace Lab_2_JoseDiaz.Repository
{
    public class AVLRepository : IAVLRepository
    {        
        string path = @"MOCK_DATA.csv";
        AVL<string, Indice> arbolValanceado;
        public AVLRepository()
        {
            arbolValanceado = new AVL<string, Indice>();
        }
        //leer el archivo de texto
        public void LoadFile()
        {

            System.IO.StreamReader lector = new System.IO.StreamReader(path);
            while (!lector.EndOfStream)
            {
                string linea = lector.ReadLine();
                string[] valores = linea.Split(",");

                Indice nuevoIndice = new Indice();
                nuevoIndice.Linea = Convert.ToInt32(valores[0]);
                nuevoIndice.Nombre = valores[1];
                nuevoIndice.Existencia = Convert.ToInt32(valores[5]);
                arbolValanceado.Add(nuevoIndice.Nombre, nuevoIndice);
            }
            lector.Close();
        }
        public void Modificar(string valor, int cantidad)
        {
           
            
            List<Indice> superior = arbolValanceado.Buscar(valor);
            List<Indice> SinRepetidos = superior.GroupBy(x => x.Nombre).Select(y => y.First()).ToList();
            List<FarmacoEntity> farmacoEntities = new List<FarmacoEntity>();

            foreach (var item in SinRepetidos)
            {
                farmacoEntities.Add(ObtenerFarmaco(item.Linea));
            }
            int linea_a_editar = SinRepetidos.First().Linea;
            string linea_a_escribir = null;
            string concatenar = linea_a_editar + "," + farmacoEntities.First().Nombre + "," + farmacoEntities.First().Descripcion + "," + farmacoEntities.First().CasaProductora + ",$" + farmacoEntities.First().Precio + "," + cantidad;
            using (StreamReader reader = new StreamReader(path))
            {
                for (int i = 1; i <= linea_a_editar; ++i)
                    linea_a_escribir = reader.ReadLine();
            }
            string[] lines = File.ReadAllLines(path);
            // Write the new file over the old file.
            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int currentLine = 1; currentLine <= lines.Length; ++currentLine)
                {
                    if (currentLine == linea_a_editar)
                    {
                        writer.WriteLine(concatenar);
                    }
                    else
                    {
                        writer.WriteLine(lines[currentLine - 1]);
                    }
                }
            }
            if (cantidad == 0)
            {
                arbolValanceado.Eliminar(valor);
            }


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

            List<Indice> superior = arbolValanceado.Buscar(valor);
            List<Indice> SinRepetidos = superior.GroupBy(x => x.Nombre).Select(y => y.First()).ToList();
            List<Indice> listaIndices = SinRepetidos.Skip((numeroDePagina - 1) * noElementos).Take(noElementos).ToList();

            List<FarmacoEntity> farmacoEntities = new List<FarmacoEntity>();

            foreach (var item in listaIndices)
            {
                farmacoEntities.Add(ObtenerFarmaco(item.Linea));
            }
            return farmacoEntities;
        }
        public List<FarmacoEntity> Buscar(string valor)
        {
            List<Indice> superior = arbolValanceado.Buscar(valor);
            List<Indice> SinRepetidos = superior.GroupBy(x => x.Nombre).Select(y => y.First()).ToList();
            List<FarmacoEntity> farmacoEntities = new List<FarmacoEntity>();

            foreach (var item in SinRepetidos)
            {
                farmacoEntities.Add(ObtenerFarmaco(item.Linea));
            }
            return farmacoEntities;
        }
        public List<FarmacoEntity> Recorrer(int valor)
        {
            List<FarmacoEntity> losVacios = new List<FarmacoEntity>();
            List<Indice> superior = arbolValanceado.BuscarPorCantidad();
            List<Indice> SinRepetidos = superior.GroupBy(x => x.Nombre).Select(y => y.First()).ToList();
            List<FarmacoEntity> farmacoEntities = new List<FarmacoEntity>();

            foreach (var item in SinRepetidos)
            {
                farmacoEntities.Add(ObtenerFarmaco(item.Linea));
            }
            losVacios = farmacoEntities.FindAll(x => x.Existencia == valor).ToList();
            return losVacios;
        }
        public void Simulacion(List<FarmacoEntity> a)
        {
            Random r = new Random();
            for (int i = 0; i < a.Count; i++)
            {
                a[i].Existencia = r.Next(1, 15);
                Modificar(a[i].Nombre, a[i].Existencia);
            }

        }
        public string Total_compra(List<CarritoEntity> carritoDeCompras)
        {
            double suma = 0;
            for (int i = 0; i < carritoDeCompras.Count; i++)
            {
                suma += carritoDeCompras[i].total;
            }
            suma = Math.Round(suma, 2);
            return Convert.ToString(suma);
        }
    }
}

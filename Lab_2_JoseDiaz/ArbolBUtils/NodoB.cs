using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab_2_JoseDiaz.ArbolBinarioUtils;

namespace Lab_2_JoseDiaz.ArbolBUtils
{
    public class NodoB
    {
        public InfoIndice[] Llaves; 
        public int GradoMinimo;       
        public bool Condicion;
        public List<InfoIndice> superior = new List<InfoIndice>(); //LISTA IMPORTANTE
        public NodoB[] Hijos; 
        public int n;  
        public NodoB(int ValorLLave, bool ValidadorHoja)
        {
            GradoMinimo = ValorLLave;
            Condicion = ValidadorHoja;
            Llaves = new InfoIndice[2 * GradoMinimo - 1];
            Hijos = new NodoB[2 * GradoMinimo];
            n = 0;

        }
        public void insertarVacio(InfoIndice infoNodo)
        {
            int i = n - 1;
            if (Condicion == true)
            {
                while (i >= 0 && string.Compare(Llaves[i].Nombre, infoNodo.Nombre) > 0)
                {
                    Llaves[i + 1] = Llaves[i];
                    i--;
                }
                Llaves[i + 1] = infoNodo;
                n = n + 1;
            }
            else
            {
                while (i >= 0 && string.Compare(Llaves[i].Nombre, infoNodo.Nombre) > 0)
                    i--;

                if (Hijos[i + 1].n == 2 * GradoMinimo - 1)
                {
                    DividirHijo(i + 1, Hijos[i + 1]);

                    if (string.Compare(Llaves[i + 1].Nombre, infoNodo.Nombre) < 0) { i++; }

                }
                Hijos[i + 1].insertarVacio(infoNodo);

            }
        }

        public void DividirHijo(int i, NodoB temporal)
        {
            NodoB aux = new NodoB(temporal.GradoMinimo, temporal.Condicion);
            aux.n = GradoMinimo - 1;

            for (int j = 0; j < GradoMinimo - 1; j++)
            {
                aux.Llaves[j] = temporal.Llaves[j + GradoMinimo];

            }

            if (temporal.Condicion == false)
            {
                for (int j = 0; j < GradoMinimo; j++)
                {
                    aux.Hijos[j] = temporal.Hijos[j + GradoMinimo];
                }
            }

            temporal.n = GradoMinimo - 1;


            for (int j = n; j >= i + 1; j--)
            {
                Hijos[j + 1] = Hijos[j];
            }

            Hijos[i + 1] = aux;

            for (int j = n - 1; j >= i; j--)
                Llaves[j + 1] = Llaves[j];

            Llaves[i] = temporal.Llaves[GradoMinimo - 1];

            n = n + 1;
        }               
        
        public void Recorrido()
        {
            int i = 0;
            for (i = 0; i < n; i++)
            {
                if (Condicion == false)
                    Hijos[i].Recorrido();
                superior.Add(Llaves[i]);
            }
            if (Condicion == false)
                Hijos[i].Recorrido();
        }
    }
}

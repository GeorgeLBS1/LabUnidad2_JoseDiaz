using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab_2_JoseDiaz.ArbolBinarioUtils;

namespace Lab_2_JoseDiaz.ArbolBUtils
{
    public class ArbolB
    {
        int LLAVE;

        NodoB raiz;
        

        public ArbolB(int LInicial)
        {
            raiz = null;
            LLAVE = LInicial;
        }


        public void insertar(InfoIndice k)
        {
            if (raiz == null)
            {
                raiz = new NodoB(LLAVE, true);
                raiz.Llaves[0] = k;
                raiz.n = 1;
            }
            else
            {
                if (raiz.n == 2 * LLAVE - 1)
                {
                    NodoB temp = new NodoB(LLAVE, false);
                    temp.Hijos[0] = raiz;
                    temp.DividirHijo(0, raiz);

                    int i = 0;
                    if (string.Compare(temp.Llaves[0].Nombre, k.Nombre) < 0)
                        i++;

                    temp.Hijos[i].insertarVacio(k);

                    raiz = temp;
                }
                else
                {
                    raiz.insertarVacio(k);

                }
            }
        }
        public void recorrer()
        {
            if (raiz != null)
            {
                
                raiz.Recorrido();
            }
        }

        public List<InfoIndice> Obtener_recorrido()
        {
            recorrer();
            return raiz.superior;
        }

        public void eliminar(string valor)
        {

        }
    }
}

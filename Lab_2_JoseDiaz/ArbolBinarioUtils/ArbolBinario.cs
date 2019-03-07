using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_2_JoseDiaz.ArbolBinarioUtils
{
    public class ArbolBinario<T>
    {
        private Nodo<T> Raiz;

        public void Agregar(T valor, string nuevaLlave)
        {
            if(Raiz == null)
            {
                Nodo<T> nuevoNodo = new Nodo<T>();
                nuevoNodo.Valor = valor;
                nuevoNodo.Llave = nuevaLlave;
                Raiz = nuevoNodo;
            }
            else {
                Agregar(valor, nuevaLlave, Raiz);
            }
        }

        private void Agregar(T valor, string nuevaLlave, Nodo<T> nodo)
        {
            
            Nodo<T> tmp = nodo;
            //nuevaLlave < tmp.llave
            if (nuevaLlave.CompareTo(tmp.Llave) == -1)
            {
                if (tmp.Izquierda == null)
                {
                    Nodo<T> nuevoNodo = new Nodo<T>();
                    nuevoNodo.Valor = valor;
                    nuevoNodo.Llave = nuevaLlave;
                    tmp.Izquierda = nuevoNodo;
                }
                else
                {
                    Agregar(valor, nuevaLlave, tmp.Izquierda);
                }
            }
            else
            {
                if (tmp.Derecha == null)
                {
                    Nodo<T> nuevoNodo = new Nodo<T>();
                    nuevoNodo.Valor = valor;
                    nuevoNodo.Llave = nuevaLlave;
                    tmp.Derecha = nuevoNodo;
                }
                else
                {
                    Agregar(valor, nuevaLlave, tmp.Derecha);
                }
            }
        }

        
        public List<T> Buscar(string valor)
        {
            List<T> superior = new List<T>();
            InfoIndice nuevo = new InfoIndice();
            List<T> infoIndices = new List<T>();
            return recorrido_aux(valor, Raiz, superior);           

            //TODO: recorer arbol y evaluar valor

        }

        public List<T> recorrido_aux(string valor, Nodo<T> a, List<T> superior)
        {
            
            if (a.Llave.Contains(valor))
            {                
                superior.Add(a.Valor);
                return superior;
            }
            else if (a.Llave.CompareTo(valor) == -1)
            {
                return recorrido_aux(valor, a.Izquierda, superior);
            }
            else if (a.Llave.CompareTo(valor) == +1)
            {
                return recorrido_aux(valor, a.Derecha, superior);
            }
            else 
            {
                return superior;
            }
            
                

        }

        //public List<T> lista(Nodo<T> arbol, T x, string valor )
        //{
        //    List<T> asd = new List<T>();
        //    if (arbol == null)
        //    {
        //        return asd;
        //    }
        //    else if (arbol.Llave.Contains(valor))
        //    {
        //        asd.Add(x);
        //        return asd;
        //    }
        //    else if (arbol.Llave.CompareTo(valor) == -1)
        //    {
        //        return lista(arbol.Izquierda, x, valor);
        //    }
        //    else             
        //    return lista(arbol.Derecha, x, valor);

        //}

    }
}

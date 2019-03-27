using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_2_JoseDiaz.ArbolValanceadoUtils
{
    class AVL<Tllave, Tvalor> where Tllave : IComparable
    {
        

        public Tllave key;
        protected Tvalor valor;
        protected int hijo, altura, balanceado_o_no;
        protected AVL<Tllave, Tvalor> hijoIzquierdo;
        protected AVL<Tllave, Tvalor> padre;
        protected AVL<Tllave, Tvalor> hijoDerecho;

        
        //Constructores de las llaves y subarboles
        public Tllave Key
        {
            get { return this.key; }
            set { this.key = Key; }
        }
        public Tvalor Value
        {
            get { return this.valor; }
            set { this.valor = valor; }
        }
        public AVL<Tllave, Tvalor> HijoIzquierdo
        {
            get { return hijoIzquierdo; }
        }
        public AVL<Tllave, Tvalor> PADRE
        {
            get { return padre; }
        }
        public AVL<Tllave, Tvalor> HijoDerecho
        {
            get { return hijoDerecho; }
        }

        
        //Constructor del AVL inicial
        public AVL()
        {
            hijoIzquierdo = null;
            key = default(Tllave);
            valor = default(Tvalor);
            hijo = balanceado_o_no = 0;
            altura = -1;
            padre = null;
            hijoDerecho = null;
        }

        
        //añadir nuevo elemento
        public void Add(Tllave key, Tvalor valor)
        {
            if (EstaVacio())
            {
                Actualizar(this, key, valor); return;
            }
            AVL<Tllave, Tvalor> aux = Search(this, key);
            if (!aux.EstaVacio()) return;
            else
            {
                Actualizar(aux, key, valor);
                if (aux.padre != null) BalanceAdd(aux.padre); return;
            }
        }
        //Eliminación de un elemento específico
        public void Eliminar(Tllave key)
        {
            AVL<Tllave, Tvalor> aux = Search(this, key);
            if (aux.EsIzquierdo())
            {
                if (aux.padre == null)
                { aux.Key = default(Tllave); aux.Value = default(Tvalor); return; }
                if (aux.hijo == -1)
                { aux.padre.hijoIzquierdo = aux.hijoIzquierdo; aux.padre.hijoIzquierdo.padre = aux.padre; }
                else { aux.padre.hijoDerecho = aux.hijoDerecho; aux.padre.hijoDerecho.padre = aux.padre; }
                ActualizarN(aux.padre); return;
            }
            AVL<Tllave, Tvalor> aux2 = CantidadDeHijos(aux);
            if (aux2 != null)
            {
                if (aux.padre == null)
                {
                    Intercambiar(aux, aux2);
                    aux.hijoIzquierdo = aux2.hijoIzquierdo; aux.hijoIzquierdo.padre = aux;
                    aux.hijoDerecho = aux2.hijoDerecho; aux.hijoDerecho.padre = aux;
                    ActualizarN(aux); return;
                }
                if (aux.hijo == -1) { aux.padre.hijoIzquierdo = aux2; aux.padre.hijoIzquierdo.hijo = -1; }
                else { aux.padre.hijoDerecho = aux2; aux.padre.hijoDerecho.hijo = 1; }
                aux2.padre = aux.padre; ActualizarN(aux.padre); return;
            }
            AVL<Tllave, Tvalor> aux3 = BusquedaMm(aux.hijoDerecho);
            Intercambiar(aux, aux3);
            if (aux3.EsIzquierdo())
            {
                if (aux3.hijo == -1)
                { aux3.padre.hijoIzquierdo = aux3.hijoIzquierdo; aux3.padre.hijoIzquierdo.padre = aux3.padre; }
                else { aux3.padre.hijoDerecho = aux3.hijoDerecho; aux3.padre.hijoDerecho.padre = aux3.padre; }
                ActualizarN(aux3.padre); return;
            }
            if (aux3.hijo == -1)
            { aux3.padre.hijoIzquierdo = aux3.hijoDerecho; aux3.padre.hijoIzquierdo.hijo = -1; aux3.hijoDerecho.padre = aux3.padre; }
            else
            { aux3.padre.hijoDerecho = aux3.hijoDerecho; aux3.hijoDerecho.padre = aux3.padre; }
            ActualizarN(aux3.padre); return;
        }

        //Buscar Si tiene la llave
        public AVL<Tllave, Tvalor> ContainsKey(Tllave key)
        {
            return Search(this, key);
        }
        bool Contiene(string key)
        {
            return Busc(this, key);
        }
        //Limpiar el arbol
        public static void Clear(AVL<Tllave, Tvalor> avl)
        {
            avl = new AVL<Tllave, Tvalor>();
        }

        public List<Tvalor> BuscarPorCantidad()
        {
            List<Tvalor> superior = new List<Tvalor>();
            Indice nuevo = new Indice();
            absoluto("a", padre, superior);
            return superior;
        }
        //Recorre todos los valores del arbol
        public void absoluto(string valor, AVL<Tllave, Tvalor> a, List<Tvalor> superior)
        {
            if (a != null)
            {
                superior.Add(a.valor);                
                absoluto(valor, padre.HijoIzquierdo, superior);
                absoluto(valor, padre.HijoDerecho, superior);
            }
        }

        

        protected bool EstaVacio()
        {
            return key == null || key.Equals(default(Tllave));
        }
        protected bool EsIzquierdo()
        {
            return altura == 0;
        }
        protected void Intercambiar(AVL<Tllave, Tvalor> aux, AVL<Tllave, Tvalor> aux3)
        {
            aux.key = aux3.key;
            aux.Value = aux3.Value;
        }
        protected void AlturaNuevaYbalance()
        {
            if (EstaVacio())
            { altura = -1; balanceado_o_no = 0; }
            else
            {
                altura = 1 + Math.Max(hijoIzquierdo.altura, hijoDerecho.altura);
                balanceado_o_no = hijoDerecho.altura - hijoIzquierdo.altura;
            }
        }
        protected void Actualizar(AVL<Tllave, Tvalor> avl, Tllave key, Tvalor valor)
        {
            avl.Key = key;
            avl.Value = valor;
            avl.hijoIzquierdo = new AVL<Tllave, Tvalor>();
            avl.hijoIzquierdo.padre = avl;
            avl.hijoIzquierdo.hijo = -1;
            avl.hijoDerecho = new AVL<Tllave, Tvalor>();
            avl.hijoDerecho.padre = avl;
            avl.hijoDerecho.hijo = 1;
            avl.AlturaNuevaYbalance();
        }
        protected void BalanceAdd(AVL<Tllave, Tvalor> avl)
        {
            avl.AlturaNuevaYbalance();
            if (avl.balanceado_o_no == 0) return;
            else if (avl.balanceado_o_no == -1 || avl.balanceado_o_no == 1)
            { if (avl.padre != null) BalanceAdd(avl.padre); }
            else if (avl.balanceado_o_no == 2 && avl.hijoDerecho.balanceado_o_no == 1)
            {
                RotacionIzquierda(avl);
                avl.hijoIzquierdo.AlturaNuevaYbalance(); avl.AlturaNuevaYbalance(); return;
            }
            else if (avl.balanceado_o_no == 2 && avl.hijoDerecho.balanceado_o_no == -1)
            {
                RotacionDerecha(avl.hijoDerecho);
                avl.hijoDerecho.hijoDerecho.AlturaNuevaYbalance(); avl.hijoDerecho.AlturaNuevaYbalance();
                RotacionIzquierda(avl);
                avl.hijoIzquierdo.AlturaNuevaYbalance(); avl.AlturaNuevaYbalance(); return;
            }
            else if (avl.balanceado_o_no == -2 && avl.hijoIzquierdo.balanceado_o_no == -1)
            {
                RotacionDerecha(avl);
                avl.hijoDerecho.AlturaNuevaYbalance(); avl.AlturaNuevaYbalance(); return;
            }
            else if (avl.balanceado_o_no == -2 && avl.hijoIzquierdo.balanceado_o_no == 1)
            {
                RotacionIzquierda(avl.hijoIzquierdo);
                avl.hijoIzquierdo.hijoIzquierdo.AlturaNuevaYbalance(); avl.hijoIzquierdo.AlturaNuevaYbalance();
                RotacionDerecha(avl);
                avl.hijoDerecho.AlturaNuevaYbalance(); avl.AlturaNuevaYbalance(); return;
            }
        }
        protected void ActualizarN(AVL<Tllave, Tvalor> avl)
        {
            avl.AlturaNuevaYbalance();
            if (avl.balanceado_o_no == -1 || avl.balanceado_o_no == 1) return;
            else if (avl.balanceado_o_no == 0)
            { if (avl.padre != null) ActualizarN(avl.padre); }
            else if (avl.balanceado_o_no == -2 && avl.hijoIzquierdo.balanceado_o_no == 0)
            {
                RotacionDerecha(avl);
                avl.hijoDerecho.AlturaNuevaYbalance(); avl.AlturaNuevaYbalance(); return;
            }
            else if (avl.balanceado_o_no == -2 && avl.hijoIzquierdo.balanceado_o_no == -1)
            {
                RotacionDerecha(avl);
                avl.hijoDerecho.AlturaNuevaYbalance(); avl.AlturaNuevaYbalance();
                if (avl.padre != null) ActualizarN(avl.padre);
            }
            else if (avl.balanceado_o_no == -2 && avl.hijoIzquierdo.balanceado_o_no == 1)
            {
                RotacionIzquierda(avl.hijoIzquierdo);
                avl.hijoIzquierdo.hijoIzquierdo.AlturaNuevaYbalance(); avl.hijoIzquierdo.AlturaNuevaYbalance();
                RotacionDerecha(avl);
                avl.hijoDerecho.AlturaNuevaYbalance(); avl.AlturaNuevaYbalance();
                if (avl.padre != null) ActualizarN(avl.padre);
            }
            else if (avl.balanceado_o_no == 2 && avl.hijoDerecho.balanceado_o_no == 0)
            {
                RotacionIzquierda(avl);
                avl.hijoIzquierdo.AlturaNuevaYbalance(); avl.AlturaNuevaYbalance(); return;
            }
            else if (avl.balanceado_o_no == 2 && avl.hijoDerecho.balanceado_o_no == 1)
            {
                RotacionIzquierda(avl);
                avl.hijoIzquierdo.AlturaNuevaYbalance(); avl.AlturaNuevaYbalance();
                if (avl.padre != null) ActualizarN(avl.padre);
            }
            else if (avl.balanceado_o_no == 2 && avl.hijoDerecho.balanceado_o_no == -1)
            {
                RotacionDerecha(avl.hijoDerecho);
                avl.hijoDerecho.hijoDerecho.AlturaNuevaYbalance(); avl.hijoDerecho.AlturaNuevaYbalance();
                RotacionIzquierda(avl);
                avl.hijoIzquierdo.AlturaNuevaYbalance(); avl.AlturaNuevaYbalance();
                if (avl.padre != null) ActualizarN(avl.padre);
            }
        }
        protected void RotacionDerecha(AVL<Tllave, Tvalor> avl)
        {
            AVL<Tllave, Tvalor> primary = new AVL<Tllave, Tvalor>();
            primary.Key = avl.Key;
            primary.Value = avl.Value;
            avl.key = avl.hijoIzquierdo.key;
            avl.Value = avl.hijoIzquierdo.Value;
            primary.hijoDerecho = avl.hijoDerecho;
            avl.hijoDerecho.padre = primary;
            avl.hijoDerecho = primary;
            primary.hijo = 1;
            avl.hijoDerecho.padre = avl;
            primary.hijoIzquierdo = avl.hijoIzquierdo.hijoDerecho;
            primary.hijoIzquierdo.hijo = -1;
            avl.hijoIzquierdo.hijoDerecho.padre = primary;
            avl.hijoIzquierdo = avl.hijoIzquierdo.hijoIzquierdo;
            avl.hijoIzquierdo.padre = avl;
        }
        protected void RotacionIzquierda(AVL<Tllave, Tvalor> avl)
        {
            AVL<Tllave, Tvalor> primary = new AVL<Tllave, Tvalor>();
            primary.Key = avl.Key;
            primary.Value = avl.Value;
            avl.key = avl.hijoDerecho.key;
            avl.Value = avl.hijoDerecho.Value;
            primary.hijoIzquierdo = avl.hijoIzquierdo;
            avl.hijoIzquierdo.padre = primary;
            avl.hijoIzquierdo = primary;
            primary.hijo = -1;
            avl.hijoIzquierdo.padre = avl;
            primary.hijoDerecho = avl.hijoDerecho.hijoIzquierdo;
            primary.hijoDerecho.hijo = 1;
            avl.hijoDerecho.hijoIzquierdo.padre = primary;
            avl.hijoDerecho = avl.hijoDerecho.hijoDerecho;
            avl.hijoDerecho.padre = avl;
        }
        protected AVL<Tllave, Tvalor> Search(AVL<Tllave, Tvalor> avl, Tllave key)
        {
            if (avl.EstaVacio()) return avl;
            if (key.CompareTo(avl.Key) < 0)
            {
                avl = avl.hijoIzquierdo;
                return Search(avl, key);
            }
            if (key.CompareTo(avl.Key) > 0)
            {
                avl = avl.hijoDerecho;
                return Search(avl, key);
            }
            return avl;
        }

        bool Busc(AVL<Tllave, Tvalor> avl, string key)
        {
            if (avl.EstaVacio()) return false;
            if (key.CompareTo(avl.Key) < 0)
            {
                avl = avl.hijoIzquierdo;
                return Busc(avl, key);
            }
            if (key.CompareTo(avl.Key) > 0)
            {
                avl = avl.hijoDerecho;
                return Busc(avl, key);
            }
            return true;
        }
        public List<Tvalor> Buscar(string valor)
        {
            List<Tvalor> superior = new List<Tvalor>();
            Indice nuevo = new Indice();

            Inorden(valor, padre, superior);

            return superior;

            //TODO: recorer arbol y evaluar valor

        }
        public void Inorden(string valor, AVL<Tllave, Tvalor> a , List<Tvalor> superior)
        {
            if (a != null)
            {

                if (a.Contiene(valor))
                {  
                   superior.Add(a.valor);
                }
                Inorden(valor, a.hijoIzquierdo, superior);
                Inorden(valor, a.hijoDerecho, superior);
            }

        }

        protected AVL<Tllave, Tvalor> CantidadDeHijos(AVL<Tllave, Tvalor> aux)
        {
            if (!aux.hijoIzquierdo.EstaVacio() && !aux.hijoDerecho.EstaVacio()) return null;
            else if (aux.hijoIzquierdo.EstaVacio() && !aux.hijoDerecho.EstaVacio()) return aux.hijoDerecho;
            else return aux.hijoIzquierdo;
        }
        protected AVL<Tllave, Tvalor> BusquedaMm(AVL<Tllave, Tvalor> aux)
        {
            if (aux.hijoIzquierdo.EstaVacio()) return aux;
            aux = aux.hijoIzquierdo;
            return BusquedaMm(aux);
        }

        
    }
} 
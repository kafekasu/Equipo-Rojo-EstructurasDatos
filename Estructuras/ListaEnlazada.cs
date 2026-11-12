using System;

namespace EquipoRojo.EstructurasDatos
{
    // Nodo: cada "eslabón" de la cadena
    public class Nodo
    {
        public string Dato;
        public Nodo Siguiente;

        public Nodo(string dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }

    public class ListaEnlazada
    {
        private Nodo cabeza;

        public ListaEnlazada()
        {
            cabeza = null;
        }

        // 1. INSERTAR al final
        public void Insertar(string dato)
        {
            Nodo nuevo = new Nodo(dato);

            if (cabeza == null)
            {
                cabeza = nuevo;
                return;
            }

            Nodo actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;
        }

        // 2. RECORRER / MOSTRAR
        public void Mostrar()
        {
            if (cabeza == null)
            {
                Console.WriteLine("  La lista está vacía.");
                return;
            }

            Nodo actual = cabeza;
            int i = 1;
            while (actual != null)
            {
                Console.WriteLine($"  {i}. {actual.Dato}");
                actual = actual.Siguiente;
                i++;
            }
        }

        // 3. BUSCAR
        public bool Buscar(string dato)
        {
            Nodo actual = cabeza;
            while (actual != null)
            {
                if (actual.Dato == dato) return true;
                actual = actual.Siguiente;
            }
            return false;
        }

        // 4. ELIMINAR
        public bool Eliminar(string dato)
        {
            if (cabeza == null) return false;

            if (cabeza.Dato == dato)
            {
                cabeza = cabeza.Siguiente;
                return true;
            }

            Nodo actual = cabeza;
            while (actual.Siguiente != null)
            {
                if (actual.Siguiente.Dato == dato)
                {
                    actual.Siguiente = actual.Siguiente.Siguiente;
                    return true;
                }
                actual = actual.Siguiente;
            }
            return false;
        }
    }
}

using System;

namespace EquipoRojo.EstructurasDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("=== ESTRUCTURAS DE DATOS - EQUIPO ROJO ===");
                Console.WriteLine();
                Console.WriteLine("--- Paquete 1: Lista enlazada simple ---");
                Console.WriteLine("  1. Lista enlazada simple (nodos)");
                Console.WriteLine("  2. Matriz 2D");
                Console.WriteLine("  3. Pila (Stack<T>)");
                Console.WriteLine();
                Console.WriteLine("--- Paquete 2: Lista doblemente enlazada ---");
                Console.WriteLine("  4. Lista doblemente enlazada (nodos)");
                Console.WriteLine("  5. Lista (List<T>)");
                Console.WriteLine("  6. Cola (Queue<T>)");
                Console.WriteLine();
                Console.WriteLine("--- Paquete 3: Lista circular ---");
                Console.WriteLine("  7. Lista circular (nodos)");
                Console.WriteLine("  8. Diccionario (Dictionary<K,V>)");
                Console.WriteLine("  9. Grafo con lista de adyacencia");
                Console.WriteLine();
                Console.WriteLine("--- Paquete 4: Árbol binario de búsqueda ---");
                Console.WriteLine(" 10. Árbol binario de búsqueda (nodos)");
                Console.WriteLine(" 11. Conjunto (HashSet<T>)");
                Console.WriteLine(" 12. Cola de prioridad (PriorityQueue<T,P>)");
                Console.WriteLine();
                Console.WriteLine("  0. Salir");
                Console.WriteLine();
                Console.Write("Elige una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        // TODO: Lista enlazada simple - Integrante 1
                        break;
                    case "2":
                        // TODO: Matriz 2D - Integrante 1
                        break;
                    case "3":
                        // TODO: Pila - Integrante 1
                        break;
                    case "4":
                        // TODO: Lista doblemente enlazada - Integrante 2
                        break;
                    case "5":
                        // TODO: List<T> - Integrante 2
                        break;
                    case "6":
                        // TODO: Queue<T> - Integrante 2
                        break;
                    case "7":
                        // TODO: Lista circular - Integrante 3
                        break;
                    case "8":
                        // TODO: Dictionary - Integrante 3
                        break;
                    case "9":
                        // TODO: Grafo - Integrante 3
                        break;
                    case "10":
                        // TODO: Árbol binario - Integrante 4
                        break;
                    case "11":
                        // TODO: HashSet - Integrante 4
                        break;
                    case "12":
                        // TODO: PriorityQueue - Integrante 4
                        break;
                    case "0":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Presiona Enter...");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}

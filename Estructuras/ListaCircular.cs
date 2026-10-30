using System;

namespace VisualNovelEngine
{
    // Estructura de datos para representar una pista de música
    public class BGMTrack
    {
        public string Title { get; set; }
        public string Filename { get; set; }

        public BGMTrack(string title, string filename)
        {
            Title = title;
            Filename = filename;
        }
    }

    // Nodo de la lista circular
    public class Node
    {
        public BGMTrack Data { get; set; }
        public Node Next { get; set; }

        public Node(BGMTrack data)
        {
            Data = data;
            Next = null;
        }
    }

    // Estructura de Lista Circular en C#
    public class CircularMusicPlaylist
    {
        private Node tail; // Apunta al último elemento (su 'Next' apunta a la cabeza)

        public bool IsEmpty => tail == null;

        // Agregar una pista al final de la lista circular
        public void AddTrack(string title, string filename)
        {
            BGMTrack newTrack = new BGMTrack(title, filename);
            Node newNode = new Node(newTrack);

            if (tail == null)
            {
                tail = newNode;
                tail.Next = tail; // Se apunta a sí mismo formando el bucle
            }
            else
            {
                newNode.Next = tail.Next; // El nuevo nodo apunta al primer elemento (cabeza)
                tail.Next = newNode;      // El antiguo tail apunta al nuevo nodo
                tail = newNode;           // El nuevo nodo se convierte en el tail definitivo
            }
        }

        // Avanzar a la siguiente pista de forma circular
        public Node NextTrack(ref Node currentPlaying)
        {
            if (currentPlaying == null) return null;

            currentPlaying = currentPlaying.Next;
            Console.WriteLine($"[BGM] Reproduciendo ahora: {currentPlaying.Data.Title} ({currentPlaying.Data.Filename})");
            return currentPlaying;
        }

        // Obtener el nodo inicial (la cabeza)
        public Node GetHead()
        {
            return tail?.Next;
        }

        // Mostrar toda la playlist en consola
        public void DisplayPlaylist()
        {
            if (tail == null)
            {
                Console.WriteLine("La playlist de la novela visual está vacía.");
                return;
            }

            Node current = tail.Next;
            Console.WriteLine("\n=== PLAYLIST DE LA NOVELA VISUAL (C#) ===");
            do
            {
                Console.WriteLine($" * {current.Data.Title} [{current.Data.Filename}]");
                current = current.Next;
            } while (current != tail.Next);
            Console.WriteLine("==========================================\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creamos nuestra lista circular en C#
            CircularMusicPlaylist gamePlaylist = new CircularMusicPlaylist();

            // Añadimos pistas de música al sistema
            gamePlaylist.AddTrack("Tema Principal (Opening)", "opening_theme.ogg");
            gamePlaylist.AddTrack("Escena de Misterio / Tensión", "mystery_loop.ogg");
            gamePlaylist.AddTrack("Momento Dramático / Reflexión", "emotional_piano.ogg");
            gamePlaylist.AddTrack("Conversación Casual / Comedia", "cheerful_town.ogg");

            // Mostramos la lista completa
            gamePlaylist.DisplayPlaylist();

            // Simulamos el reproductor de audio avanzando de forma circular
            Node currentPlaying = gamePlaylist.GetHead();
            if (currentPlaying != null)
            {
                Console.WriteLine("--- Iniciando motor de audio de la Novela Visual ---");
                Console.WriteLine($"Pista inicial: {currentPlaying.Data.Title}\n");

                // Simulamos cambios de escena que activan el siguiente tema en bucle
                gamePlaylist.NextTrack(ref currentPlaying);
                gamePlaylist.NextTrack(ref currentPlaying);
                gamePlaylist.NextTrack(ref currentPlaying);
                gamePlaylist.NextTrack(ref currentPlaying); // Regresa automáticamente al Opening
            }
        }
    }
}
using System;
using System.Xml.Linq;

namespace DoublyLinkedListsAnton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pregunta al usuario si la lista será circular
            Console.Write("¿Deseas que la lista sea circular? (s/n): ");
            string respuesta = Console.ReadLine().ToLower();

            // Se crea la lista doblemente enlazada, con opción circular según la respuesta del usuario
            DoublyLinkedList lista = new DoublyLinkedList(respuesta == "s");

            while (true)
            {
                MostrarMenu();
                Console.Write("Selecciona una opción: ");
                string opcion = Console.ReadLine().Trim();

                switch (opcion)
                {
                    case "1": // Agregar al final
                        Console.Write("Ingresa el valor a agregar al final: ");
                        lista.Append(Console.ReadLine());
                        Console.WriteLine("Elemento agregado al final.");
                        break;

                    case "2": // Agregar al inicio
                        Console.Write("Ingresa el valor a agregar al inicio: ");
                        lista.Prepend(Console.ReadLine());
                        Console.WriteLine("Elemento agregado al inicio.");
                        break;

                    case "3": // Insertar en un índice específico
                        Console.Write("Ingresa el índice donde insertar: ");
                        if (int.TryParse(Console.ReadLine(), out int indiceInsert))
                        {
                            Console.Write("Ingresa el valor a insertar: ");
                            bool resultadoInsert = lista.Insert(indiceInsert, Console.ReadLine());

                            Console.WriteLine(resultadoInsert
                                ? $"Se insertó en el índice {indiceInsert}."
                                : $"No se pudo insertar. Índice {indiceInsert} fuera de rango.");
                        }
                        else Console.WriteLine("Índice inválido.");
                        break;

                    case "4": // Eliminar por índice
                        Console.Write("Ingresa el índice a eliminar: ");
                        if (int.TryParse(Console.ReadLine(), out int indiceDelete))
                        {
                            Console.WriteLine(lista.Delete(indiceDelete)
                                ? $"Se eliminó el elemento en el índice {indiceDelete}."
                                : $"No se pudo eliminar. Índice {indiceDelete} fuera de rango.");
                        }
                        else Console.WriteLine("Índice inválido.");
                        break;

                    case "5": // Eliminar primer elemento
                        Node borradoPrimero = lista.DeleteFirst();
                        Console.WriteLine(borradoPrimero != null
                            ? $"Se eliminó el primer elemento: {borradoPrimero.data}"
                            : "La lista está vacía, no se pudo eliminar.");
                        break;

                    case "6": // Eliminar último elemento
                        Node borradoUltimo = lista.DeleteLast();
                        Console.WriteLine(borradoUltimo != null
                            ? $"Se eliminó el último elemento: {borradoUltimo.data}"
                            : "La lista está vacía, no se pudo eliminar.");
                        break;

                    case "7": // Imprimir lista
                        Console.WriteLine("Contenido de la lista:");
                        lista.PrintList();
                        break;

                    case "8": // Imprimir lista en orden inverso
                        Console.WriteLine("Contenido de la lista (en sentido inverso):");
                        lista.PrintListBackwards();
                        break;

                    case "9": // Obtener longitud de la lista
                        Console.WriteLine($"Longitud de la lista: {lista.GetLength()}");
                        break;

                    case "10": // Modificar un elemento por índice
                        Console.Write("Ingresa el índice que deseas modificar: ");
                        if (int.TryParse(Console.ReadLine(), out int indiceSet))
                        {
                            Console.Write("Ingresa el nuevo valor: ");
                            bool resultadoSet = lista.Set(indiceSet, Console.ReadLine());

                            Console.WriteLine(resultadoSet
                                ? $"Se actualizó el elemento en el índice {indiceSet}."
                                : $"No se pudo actualizar. Índice {indiceSet} fuera de rango.");
                        }
                        else Console.WriteLine("Índice inválido.");
                        break;

                    case "0": // Salir del programa
                        Console.WriteLine("Saliendo del programa...");
                        return;

                    default:
                        Console.WriteLine("Opción no válida. Intenta de nuevo.");
                        break;
                }

                Console.WriteLine();
            }
        }

        // Muestra el menú de opciones en la consola
        static void MostrarMenu()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("              MENÚ PRINCIPAL            ");
            Console.WriteLine("=========================================");
            Console.WriteLine("1. Agregar al final");
            Console.WriteLine("2. Agregar al inicio");
            Console.WriteLine("3. Insertar en un índice");
            Console.WriteLine("4. Eliminar por índice");
            Console.WriteLine("5. Eliminar primer elemento");
            Console.WriteLine("6. Eliminar último elemento");
            Console.WriteLine("7. Imprimir lista");
            Console.WriteLine("8. Imprimir lista en orden inverso");
            Console.WriteLine("9. Ver longitud de la lista");
            Console.WriteLine("10. Actualizar elemento por índice");
            Console.WriteLine("0. Salir");
            Console.WriteLine("=========================================");
        }
    }
}

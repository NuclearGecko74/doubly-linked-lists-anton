using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListsAnton
{
    internal class Program
    {
        // El menú fue hecho todo por chat gpt, ngl, las clases no, las hice desde cero
        static void Main(string[] args)
        {
            Console.Write("¿Deseas que la lista sea circular? (s/n): ");
            string respuesta = Console.ReadLine().Trim().ToLower();
            bool esCircular = (respuesta == "s");

            DoublyLinkedList lista = new DoublyLinkedList(esCircular);

            while (true)
            {
                MostrarMenu();
                Console.Write("Selecciona una opción: ");
                string opcion = Console.ReadLine().Trim();

                switch (opcion)
                {
                    case "1": // Append
                        Console.Write("Ingresa el valor a agregar al final: ");
                        string valorAppend = Console.ReadLine();
                        lista.Append(valorAppend);
                        Console.WriteLine("Elemento agregado al final.");
                        break;

                    case "2": // Prepend
                        Console.Write("Ingresa el valor a agregar al inicio: ");
                        string valorPrepend = Console.ReadLine();
                        lista.Prepend(valorPrepend);
                        Console.WriteLine("Elemento agregado al inicio.");
                        break;

                    case "3": // Insert
                        Console.Write("Ingresa el índice donde insertar: ");
                        if (int.TryParse(Console.ReadLine(), out int indiceInsert))
                        {
                            Console.Write("Ingresa el valor a insertar: ");
                            string valorInsert = Console.ReadLine();
                            bool resultadoInsert = lista.Insert(indiceInsert, valorInsert);

                            if (resultadoInsert)
                                Console.WriteLine($"Se insertó '{valorInsert}' en el índice {indiceInsert}.");
                            else
                                Console.WriteLine($"No se pudo insertar. Índice {indiceInsert} fuera de rango.");
                        }
                        else
                        {
                            Console.WriteLine("Índice inválido.");
                        }
                        break;

                    case "4": // Delete (por índice)
                        Console.Write("Ingresa el índice a eliminar: ");
                        if (int.TryParse(Console.ReadLine(), out int indiceDelete))
                        {
                            bool resultadoDelete = lista.Delete(indiceDelete);
                            if (resultadoDelete)
                                Console.WriteLine($"Se eliminó el elemento en el índice {indiceDelete}.");
                            else
                                Console.WriteLine($"No se pudo eliminar. Índice {indiceDelete} fuera de rango.");
                        }
                        else
                        {
                            Console.WriteLine("Índice inválido.");
                        }
                        break;

                    case "5": // DeleteFirst
                        Node borradoPrimero = lista.DeleteFirst();
                        if (borradoPrimero != null)
                            Console.WriteLine($"Se eliminó el primer elemento: {borradoPrimero.data}");
                        else
                            Console.WriteLine("La lista está vacía, no se pudo eliminar.");
                        break;

                    case "6": // DeleteLast
                        Node borradoUltimo = lista.DeleteLast();
                        if (borradoUltimo != null)
                            Console.WriteLine($"Se eliminó el último elemento: {borradoUltimo.data}");
                        else
                            Console.WriteLine("La lista está vacía, no se pudo eliminar.");
                        break;

                    case "7": // PrintList
                        Console.WriteLine("Contenido de la lista:");
                        lista.PrintList();
                        break;

                    case "8": // PrintListBackwards
                        Console.WriteLine("Contenido de la lista (en sentido inverso):");
                        lista.PrintListBackwards();
                        break;

                    case "9": // GetLength
                        Console.WriteLine($"Longitud de la lista: {lista.GetLength()}");
                        break;

                    case "10": // Set
                        Console.Write("Ingresa el índice que deseas modificar: ");
                        if (int.TryParse(Console.ReadLine(), out int indiceSet))
                        {
                            Console.Write("Ingresa el nuevo valor: ");
                            string nuevoValor = Console.ReadLine();
                            bool resultadoSet = lista.Set(indiceSet, nuevoValor);
                            if (resultadoSet)
                                Console.WriteLine($"Se actualizó el elemento en el índice {indiceSet} a '{nuevoValor}'.");
                            else
                                Console.WriteLine($"No se pudo actualizar. Índice {indiceSet} fuera de rango.");
                        }
                        else
                        {
                            Console.WriteLine("Índice inválido.");
                        }
                        break;

                    case "0": // Salir
                        Console.WriteLine("Saliendo del programa...");
                        return;

                    default:
                        Console.WriteLine("Opción no válida. Intenta de nuevo.");
                        break;
                }

                Console.WriteLine(); 
            }
        }
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

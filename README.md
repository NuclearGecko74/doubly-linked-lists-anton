# List Doblemente Enlazada en C#

Este proyecto implementa una **Lista Doblemente Enlazada** en C#, con la posibilidad de operar en modo **circular** o **no circular**. Incluye operaciones para:

- Insertar al inicio (`Prepend`)
- Insertar al final (`Append`)
- Insertar en un índice específico (`Insert`)
- Eliminar por índice (`Delete`)
- Eliminar el primer nodo (`DeleteFirst`)
- Eliminar el último nodo (`DeleteLast`)
- Obtener y modificar nodos por índice (`Get`, `Set`)
- Imprimir la lista en orden normal e inverso
- Conocer la longitud de la lista en todo momento

Además, se incluye un **programa de consola** que proporciona un **menú interactivo** para probar todas las funcionalidades.

## Características principales

- **Modo circular**: Si se inicializa con `true`, la lista se comporta como **doblemente circular** (enlaza el último con el primero, y viceversa).
- **Modo no circular**: Si se inicializa con `false`, funciona como una lista doblemente enlazada **normal**.
- **Simplicidad de uso**: El menú permite **insertar, borrar, visualizar y modificar** los elementos sin necesidad de conocer detalles de la implementación interna.

## Estructura del proyecto

- **`Node.cs`**  
  Define la clase `Node`, que representa un **nodo** en la lista (almacena el `data`, referencias `next` y `prev`).

- **`DoublyLinkedList.cs`**  
  Contiene la **implementación** de la lista doblemente enlazada (o circular). Entre sus métodos principales están:
  - `Append(object data)`
  - `Prepend(object data)`
  - `Insert(int index, object data)`
  - `Delete(int index)`
  - `DeleteFirst()`
  - `DeleteLast()`
  - `Get(int index)`
  - `Set(int index, object data)`
  - `PrintList()` y `PrintListBackwards()`
  - `GetLength()`
  - `IsEmpty()`

- **`Program.cs`**  
  El **programa de consola** que muestra el **menú** y ejecuta las operaciones sobre la lista en base a la entrada del usuario.

## Cómo Ejecutar el Proyecto

Descarga el último `DoublyLinkedListMenuInteractivo.exe` desde la página de [Releases](https://github.com/NuclearGecko74/doubly-linked-lists-anton/releases/tag/Release) y ejecútalo.

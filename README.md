# Trabajo Practico N°8
## Ejercicio 2:
### Objetos del tipo LinkedList y  List, ¿Cuales son las diferencias que  tienen?
#### LinkedList:
Una lista enlazada es una colección lineal o una secuencia de nodos. El acceso a la lista se realiza desde el primero nodo (raíz o head) y se recorre accediendo al miembro que apunta al siguiente nodo y así hasta el final (el miembro del último nodo que apunta al siguiente se define como null). 

Así creamos una lista enlazada de cadenas (string):
```csharp
LinkedList<string> sentence = new LinkedList<string>(words);
```
*words corresponde a un array de string.

#### List:
Las listas son una colección de datos del mismo tipo, como los arrays, a diferencia de que en una lista podemos añadir y quitar datos fácilmente y cuando queramos.
Así creamos una lista de cadenas (string):
```csharp
List<string> listOfStrings = new List<string>();
```

    
### Objeto Diccionario
Los diccionarios en C# son secuencias de pares de llaves y valor, de manera que a cada llave se le asigna un valor.
La importancia de estructuras como esta es que nos permiten hacer búsquedas bastante rápidas, a estructuras complejas le podemos asignar valores bastante sencillos. Por ejemplo: Imagina que manejas una colección de un tipo complejo, como Personas, luego, si quieres encontrar a una persona por su ID (un int), tendrías que iterar la colección de Personas hasta encontrarla, lo cual puede ser un poco lento, pero si tienes un diccionario, donde la llave viene siendo el ID de la persona, solo tendrías que buscar entre las llaves para encontrar a la persona deseada.


### Beneficios de usar una biblioteca, porque pondria una clase en una biblioteca y cuando agregaria directamente la clase en su proyecto
Una biblioteca es un conjunto de procedimientos y funciones (subprogramas) agrupadas en un archivo. 
Un gran beneficio de las bibliotecas es el poder reutilizarlarla en diferentes proyectos. Por ejemplo se puede crear una biblioteca con todas las funciones matematicas y pasarla facilmente entre diferentes proyectos para utilizar sus funciones.

Si la clase fuese algo mas "generico" lo agregaria en una biblioteca, siguiendo con el ejemplo de funciones matematicas, si la biblioteca tiene funciones para hacer graficos, se podria incluir en ella una clase "punto" con propiedades X e Y las cuales definan sus coordenadas.

En cambio si necesito algo muy especifico para el proyecto o problema a resolver, estaria bien crear la clase dentro de mi proyecto.

### Como se agrega la referencia a una biblioteca de clase en su proyecto 
Luego de crear y compilar nuestra biblioteca de clases.
Para agregar la referencia a la biblioteca usamos la siguiente linea:
```csharp
using Funciones;
```

// LINQ = es in lenguaje integrado de .NET con el que podemos
// realizar consultas con lenguaje C#, para consultar bases de datos
// o a una API y obtener datos

// Languaje Integrate Query

int[] numbers = new int[10] { 1,2,3,4,5,6,7,8,9,0 };

var pares = from num in numbers
            where (num % 2) == 0
            select num;

 

// OBJETOS DE TIPO ANONOMIS
var coche = new { Marca = "Ford", Año = 2001 }; // podemos definir un objeto libre de esta forma


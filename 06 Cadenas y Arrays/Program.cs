
string str1; // no inicializado
string str2 = null; // su valor es null
string str3 = System.String.Empty; // su valor es empty
string str4 = ""; // inicializado como string vacio
string str5 = " "; // inicializado como un espacio en blanco

char[] letters = { '#', '%', '$' }; // arreglo de caracteres

//   \n = salto de linea,  \t = tabulador,  \r = salto de fila

string texto = @" con arroba (@)
    podemos escribir un testo dentro de las comillas
    y no hay problema ";


// INTERPOLACION = datos con una pequeña estructura
var pesona = (nombre:"Lukas", edad:26, lengiajes:"varios");


// SUBCADENAS - Substring, Replace, IndexOf
var cadena = "esto es una cadena";
var miCadena = cadena.Substring(0, 10); // con la funcion Subtring nos devuelve un string 
//que toma los caracteres de otro string en vace a los indices que le indiquemos

var miReemplaxo = cadena.Replace("cadena", "Reemplazo"); // la funcion Replaze reemplaza una palabra de un string que indiquemos
// por otra palabra que elijamos

var miTrim= cadena.Trim(); // Trim quita todos los expacios extras al inicio y final de un string

var miIndice = cadena.IndexOf('c'); // IndexOf nos retorna el indice de lo que le indiquemos por parametros


// ARRAYS
int[] array = new int[3]; // indicamos que crearemos un array de enteros que contenga 3 elementos
array[0] = 0;
array[1] = 1;
array[2] = 2;

int[] numbers = {4, 3, 8, 9, 6 }; // definimos automaticament el array numerico
Array.Sort(numbers); // metodo para ordenar de menor a mayor


// array de 2D dimenciones
int[,] array2D = new int[2, 2];
array2D[0, 0] = 1;
array2D[0, 1] = 2;
array2D[1, 0] = 3;
array2D[1, 1] = 4;




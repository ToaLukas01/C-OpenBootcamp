
int number = 27;
string name = "Lukas";
float PI = 3.14f; // se pone una f para que quede claro que es del tipo float
double Dou = 2.666d; // numero de doble precicion
char letra = 'L'; // se pone entre comillas simple sy almacena solo UN caracter

Console.Write("Mi nombre " + name);
Console.WriteLine("Mi edad " + number); // "Write" no hace un salto de linea


Console.WriteLine("Actividad :");

Console.WriteLine("Introduce tu nombre: ");
string? nombre = Console.ReadLine(); // "ReadLine" nos permite ingresar datos desde consola a manera de strings
Console.WriteLine("Introduce tu edad: "); 
int edad = Convert.ToInt32(Console.ReadLine()); // "ReadLine no nos permite ingresar datos que no sean strings por lo que nececitamos convertir el tipo de dato ingresado pro consola 
// para realizar la convercion del dato que viene por consola, englobamos el ReadLine en el Convert.ToInt36
Console.Write("Tu eres: " + nombre + ", y tu edad es: " + edad);

// CONVERCIONES IMPLICITAS:
// char -> int -> long -> float -> double

// CONVERCIONES EXPLICITAS (MANUALES)
// double -> float -> long -> int -> char

string ageString = "27";
int ageToInt = Convert.ToInt32(ageString); // comvierte un string a un numero

int? birth = 1996; // el signo de pregunta indica que la varable puede ser nula
string birthToString = birth.ToString(); // combierte un numero a string


 

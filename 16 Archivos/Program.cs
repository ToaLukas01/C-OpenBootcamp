

// Archivos

// lectura y escritura
// logs
// archivos JSON
// textos
// etc

// Crear archivos TXT y realizar operaciones

using System.IO; // Input, Output
using System.Net; // para peticiones HTTP

string texto;

try
{
    // creamos un objeto que guarde nuestra informacion del archivo de texto
    StreamReader text = new StreamReader("miArchivo.txt"); // indicamos el streing de path de donde estara le archvo/ nombre del archivo
    var linea = text.ReadLine();
    while(linea != null) // leemos el archivo
    {
        Console.WriteLine(linea);
        linea = text.ReadLine();
    }
    text.Close();
}
catch (Exeption ex)
{
    Console.WriteLine($"Ha ocurrido un error {ex}");
}


try
{
    // escrivimos un archivo TXT
    StreamWriter sw = new StreamWriter("writer.txt", true); // al añadir true indicamos que agregaremos (append) contneido al archivo
    sw.WriteLine("Añadop -> Estoy escribiendo el archivo");
    sw.WriteLine("Añado -> Otra Linea");
    sw.Close();
}
catch (Exeption ex)
{
    Console.WriteLine($"Ha ocurrido un error {ex}");
}


/* Opciobes con archivos:
- Crear archivos
- Leer -> no modifica el contenido // modo lectura
- Escribir -> SI modifica y borra lo anterior // modo escritura
- Append -> escribe añadiendo contenido al final, NO borra lo anterior// modo append
*/



// Conseguir un JSON de una API y usar su contenido

// Requerimos importar "using System.Net" para realizar peticiones http

// Creamos una request y un repsonse para obtener un JSON
// request = peticion al servidor del API
HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"http://localhost:4200.com");

// response = guardamos los datos que obtenemos de la peticion
HttpWebResponse response = (HttpWebResponse)request.GetRespon();

// Creamos un stream
Stream stream = response.GetResponStream();
StreamReader reader = new StreamReader(stream);

var json = reader.ReadToEnd();
Console.WriteLine(json);


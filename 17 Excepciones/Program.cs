
// EXCEPCIONES

// gestion de situaciones inesperadas o no deseadas
// nos permite seguir manejando el programa aal capturar las excepciones, 
// de no controlarlas le programa se detiene abrubtamente pro el error
// try, catch, finally

/* Tipos
- Exceptions -> clase base de la excepcion
- IndexOutOfRangeException -> se intento pedir un elemento que no existe
- NullReferenceException -> se pidio/intenta hacer algo con un objeto null
- ArgumentExceptions -> clase base para excepciones relacionadas cona rgumentos
- ArgumentNUllException -> string str = null, str.Substring(0,2)
- ArgumentOutOfRangeException

*/


try
{
    Console.WriteLine($"1 entre 0: {Divicion(1,0)}");
}
catch (Exeption ex)
{
    // continuamos con el programa y capturamos la excepcion
    Console.WriteLine($"ha ocurrido el siguiente error {ex.Message}");
}
finally
{
    Console.WriteLine("deberias dovidir por otro numero");
}


static double Divicion(double a, double b)
{
    if(b == 0)
    {
        throw new DivideByZeroExeption();
    }
    return a/b;
}

// Crear nuestra propia excepcion
public class UsuarioNoEncontrado: Exception
{
    public UsuarioNoEncontrado()
    {
        // Creamos el mensaje dle tipo de error
    }
    public UsuarioNoEncontrado(string message): base(message)
    {
        // Creamos el mensaje dle tipo de error
    }
    public UsuarioNoEncontrado(string message, Exception ex): base(message)
    {
        // Creamos el mensaje dle tipo de error
    }
}



// TUPLAS = proporsionan una sisntaccis para a grupar datos

// primero ponemos los tipos de datos que encajaran en la tupla
(string, bool, int) miTupla = ("Lukas", true, 27);
miTupla.Item1 = "Lukas Gabriel"; // podemos acceder a cada iten a travez de la propiedad "Item"

var tuplaInt = (1, 2, 3, 4, 5, 6); // otra forma de definir una tupla de un solo tipo

// usos de interfaces
public class Persona : IPersona
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }
    public bool Programa { get; set; }

    public void PreguntarNombre()
    {
        Console.WriteLine("Cual es tu nombre ?");
        var nombre = Console.ReadLine();
        if(Nombre == null)
        {
            Console.WriteLine($"No tiene nombre");
        }
        else
        {
            Nombre = nombre;
        }
    }
}

public interface IPersona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public bool Programa { get; set; }
}

// ENUMS = enumeracion / lista de constantes
enum Estaciones 
{
    Verano,
    Primavera,
    Otoño,
    Invierno
}

enum Codigos : ushort
{
    Error = 400,
    Ok = 200,
    Fatal = 500,
    Prosesando = 300
}



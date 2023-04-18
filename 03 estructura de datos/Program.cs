
Coordenadas coords = new Coordenadas(27, 4); // creamos la instancia del objeto

var ubicacion = coords with { X = 19, y= 96} ; // con la palabra "with" nos permite reutilizar un objeto pero con la posibilidad de cambiarle los valores

// IMPORTARTE, LAS DEFINICIONES DE ESTRUCTURAS SIEMBRE VAN DEBAJO EN LOS ARCHIVOS DE CODIGO
public struct Coordenadas // declaramos la estructura
{
    public Coordenadas(double x, double y) // declaramso su constructor
    {
        x = x;
        y = y;
    }

    public double X { get; set;} // estos metodos nos permitne asignarle valores a la variable
    public double Y { get; set; } // "get" nos permite obtener el valor, y "set" nos permite modificarlo

    public override string ToString() => $"({X}, {Y})"; // los pasamos a strings para que se puedan escribir

}



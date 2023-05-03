using System.Collections.Generic;

// COLECCIONES

// listas(almacenan por indice) 
// IEnumerables(vienen de querys de LINQ) 
// diccionarios(almacenan por key, valor)

// colleccion de strings
var autos = new List<string>();
autos.Add("MaQueen");
autos.Add("hervy");
autos.Add("Corredor");

var aviones = new List<string> { "Aereo", "Avioneta", "Privado "};

List<Elemento> elementos = CrearListaElementos();

var query = from elem in elementos
            where elem.length == 4 
            select elem;

static List<Elemento> CrearListaElementos()
{
    return new List<Elemento>
    {
        { name = "Fuego" },
        { name = "Agua" },
        { name = "Aire" },
        { name = "Tierra" }
    };
};

public class Elemento
{
    public string name { get; set; } = string.Empty;
}


// public class Colores: IEnumerable<>()
// {
//     Colores[] _colors = 
//     {
//         new Colores(){ name = "rojo"},
//         new Colores(){ name = "azul"},
//         new Colores(){ name = "amarillo"};
//     };
// }

public class Colores
{
    public string name {get; set;}
}
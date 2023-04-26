
Puerta door = new Puerta(100, 100, "rojo", "Madera");


// RECORDAR QUE LAS CLASES Y ESTRUCTURAS DEBEN DEFINIRSE AL FINAL DEL CODIGO
public class Puerta
{
    int ancho;
    int altura;
    string color;
    string material;
    bool abierta;

    public Puerta(int ancho, int altura, string color, string material, bool abierta = false) 
    // constructor de la clase que puede recivir parametros para setear el objeto y
    // para crear un objeto de la clase  / podems definir valores por defecto en el constructor tambien
    {
        this.ancho = ancho;
        this.altura = altura;
        this.color = color;
        this.material = material;
        this.abierta = abierta;
    }
    public Puerta() // tambien podemos crear un constructor que setee valores por defecto
    // a cada objeto de la clase, para cuando querramos crear un objeto de la clase
    // y no le pasemos parametros, tome estos valores por defecto
    {
        ancho = 150;
        altura = 120;
        color = "Negro";
        material = "Plastico";
        abierta = false;
    }

    ~Puerta() // Declaramos aqui un metodo DESTRUCTOR (importante el simbolo "~" )
    {
        // codigo que se ejecuta cuando se destruye un objeto de la clase
        Console.WriteLine("Se ha destruido una puerta");
    }
}


// EJEMPLO DE CLASE CON ATRIBUTOS PRIVADOS
public class Usuario
{
    private string _name; //indicamos que cuando se cree un objeto de esta clase este valor sera inaccesible

    public string Username // con este metodo podemos llegar a obtener el valor del atributo privado y poder asignarle valores
    {
        get
        {
            return _name;
        }
        private set
        {
            _name = value;
        }
    }
}


// HERENCIA Y POLIMORFISMO
Vehiculo vehiculo = new Vehiculo();
vehiculo.Arrancar();
Auto auto = new Auto();
auto.Arrancar();

public class Vehiculo // clase padre
{
    public float combustible { get; set;}
    public int patente { get; set; }
    public void Arrancar()
    {
        Console.WriteLine("Vehiculo en movimiento");
    }
}

public class Auto : Vehiculo // La notacion con ":" nos indica que la clase se hereda de otra
{
    public int ruedas { get; set; }
    public void Detener()
    {
        Console.WriteLine("Vehiculo Se Detubo");
    }
    public void Arrancar() // Polimorfismo con esta funcion ya que las clases tiene la misma funcion 
    //pero devuelven mensajes diferentes
    {
        Console.WriteLine($"Vehiculo esta en marcha a las {DateTime.Now.ToString()}");
    }
}






// INTERFACES
// son clases que definene atributos y metodos sin implementarse
// lo implementan las clases que heredan la interfaz
// son plantillas

public interface IVehiculo
{
    public string Marca { get; set; }
    public void Arrancar();
}

class Vehiculo : IVehiculo
{
    public string Marca { get; set; } = string.Empty;
    void IVehiculo.Arrancar()
    {
        Console.Write("arrancar");
    }
}


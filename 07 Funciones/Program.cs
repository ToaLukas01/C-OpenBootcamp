
// al definir una funcion tenemos que indicar el tipo de dato que nos devuelve
// en este caso un int
 int CalcularCuadrado(int n)
{
    return n * n;
}

Console.WriteLine(CalcularCuadrado(2));


// la delcaracion "void" nos indica que la funcion NO devuelve nada
void EscribirCondicion(int a) 
{
    if( a < 5)
    {
        Console.WriteLine("Desaprobado");
        return;
    }
    else 
    {
        Console.WriteLine("Aprobado");
        return;
    }
}

 // FUNCIONES ANONIMAS / ARROW FUNCTION
 // (input parameter) => expression


 // METODOS

 var moto = new Moto();
 moto.Arrancar();
 var acelerar = Moto.Acelerar(); // ejemplo de metodo estatico de clase
dynamic gasolina = moto.EcharGasolina(10d); // "dynamic" es la palabra reservada para definir variables cuyo tipo de dato puede variar / se ajusta
class Moto // las clases se definen al final del codigo
{
    public void Arrancar() // definimos el metodo como publico
    {
        Console.WriteLine("Arrancar");
    }
    public static string Acelerar() // al utilizar "static" estamos indicando que el metodo sera propio de la clase y que solo lo podr ausar la clase misma
    {
        return "Acelerando";
    }

    public int EcharGasolina(int n) 
    // podemos definir un metodo varias veces que reciva distintos tipos de datos, 
    // siempre  cuando esten dentro del mismo scoupe para que no haya colicion de nombres
    // asi podremos llamarla y se implementara con distintos tipos de datos
    {
        int nivelGasolina = 20 * n;
        return nivelGasolina;
    }
    public float EcharGasolina(float n)
    {
        float nivelGasolina = 20 * n;
        return nivelGasolina;
    }
    public double EcharGasolina(double n)
    {
        double nivelGasolina = 20 * n;
        return nivelGasolina;
    }
}







// METODOS RECURSIVOS / FUNCIONES RECURSIVAS

int Factorial(int n)
{
    if(n == 1)
    {
        return 1;
    }
    return n * Factorial(n-1);
}


var fact = Factorial(4);


// SEGUIMOS CON METODOS Y CLASES
public class Puerta
{
    int ancho;
    int altura;
    string color;
    string material;
    bool abierta;

    public void Abrir()
    {
        abierta = true;
    }
    public void Cerrar()
    {
        abierta = false;
    }
}
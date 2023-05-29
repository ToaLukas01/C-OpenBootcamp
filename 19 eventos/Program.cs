

// EVENTOS := editor -> suscriptor

/* editor o publisher
- determina cuando se lanza un evento
- definicion del evento
- delegado
*/

/* suscriptor
- objeto que acepta el evetno y provee un event handler
- metodo en respuesta al evento
*/

/* evento
- delegado encapsulado en la clase del editor
- delegado -> llama a un metodo cuando se cumple una condicion
*/


SuscriptorCalculador calculadora = new SuscriptorCalculador(1,2);
calculadora.ResultadoSuma();

public class Editor
{
    public delegate void EjemploEvento();
    public event EjemploEvento evento;
}

public class EditorCalculador
{
    public delegate void EjemploDelegado();
    public event EjemploDelegado evento;

    public void Sumar(int a, int b)
    {
        if(evento != null)
        {
            evento();
            Console.WriteLine($" la suma es {a+b}");
        }
        else
        {
            onsole.WriteLine($"No tienes una subscripcion al evento");
        }
    }
}

public class SuscriptorCalculador
{
    EditorCalculador editor;
    private readonly int A;
    private readonly int B;

    public void EjemploEventHandler()
    {
        Console.WriteLine("Se imprime le resultado de la operacion");
    }
    public SuscriptorCalculador(int a, int b) // constructor
    {
        editor = new EditorCalculador();
        A = A;
        B = B;
        editor.evento += EjemploEventHandler; // aqui nos suscribimos
    }
    public void ResultadoSuma()
    {
        editor.Sumar(A, B);
    }
}
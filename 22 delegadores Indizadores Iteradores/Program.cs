
// Delegadores, Indizadores e Iteradores

/* Delegador
- referencia a un metodo := variable --> metodo

<modificador de acceso> delegate <tipo de retorno> <nombre>(<parametros>[]);

ejem : public delegate void ImprimirDocDelegado(string path);

Delegadors disponible spro defectos
- Action<T> -> siempre devuelve void, de 0 a 16 parametros de tipo Generic

- anonimos -> definir con sintaxis landa

- Func<revive, devuelve> -> Func<int, string> -> recibe int y retorna string

- Predicate<T> -> siemrpe devuelve un booleano

*/

ImprimirDocDelegadoClase obj = new ImprimirDocDelegadoClase();
obj.EjemploDelegado();

public delegate void ImprimirDocDelegado(string value);

public class ImprimirDocDelegadoClase
{
     private void Imprimir(string value)
     {
        Console.WriteLine($"valor resivido: {value}");
     }
     public void EjemploDelegado(string str) // Accion
     {
        // Declaracion
        ImprimirDocDelegado imprimirDelegado = new ImprimirDocDelegado(Imprimir);
        // invocacion / Call
        imprimirDelegado(str);
     }

     // Definicion con Landa
     Actiion<string> imprimirConAccionLanda = x => Console.WriteLine($"se recivio: {x}");

    //Func<revive, devuelve>
    Func<int, string> resultao = v => $"El resultado es: {v}";

    // Predicado
    Predicate<int> esMayorDeEdad = e => e >= 18;
    
}



// Indizadores o Indexadores



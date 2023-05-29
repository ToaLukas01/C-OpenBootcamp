

// ITERADORES

/* Iteradores -> colecciones, List, arrays
- aplicar una operacion/accion a cada elemento de una lista u coleccion
- enumerar una lsita personalizada
- LINQ -> quey o consultas
- canalizar los datos a otro proceso
*/

List<string> collection = {"Lukas", "Gabriel", "Acuña", "Ortiz"};
foreach (var item in collection)
{
    Console.WriteLine(item);
}

IEnumerable<int> NUmerosEnteros()
{
    // "yield" = se usa para indicar al complilador que estamos dentro d eun bloque de iteracion
    //           y nos permite acceder a los elementos d euna lsita (IEnumerable) 
    //           de forma progresiva a medida que los vamos nececitando
    yield return 1;
    yield return 2;
    yield return 3;
}
IEnumerable<int> NumEnteros()
{
    int index = 0;
    while(index < 3)
    {
        yield return index++;
    }

}
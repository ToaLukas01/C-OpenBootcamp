
// PROGRAMACION ASYNCRONA

// ASYNC / AWAIT
// TASK (Multitasking)

using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;


// TASK
var task1 = new Task(()=> {  // inicializamos una task con una exprecion landa

    Stopwatch cronometro = new Stopwatch(); // declaramos un cronometro
    cronometro.Start(); // inicializamos el cronometro
    // codigo, task, etd.
    int num = 0;
    for(int i=0; i <=100; i++)
    {
        num += i;
    }
    cronometro.Stop(); // detenemos el cronometro
    Console.WriteLine(cronometro.Elapsed); // vicualizamos el tiempo desde que se declaro el inicio del cronometro
    // hasta el momento en que se detuvo

});

var task2 = new Task(()=> {

    Stopwatch cronometro = new Stopwatch(); // declaramos un cronometro
    cronometro.Start(); // inicializamos el cronometro
    Thread.Sleep(2000); //dormimos le cronometro 2000 milisegundos (2 seg)
    cronometro.Stop(); // detenemos el cronometro
    Console.WriteLine(cronometro.Elapsed);

});


task1.Start(); // inicializamos la tarea 1
task2.Start(); // inicializamos la tarea 2

// esperamos que se completen las tareas 
await task1; 
await task2; 

var random = await RandomAsync();

static async Task<int> RandomAsync()
{
    Stopwatch cronometro = new Stopwatch().Start();
    var num = new Random().Next(1000);
    cronometro.Stop();
    return num;
};





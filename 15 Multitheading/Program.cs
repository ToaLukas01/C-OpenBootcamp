
// MULTITHREADING
// capacidad de tener varios flujos de datos y gestionarlos
// flujo de "hilos", manejar varias tareas a la vez

// Main Thread / Hilo Principal

using System;
using System.Threading;
using System.Diagnostics;


Thread hiloMain = Thread.CurrentThread; // declaramos el hilo principal (esto nos genera on objeto)
hiloMain.Name = "Hilo Principal";

ThreadStart refhilo = new ThreadStart(IniciarHilos);
Thread hiloSecundario = new Thread(refhilo); // cuando se crea un hilo debemos indicarle que debe hacer cuando se crea
hiloSecundario.Start();

static void IniciarHilos()
{
    Console.WriteLine("Se ha inicializado un nuevo hilo");
}


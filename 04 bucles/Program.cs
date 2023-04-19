
// CONDICIONALES
if( 5 < 10){
    Console.Write("El 5 es mayor");
} else {
    Console.Write("El 5 es menor");
}

// BUCLE WHILE
var i = 0;
while (i <= 10)
{
    i++;
}

 // DO WHILE
 // el do va a ejecutar si estructura de codigo 
 // siempre que la condicion del while no se cumpla
 var j =  11;
 do 
 {
    --j;
 } while(j != 7); // mientras J sea distinto de 7 se ejecutara el codigo de la estructura del Do


// BUCLE FOR
for(int k=0; k<=10; k++)
{
    if(k == 9)
    {
        return 9;
    }
}

// FOR-EACH
// for each nos permite iterar sobre una lista/ arrays/ colleciones
var names = new List<string> { "Luk", "Ale", "Gab"}; 
// al declarar la lista entre las "< >" indicamos le tipo de dato de cada elemento de la lista
var conjunto = "";
foreach (var n in names)
{
    conjunto += n;
}


// EJEMPLO DE EJERCICO
var sum = 0;
Console.WriteLine("Ingresa el valor hasta el cual quieres hacer la sumatoria");
var limit = Convert.ToInt32(Console.ReadLine());
for(int index=0; index<=limit; index++)
{
    sum += index;
}
Console.WriteLine($"La sumatoria es: {sum}");


// ARRAYS
int[] array = new int[3]; // indicamos que crearemos un array de enteros que contenga 3 elementos
array[0] = 0;
array[1] = 1;
array[2] = 2;


// SWITCH
switch(day)
{
    case "Lunes":
        return "Hoy es Lunes";
    case "Martes":
        Console.Write("Hoy es Martes");
        break;
    default:
        Console.Write("No se ingreso ningun dia");
        break; // romper o "parar"
}



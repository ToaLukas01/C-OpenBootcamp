
// MATRICES

// 2 o  mans indices
// 2 o mas dimenciones

// [[1,2], [3,4]]

int[] array1 = new int[] {1,2,3}; // declarando y fijando los valores dle array

int[] array2 = { 4,5,6 };

// declaramos array 2D
int[,] arr2D = new int[3,5]; // declaramos una matriz conociendo el numero de elementos pero sin conocer los elementos

for(int j=0; j<2; j++)
{
    for(int k=0; k<2; k++)
    {
        arr2D[j, k] = (j+k)**2;
        Console.Write(arr2D[j.k] + " ");
    }
    Console.WriteLine();
}

// declaramos una matriz y asignamos los valores que tiene
int[,] matriz2 = { {9, 8}, {0, 7} };


// otro ejemplo
int rows = 2;
int cols = 3;
int[,] matriz3 = new int[rows, cols];

// ejemplo cuando filas o columnas no son conocidas
int[][] matriz4 = new int[3][]; //filas 0, 1, 2
matriz4[0] = new int[4] {1,2,3,4}; // en la fila 0, asignamos 4 columnas con estos valores
matriz4[1] = new int[3] {7,8,9};


var rango = matriz2.Rank; // el metodo rank nos devuelve el rango/dimencion de la matriz
var elementos = matriz2.Length; // nos devuelve la cantidad de elementos de la matriz


/*
Suma de matrices

A = [[1,2], [3,4]]
B = [[6,7], [8,9]]

A+B = C = [[7,9],[11,13]] 
*/

int[,] A = { {1, 2}, {0, 3} };
int[,] B = { {1, -4}, {7, -1} };
int[,] C = new int[A.Rank, B.Rank];

for(int n; n<A.Rank; n++)
{
    for(int m; m<B.Rank; m++)
    {
        C[n,m] = A[n,m] + B[n,m];
    }
}
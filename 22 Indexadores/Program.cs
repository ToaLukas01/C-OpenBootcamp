

// Indizadores -> INDEXADORES

// recurso qu enos permite acceder a una estructura de datos de tipo matriz

// declaracion dle indexador



var temperaturas = new Temperaturas();
temperaturas[1] = 11.23f;
temperaturas[9] = -7.25F;


for(int i = 0; i < temperaturas.len; i++)
{
    Console.WriteLine($"Item: {temperaturas[i]}");
}

var semana = new DiaSemana();
semana["Lun"]; // consologea el indice de "Lun"

public class Temperaturas
{
    float[] temp = new float[10]
    {
        10f, 11f, -5f, 28.8f, -30f, 8f, 16f, 0f, -1f, 1f
    };
    public int len => temp.Length;

    // Indexador
    public float this[int index]
    {
        get => temp[index]; // leer el valor
        set => temp[index] = value; // cambiar el valor
    }
}

class DiaSemana
{
    string[] dias = { "Lun", "Mar", "Mie", "Jue", "Vie", "Sab", "Dom"};

    public int this[string dia] => FindDayIndex(dia);

    private int FindDayIndex(string dia)
    {
        for(int j=0; j < dias.Length; j++)
        {
            if(dias[j] == dia)
            {
                return j;
            }
        }
        throw new ArgumentOutOfRangeException(nameof(dia), $"el dia {dia} no esta en la lista");
    }
}
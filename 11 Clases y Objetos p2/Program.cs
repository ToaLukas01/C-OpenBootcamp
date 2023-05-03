
// TIPOS GENERICOS
Generic<string> str = new Generic<string>();
str.campo = "String de Campo";

public class Generic<Tipo>
{
    public Tipo campo { get; set; }
}





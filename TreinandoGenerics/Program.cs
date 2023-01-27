
public class TreinandoGenerics
{
    static void Main(string[] args)
    {
        var teste1 = new Pessoa()
        {
            Nome = "Celso",
            Idade = 26,
            Altura = 1.87
        };

        var teste2 = new Pessoa()
        {
            Nome = "Celso",
            Idade = 26,
            Altura = 1.87
        };

        var teste3 = teste1;

        Console.WriteLine(ComparandoTipos.Comparar(teste2, teste1));
        Console.WriteLine(ComparandoTipos.Comparar(teste2, teste3));
        Console.WriteLine(ComparandoTipos.Comparar(teste1, teste3));
        Console.WriteLine(ComparandoTipos.Comparar(teste2.Nome, teste1.Nome));
        Console.WriteLine(ComparandoTipos.Comparar(teste2.Idade, teste1.Idade));
        Console.WriteLine(ComparandoTipos.Comparar(teste2.Altura, teste3.Altura));
    }
}
public static class ComparandoTipos
{
    public static bool Comparar(string value1, string value2)
    {
        return value1 == value2;
    }

    public static bool Comparar(int value1, int value2)
    {
        return value1 == value2;
    }

    public static bool Comparar(double value1, double value2)
    {
        return value1 == value2;
    }

    public static bool Comparar<T>(T value1, T value2)
    {
        return value1.Equals(value2);
    }
}
public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public double Altura { get; set; }
}


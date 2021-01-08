using System;
class MinhaClasse
{
    public static void Main(string[] args)
    {
        var idadeEmDias = int.Parse(Console.ReadLine());
        int anos = 0;
        anos = idadeEmDias / (int)365;
        int dias = idadeEmDias % 365;
        int meses = 0;
        meses = dias / (int)30;
        dias = dias % 30;

        Console.WriteLine($"{anos} ano(s)\n{meses} mes(es)\n{dias} dia(s)");
    }
}
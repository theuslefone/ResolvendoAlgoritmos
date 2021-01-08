using System;


class Desafio
{
    static void Main()
    {
        string[] line = Console.ReadLine().Split(" ");
        int numeroVoltas = Int32.Parse(line[0]);
        int numeroPlacasPorVolta = Int32.Parse(line[1]);
        int numeroTotalDePlacas = numeroVoltas * numeroPlacasPorVolta;
        double[] porcentagens = { 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9 };
        string saida = "";
        for (int i = 0; i < 9; i++)
        {
            double numeroDePlacasAtual = Math.Ceiling(porcentagens[i] * numeroTotalDePlacas);
            saida = String.Concat(saida, numeroDePlacasAtual.ToString(), " ");
        }
        Console.WriteLine(saida);
    }
}
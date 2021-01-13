# ResolvendoAlgoritmos Copia aí luan

using System;

namespace Desafio2
{

    class Desafio
    {
        static void Main()
        {
            int saida = 0;
            string[] line = Console.ReadLine().Split(" ");
            int quantidaPizzaDisponiveis = Int32.Parse(line[0]);
            int quantidadeSaladaDisponiveis = Int32.Parse(line[1]);
            int quantidadeMassasDisponiveis = Int32.Parse(line[2]);

            string[] line2 = Console.ReadLine().Split(" ");
            int quantidaPizzaSolicitadas = Int32.Parse(line2[0]);
            int quantidadeSaladaSolicitadas = Int32.Parse(line2[1]);
            int quantidadeMassasSolicitadas = Int32.Parse(line2[2]);

            int pizzas = quantidaPizzaDisponiveis - quantidaPizzaSolicitadas;
            int salada = quantidadeSaladaDisponiveis - quantidadeSaladaSolicitadas;
            int massas = quantidadeMassasDisponiveis - quantidadeMassasSolicitadas;

            int totalPizzas = 0;
            int totalSaladas = 0;
            int totalMassas = 0;

            if (pizzas < 0)
            {
                totalPizzas = pizzas*-1;
            }

            if (salada < 0)
            {
                totalSaladas = salada*-1;
            }

            if (massas < 0)
            {
                totalMassas = massas*-1;
            }

            saida = totalPizzas + totalSaladas + totalMassas;
            Console.WriteLine(saida);
        }
            
    }
}

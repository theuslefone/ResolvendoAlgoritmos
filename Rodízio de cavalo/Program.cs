﻿using System;

class Desafio7
{

    public static void Main(string[] args)
    {

        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {

            string placa = Console.ReadLine();

            if (estaNoPadrao(placa))
            {
                Console.WriteLine(rodizio(placa));
            }

            else
            {
                Console.WriteLine("FALHA");
            }
        }
    }

    public static bool estaNoPadrao(string placa)
    {

        bool placaOk = false;

        if (placa.Length == 8)
        {
            placaOk = (placa[3] == '-') &&
                  (Char.IsDigit(placa[4])) &&
                  (Char.IsDigit(placa[5])) &&
                  (Char.IsDigit(placa[6])) &&
                  (Char.IsDigit(placa[7])) &&
                  (Char.IsLetter(placa[0])) &&
                  (Char.IsLetter(placa[1])) &&
                  (Char.IsLetter(placa[2])) &&
                  (Char.IsUpper(placa[0])) &&
                  (Char.IsUpper(placa[1])) &&
                  (Char.IsUpper(placa[2]));
        }
        return placaOk;
    }

    public static string rodizio(string placa)
    {

        string aux = "";

        char digitoFinal = placa[placa.Length - 1];

        switch (digitoFinal)
        {

            case '1': aux = "SEGUNDA"; break;
            case '2': aux = "SEGUNDA"; break;
            case '3': aux = "TERCA"; break;
            case '4': aux = "TERCA"; break;
            case '5': aux = "QUARTA"; break;
            case '6': aux = "QUARTA"; break;
            case '7': aux = "QUINTA"; break;
            case '8': aux = "QUINTA"; break;
            case '9': aux = "SEXTA"; break;
            case '0': aux = "SEXTA"; break;
            default: aux = "FALHA"; break;

        }
        return aux;
    }
}
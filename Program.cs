using System;
using System.Globalization;
     namespace ProjetoConversorTemperatura
         class Program
    {
            static void Main(string[] args)
        {
            // Saída de dados na tela : output

            Console.WriteLine("=====Conversor de Temperatura=====");
           
            Console.WriteLine("Digite a temperatura em Cº");

            // criando a variável celcius e entrada de dados
            // e fazendo a conversão de tipos "double.Parse(Console.ReadLine())"

            double celcius = double.Parse(Console.ReadLine());

            // criando a variável result e atribuindo à fórmula para converter
            // celsius para Fahrenheit

            double result = (celcius * 1.8) + 32;

            // Saída de dados  usando interpolação($) para variável "result" //
            
            // Totring("F2",CultureInfo.InvariantCulture) formatação para colocar quantidade de casas decimais e mudar para "." ao inves de ","
            Console.WriteLine($" Temperatura em Fahrenheit:{result.ToString("F0",CultureInfo.InvariantCulture)}Fº");

        }
    }
}


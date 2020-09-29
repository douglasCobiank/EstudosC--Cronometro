using System;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Start start = new Start();
            //Console.Clear();
            Console.WriteLine("S = Segundo => 10s");
            Console.WriteLine("M - Minuto => 1m");
            Console.WriteLine("0 = Sair");
            string valor = Console.ReadLine().ToLower();
            char type = char.Parse(valor.Substring(valor.Length - 1,1));
            int time = int.Parse(valor.Substring(0, valor.Length - 1));
            int multiplicador = 1;

            if(type == 'm')
                multiplicador = 60;

            if(time == 0)
                System.Environment.Exit(0);

            Console.Clear();
            Console.WriteLine("Quanto tempo deseja contar");
            start.iniciar(int.Parse(Console.ReadLine()) * multiplicador);

        }
    }
}

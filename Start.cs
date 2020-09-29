using System;
using System.Threading;

namespace Cronometro
{
    public class Start
    {
        public void iniciar(int time)
        {
            int currentTime = 0;

            while(currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

        }
    }
}
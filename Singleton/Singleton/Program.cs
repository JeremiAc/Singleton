using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Singleton.Instance.enviar);

            Singleton.Instance.enviar = "Bienvenid@ Usuario";

            Console.WriteLine(Singleton.Instance.enviar);

        }
    }
}

using System;

namespace SimulacaoLampada
{
    class Program
    {
        public static void Main(string[] args)
        {
            Lampada l = new Lampada();

            bool sair = false;
            do
            {
                Console.WriteLine("Estado da lâmpada: {0}", l.Queimada ? "queimada" : (l.Acesa ? "acesa" : "apagada"));
                Console.WriteLine("O que você quer fazer?");
                Console.WriteLine("1. Acender");
                Console.WriteLine("2. Apagar");
                Console.WriteLine("3. Trocar");
                Console.WriteLine("4. Sair");
                Console.Write("Sua opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        l.Acender();
                        break;
                    case "2":
                        l.Apagar();
                        break;
                    case "3":
                        l = new Lampada(); // troca a lâmpada colocando uma nova! ;-)
                        break;
                    case "4":
                        sair = true;
                        break;
                }
            } while (!sair);
        }
    }
}

using System;

namespace SimulacaoLampada
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Quantas lâmpadas? ");
            int quantidade = int.Parse(Console.ReadLine());

            // criação do vetor
            Lampada[] lampadas = new Lampada[quantidade];

            // criação das lâmpadas
            for (int i = 0; i < lampadas.Length; i++)
            {
                lampadas[i] = new Lampada();
            }

            bool sair = false;
            do
            {
                Console.WriteLine("Estado das lâmpadas:");
                for (int i = 0; i < lampadas.Length; i++)
                {
                    Console.WriteLine("Lâmpada {0}: {1}", i, lampadas[i].Queimada ? "queimada" : (lampadas[i].Acesa ? "acesa" : "apagada"));
                }

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
                        Console.Write("Qual lâmpada (0 a {0}): ", lampadas.Length - 1);
                        int escolhida = int.Parse(Console.ReadLine());
                        lampadas[escolhida].Acender();
                        break;
                    case "2":
                        Console.Write("Qual lâmpada (0 a {0}): ", lampadas.Length - 1);
                        escolhida = int.Parse(Console.ReadLine());
                        lampadas[escolhida].Apagar();
                        break;
                    case "3":
                        Console.Write("Qual lâmpada (0 a {0}): ", lampadas.Length - 1);
                        escolhida = int.Parse(Console.ReadLine());
                        lampadas[escolhida] = new Lampada(); // troca a lâmpada colocando uma nova! ;-)
                        break;
                    case "4":
                        sair = true;
                        break;
                }
            } while (!sair);
        }
    }
}

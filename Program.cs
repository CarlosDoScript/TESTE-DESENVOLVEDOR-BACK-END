using System;

namespace ATIVIDADE_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Inicia();
        }

        public static void Inicia()
        {
            int atividadeEscolha = 0;
            bool entradaValida = false;

            Console.WriteLine("ESCOLHA UMA ATIVIDADE PARA EXECUTAR: ");

            while (!entradaValida)
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("1 - ATIVIDADE(CONJECTURA DE COLLATZ) 1.1");
                Console.WriteLine("2 - ATIVIDADE(SOMENTE NUMEROS IMPARES) 1.2");
                Console.WriteLine("3 - ATIVIDADE 1.3");
                Console.WriteLine("----------------------------------------------");

                string input = Console.ReadLine();

                if (int.TryParse(input, out atividadeEscolha))
                {
                    if (atividadeEscolha >= 1 && atividadeEscolha <= 3)
                    {
                        entradaValida = true;

                        switch (atividadeEscolha)
                        {
                            case 1:

                                Implementation.Atividade.Atividade_1();

                                Console.WriteLine("----------------------------------------------");

                                Inicia();

                                break;

                            case 2:

                                break;

                            case 3:

                                break;

                            default:
                                Console.WriteLine("Opção inválida, Digite um número entre 1 e 3.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Número inválido. Digite um número entre 1 e 3: ");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Digite um número entre 1 e 3: ");
                }
            }

        }
    }
}

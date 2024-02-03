using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE_1.Implementation
{
    public class Atividade
    {
        //ATIVIDADE 1.1
        private static object lockObj = new object();
        public static void Atividade_1()
        {
            int maiorSequencia = 0, maiorNumeroInicial = 0;
            Dictionary<int, int> sequencias = new Dictionary<int, int>();

            for (int numeroInicial = 1; numeroInicial <= 1000001; numeroInicial++)
            {
                int sequenciaAtual = CalcularSequenciaCollatz(numeroInicial, sequencias);
                lock (lockObj)
                {
                    if (sequenciaAtual > maiorSequencia)
                    {
                        maiorSequencia = sequenciaAtual;
                        maiorNumeroInicial = numeroInicial;
                    }
                }
            }

            Console.WriteLine($"maior numero inicial: {maiorNumeroInicial}");
            Console.WriteLine($"tamanho da sequencia: {maiorSequencia}");
        }

        //função que calcula o tamanho da sequencia de collatz para um numero inicial
        private static int CalcularSequenciaCollatz(int numeroInicial, Dictionary<int, int> sequencias, int profundidade = 0, HashSet<int> visitados = null)
        {
            if (visitados == null)
                visitados = new HashSet<int>();

            if (visitados.Contains(numeroInicial))
                return 1;

            visitados.Add(numeroInicial);

            if (numeroInicial == 1 || profundidade > 10000) 
                return 1;

            if (sequencias.ContainsKey(numeroInicial))
                return sequencias[numeroInicial];

            int proximoNumero = numeroInicial % 2 == 0 ? numeroInicial >> 1 : (numeroInicial << 1) + numeroInicial + 1;
            int sequenciaAtual = 1 + CalcularSequenciaCollatz(proximoNumero, sequencias, profundidade + 1, visitados);
            sequencias[numeroInicial] = sequenciaAtual;

            return sequenciaAtual;
        }

        //ATIVIDADE 1.2
        public static void Atividade_2()
        {
            int[] numeros = { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };

            Console.WriteLine($"array: {{ {string.Join(", ", numeros)} }}");

            Console.WriteLine("---------------------------------------------------");

            bool todosImpares = ContemSomenteImpares(numeros);

            if (todosImpares)
            {
                Console.WriteLine("o array contem somente numeros impares");
            }
            else
            {
                Console.WriteLine("o array contem numeros pares e impares");
            }

            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("Números ímpares: ");

            var numerosImpares = ObterNumerosImpares(numeros);

            foreach (var numero in numerosImpares)
            {
                Console.WriteLine(numero);
            }
        }

        private static bool ContemSomenteImpares(int[] numeros)
        {
            return numeros.All(numero => numero % 2 != 0);
        }

        private static IEnumerable<int> ObterNumerosImpares(int[] numeros)
        {
            return numeros.Where(numero => numero % 2 != 0);
        }

        //ATIVIDADE 1.3
        public static void Atividade_3()
        {
            int[] primeiroArray = { 1, 3, 7, 29, 42, 98, 234, 93 };
            int[] segundoArray = { 4, 6, 93, 7, 55, 32, 3 };
            
            Console.WriteLine($"primeiro array: {{ {string.Join(", ", primeiroArray)} }}");

            Console.WriteLine($"segundo array: {{ {string.Join(", ", segundoArray)} }}");

            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("numeros do primeiro array que nao estao contidos no segundo array");

            var elementosDistintos = primeiroArray.Except(segundoArray);

            foreach (var elementoDistinto in elementosDistintos)
            {
                Console.WriteLine(elementoDistinto);
            }
        }

    }
}

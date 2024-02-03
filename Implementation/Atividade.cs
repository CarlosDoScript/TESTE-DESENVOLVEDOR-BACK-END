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

            Console.WriteLine($"Maior número inicial: {maiorNumeroInicial}");
            Console.WriteLine($"Tamanho da sequência: {maiorSequencia}");
        }
        
        //função que calcula o tamanho da sequencia de collatz para um numero inicial
        static int CalcularSequenciaCollatz(int numeroInicial, Dictionary<int, int> sequencias, int profundidade = 0, HashSet<int> visitados = null)
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
    }
}

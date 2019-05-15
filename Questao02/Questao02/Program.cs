using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao02 {
    class Program {
        static void Main(string[] args) {
            /*
             * 2) Escreva um app console em C# com os seguintes métodos:
                1.	Recursivo que imprima a média dos elementos de uma lista de inteiros e o número de elementos maiores do que a média.
                2.	Recursivo que retorne uma lista de forma invertida.

                Obs: Considere a lista previamente definida no próprio código.
             */
            Console.WriteLine("-------- MENU --------");
            Console.WriteLine("1 - Método 1");
            Console.WriteLine("2 - Método 2");
            Console.WriteLine();

            Console.Write("Opção: ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            List<int> lista = new List<int>();
            for (int i = 0; i < 10; i++) {
                lista.Add(i);
            }

            Console.WriteLine("Lista original:");
            foreach (int e in lista) {
                Console.Write(e + " ");
            }
            Console.WriteLine("\n");

            if (opcao == 1) {
                float media = calcMedia(lista, 0);
                Console.WriteLine("Média: " + media);
                int num = maioresMedia(lista, 0, media);
                Console.WriteLine("Número de elementos maiores do que a média: " + num);
            } else if (opcao == 2) {
                List<int> listAux = inversor(lista, 0);

                Console.WriteLine("Lista invertida:");
                foreach (int e in listAux) {
                    Console.Write(e + " ");
                }

            } else {
                Console.WriteLine("Opção inválida!");
            }

            Console.Read();

        }

        public static int maioresMedia(List<int> lista, int index, float media) {
            int maior = lista[index] > media ? 1 : 0;
            if (index == (lista.Count - 1)) {
                return maior;
            }

            return maior + maioresMedia(lista, ++index, media);
        }

        public static float calcMedia(List<int> lista, int index) {
            float media = (float) lista[index] / lista.Count;
            if (index == (lista.Count - 1)) {
                return media;
            }
            return media + calcMedia(lista, ++index);
        }

        public static List<int> inversor(List<int> lista, int index) {
            // Caso base - quando o indice chega no final da lista.
            if (index == lista.Count) {
                return lista;
            }

            lista.Insert(index++, lista[lista.Count - 1]);
            lista.RemoveAt(lista.Count - 1);
            // Chamada recursiva
            return inversor(lista, index);
        }
    }
}

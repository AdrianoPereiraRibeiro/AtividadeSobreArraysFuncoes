namespace ConsoleApp1AtividadeSobreArraysFunções
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Atividade sobre Arrays, Funções
            // e Programação Estruturada

            //Desenvolver um programa que receba 10 valores inteiros,
            //-5, 3, 4, 5, 9, 6, 10, -2, 11, 1, 2, 6, 7, 8, 0, -6
            //Permita:
            //            Encontrar o Maior Valor da sequência
            //Encontrar o Menor Valor da sequência
            //Encontrar o Valor Médio da sequência
            //Encontrar os 3 maiores valores da sequência
            //Encontrar os valores negativos da sequência
            //Mostrar na Tela os valores da sequência
            //Remover um item da sequência
            //Critérios de Aceite da Atividade:
            //            Deve utilizar arrays
            //            Deve utilizar funções
            //Pode utilizar a classe “Array” do Framework

            int[] numeros = { -5, 3, 4, 5, 9, 6, 10, -2, 11, 1, 2, 6, 7, 8, 0, -6 };
            MaiorValor(numeros);
            MenorValor(numeros);
            MediaDaSequencia(numeros);
            TresMaiores(numeros);
            MenoresQueZero(numeros);
            NumerosDaSequencia(numeros);
            RemoverOOnze(numeros);

            Console.ReadLine();
        }

         static void RemoverOOnze(int[] numeros)
        {
            
            Console.WriteLine("\n Digite o número para ser removido da sequencia: ");
            int remover = Convert.ToInt32(Console.ReadLine());
            numeros= numeros.Where(x => x != remover).ToArray();
           
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write(numeros[i] + " ");
            }
        }

        static void MenoresQueZero(int[] numeros)
        {
            Console.WriteLine("Esses são os números menores que zero:");
            for (int i = 0; i < numeros.Length; i++)
            {

                if (numeros[i] < 0)
                {
                    Console.Write(numeros[i] + " ");
                }
            }
        }

         static void NumerosDaSequencia(int[] numeros)
        {
            Console.WriteLine("\nOs números da sequência são: ");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write(numeros[i] + " ");
            }
        }

         static void TresMaiores(int[] numeros)
        {
            Array.Sort(numeros);
            Array.Reverse(numeros);
            Console.WriteLine("Os tres maiores valores da sequência são: " + numeros[0] + " " + numeros[1] + " " + numeros[2]);
        }

        static void MediaDaSequencia(int[] numeros)
        {
            //L3
            int soma = (numeros[0] + numeros[1] + numeros[2] + numeros[3] + numeros[4] + numeros[5] + numeros[6] + numeros[7] + numeros[8] + numeros[9] + numeros[10] + numeros[11] + numeros[12] + numeros[13] + numeros[14] + numeros[15]) / numeros.Length;
            Console.WriteLine("A média é igual a " + soma);
        }

        static void MenorValor(int[] numeros)
        {
            //L2
            Array.Sort(numeros);
            Console.WriteLine("O menor número da sequência é " + numeros[0]);
        }

        static void MaiorValor(int[] numeros)
        {
            //L1
            Array.Sort(numeros);
            Array.Reverse(numeros);
            Console.WriteLine("O maior número da sequência é " + numeros[0]);
        }
    }
}

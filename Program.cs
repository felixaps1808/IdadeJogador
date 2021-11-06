using System;

namespace IdadeJogador
{
    class Program
    {
        static void Main(string[] args)
        {
            byte idade;
            Console.WriteLine("Digite a idade do jogador");
            idade = Convert.ToByte(Console.ReadLine());

            if (idade >= 12)
            {
                Console.WriteLine("Voce pode Jogar!");
            }
            if (idade < 12)
            {
                Console.WriteLine("Voce não pode Jogar!");
            }
        }
    }
}

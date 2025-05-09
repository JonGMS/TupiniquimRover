using System;

namespace ProjetoTupiniquim
{
    internal class Program
    {
        /*
       |
      5|  |  |  |  |  |  |  |
       |  ===================
      4|  |  |  |  |  |  |  |
       |  ===================
      3|  |  |  |  |  |  |  |
       |  ===================
      2|  |  |  |  |  |  |  |
       |  ===================      
      1|  |  |  |  |  |  |  |
       |  ===================
      0|  |PT|  |  |  |  |  |
       |__________________________
            0  1  2  3  4  5
         */
        static void Main(string[] args)
        {
            int localizacaoX = 0, localizacaoY = 0;
            string comando;
            string sentido;

            Console.Write("Digite qual a localização inicial do X:");
            localizacaoX = Convert.ToInt16(Console.ReadLine());

            Console.Write("Digite qual a localização inicial do Y: ");
            localizacaoY = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite qual o sentido inicial [N] para Norte, [S] para Sul, [O] para Oeste e [L] para Leste: ");
            sentido = Console.ReadLine();


            Console.WriteLine("Digite o comando como [E] para esquerda, [D] para direita e [M] para andar para frente: ");
            ApresentarExemplo();
            comando = Console.ReadLine();
            comando = comando.ToUpper();

            char[] instrucoes = comando.ToCharArray();

            for (int posicao = 0; posicao < instrucoes.Length; posicao++)
            {
                if (instrucoes[posicao] == 'M') 
                {
                    if (sentido == "N")
                    {
                        localizacaoY++;
                    }
                    else if (sentido == "S")
                    {
                        localizacaoY--;
                    }

                    if (sentido == "O")
                    {
                        localizacaoX--;
                    }
                    else if (sentido == "L")
                    {
                        localizacaoX++;
                    }
                }

                if (instrucoes[posicao] == 'E')
                {
                    if(sentido == "N")
                    {
                        sentido = "O";
                    }   
                    else if(sentido == "O")
                    {
                        sentido = "S";
                    }
                    else if( sentido == "S")
                    {
                        sentido = "L";
                    }
                    else if(sentido == "L")
                    {
                        sentido = "N";
                    }
                }

                if (instrucoes[posicao] == 'D')
                {
                    if (sentido == "N")
                    {
                        sentido = "L";
                    }
                    else if(sentido == "L")
                    {
                        sentido = "S";
                    }
                    else if(sentido == "S")
                    {
                        sentido = "O";
                    }
                    else if(sentido == "O")
                    {
                        sentido = "N";
                    }
                }

                Console.WriteLine("Registro de localização: X " + localizacaoX + "- Y " + localizacaoY);
            }

        }

        private static void ApresentarExemplo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("(DMMMEMMEE): ");
            Console.ResetColor();
        }
    }
}

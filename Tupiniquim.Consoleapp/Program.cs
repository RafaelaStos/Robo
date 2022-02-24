using System;

namespace Tupiniquim.Consoleapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int localizacaoX, localizacaoY, localizacaoX2, localizacaoY2;
            char sentido;
            char sentido2;
            string comando, comando2;
                

                Console.WriteLine(" ====== Robo Tupiniquim ======\n");

                Console.WriteLine("Intruções para comandar  robo");
                Console.WriteLine("X e Y são a combinaçao de coordenadas do robo. Ex 5,5");

                Console.WriteLine("\n----------------------------------------------");
                Console.WriteLine("\nUse o os seguintes comandos para guiar o robo!");
                Console.WriteLine("\n----------------------------------------------");
                Console.WriteLine("\nE para a ESQUERDA; \nD para DIREITA;\nM para anda para frente.");
                Console.WriteLine("\nOs comandos são de forma sequencial.\nEx:MMMDMMMEM");
           
                Console.WriteLine("\n----------------------------------------------");
                Console.WriteLine("\n   Digite as intrução para o Primeiro Robô    ");
                Console.WriteLine("\n----------------------------------------------");

                Console.WriteLine("\nDigite a posição inicial do robo em X no grid:");
                localizacaoX = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a posição inicial do robo em Y no grid:");
                localizacaoY = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a direção inicial do robo no grid: ");
                sentido = Convert.ToChar(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("Posição Inicial do primeiro robo: " + localizacaoX + "," + localizacaoX + "," + sentido);

                Console.WriteLine("\nInstruções Para a area que deseja explorar:");
                comando = Console.ReadLine();
                char[] instrucao = comando.ToCharArray();

                for (int posicao = 0; posicao < instrucao.Length; posicao = posicao + 1)
                {
                    if (instrucao[posicao] == 'M')
                    {
                        if (sentido == 'N')
                        {
                            localizacaoY = localizacaoY + 1;
                        }
                        else if (sentido == 'S')
                        {
                            localizacaoY = localizacaoY - 1;
                        }
                        else if (sentido == 'L')
                        {
                            localizacaoX = localizacaoX + 1;
                        }
                        else if (sentido == 'O')
                        {
                            localizacaoX = localizacaoX - 1;
                        }
                    }
                    if (instrucao[posicao] == 'E')
                    {
                        if (sentido == 'N') sentido = 'O';
                        else if (sentido == 'S') sentido = 'L';
                        else if (sentido == 'L') sentido = 'N';
                        else if (sentido == 'O') sentido = 'S';
                    }
                    if (instrucao[posicao] == 'D')
                    {
                       if (sentido == 'N') sentido = 'L';
                       else if (sentido == 'S') sentido = 'O';
                       else if (sentido == 'L') sentido = 'S';
                       else if (sentido == 'O') sentido = 'N';
                    }


                }
                Console.WriteLine("Posição final do primeiro do robo: " + localizacaoX + "," + localizacaoY + "," + sentido);
                 Console.ReadKey();
            
                Console.Clear();
                Console.WriteLine("\n   Digite as intrução para o Segundo Robô    ");
                Console.WriteLine("\n----------------------------------------------");

                Console.WriteLine("\nDigite a posição inicial do robo em X no grid:");
                localizacaoX2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a posição inicial do robo em Y no grid:");
                localizacaoY2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a direção inicial do robo no grid: ");
                sentido2 = Convert.ToChar(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("Posição Inicial do Segundo robo: " + localizacaoX2 + "," + localizacaoY2 + "," + sentido2);

                Console.WriteLine("\nInstruções Para a area que deseja explorar:");
                comando2 = Console.ReadLine();
                char[] instrucao2 = comando2.ToCharArray();

                for (int posicao = 0; posicao < instrucao2.Length; posicao = posicao + 1)
                {
                    if (instrucao2[posicao] == 'M')
                    {
                        if (sentido2 == 'N')
                        {
                            localizacaoY2 = localizacaoY2 + 1;
                        }
                        else if (sentido2 == 'S')
                        {
                            localizacaoY2 = localizacaoY2 - 1;
                        }
                        else if (sentido2 == 'L')
                        {
                            localizacaoX2 = localizacaoX2 + 1;
                        }
                        else if (sentido2 == 'O')
                        {
                            localizacaoX2 = localizacaoX2 - 1;
                        }
                    }
                    if (instrucao2[posicao] == 'E')
                    {
                        if (sentido2 == 'N') sentido2 = 'O';
                        else if (sentido2 == 'S') sentido2 = 'L';
                        else if (sentido2 == 'L') sentido2 = 'N';
                        else if (sentido2 == 'O') sentido2 = 'S';
                    }
                    if (instrucao2[posicao] == 'D')
                    {
                        if (sentido2 == 'N') sentido2 = 'L';
                        else if (sentido2 == 'S') sentido2 = 'O';
                        else if (sentido2 == 'L') sentido2 = 'S';
                        else if (sentido2 == 'O') sentido2 = 'N';
                    }


                }
                Console.WriteLine("Posição final do Segundo do robo: " + localizacaoX2 + "," + localizacaoY2 + "," + sentido2);



            Console.ReadKey();
        }
    }
}
    


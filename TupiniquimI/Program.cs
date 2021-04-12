using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupiniquimI
{
    class Program
    {
        static void Main(string[] args)
        {


            double cordX, cordY = 0;
            string direcaoIncialRobo = "";
            string[] moverRobo = new string[1];
            int opcao = 0;



            {

                while (opcao != 2)
                {

                    Console.WriteLine("TUPNIQUIM I");               

                    Console.WriteLine("Infome a cordenada X  do robô");
                    cordX = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Infome a cordenada Y  do robô");
                    cordY = Convert.ToDouble(Console.ReadLine());


                    Console.WriteLine("Informe a direção incial do robô ");
                    direcaoIncialRobo = Console.ReadLine();
                    



                    if (direcaoIncialRobo != "N" && direcaoIncialRobo != "S" && direcaoIncialRobo != "L" && direcaoIncialRobo != "O")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" DIREÇÃO INICIAL INVALIDA, TENTE NOVAMENTE ");
                        Console.ReadLine();
                        
                        
                        Console.ResetColor();
                        Console.Clear();
                        

                        continue;
                        
                    }
                    


                    for (int i = 0; i < moverRobo.Length; i++)
                    {

                        Console.WriteLine("Informe as cordenadas que o robo deve seguir");
                        moverRobo[i] = Console.ReadLine();

                        string auxiliar = moverRobo[i];

                        char[] arrayCaracteres = auxiliar.ToCharArray();

                        PercorreArray(ref cordX, ref cordY, ref direcaoIncialRobo, arrayCaracteres);

                        Console.WriteLine();

                        Console.WriteLine(" Cordenadas Finais " + cordX + "," + cordY + "," + direcaoIncialRobo);

                        Console.ReadLine();

                        Console.Clear();

                        opcao++;
                    }
                }
            }
        }

        private static void PercorreArray(ref double cordX, ref double cordY, ref string direcaoIncialRobo, char[] arrayCaracteres)
        {
            for (int x = 0; x < arrayCaracteres.Length; x++)
            {
                if (arrayCaracteres[x] == 'M' || arrayCaracteres[x] == 'm')
                {
                    {
                        Contador(ref cordX, ref cordY, direcaoIncialRobo);

                    }
                }

                if (arrayCaracteres[x] == 'D' || arrayCaracteres[x] == 'd')
                {
                    direcaoIncialRobo = EhDireita(direcaoIncialRobo);
                }

                if (arrayCaracteres[x] == 'E' || arrayCaracteres[x] == 'e')
                {
                    direcaoIncialRobo = EhEsquerda(direcaoIncialRobo);
                }
            }
        }

        private static void Contador(ref double cordX, ref double cordY, string direcaoIncialRobo)
        {
            if (direcaoIncialRobo == "N")
            {
                cordY++;
            }
            else if (direcaoIncialRobo == "S")

            {
                cordY--;
            }

            else if (direcaoIncialRobo == "L")
            {
                cordX++;
            }

            else if (direcaoIncialRobo == "O")
            {
                cordX--;
            }
        }

        private static string EhDireita(string direcaoIncialRobo)
        {
            if (direcaoIncialRobo == "N")
            {
                direcaoIncialRobo = "L";

            }
            else if (direcaoIncialRobo == "S")
            {
                direcaoIncialRobo = "O";

            }
            else if (direcaoIncialRobo == "L")
            {
                direcaoIncialRobo = "S";

            }
            else if (direcaoIncialRobo == "O")
            {
                direcaoIncialRobo = "N";
            }

            return direcaoIncialRobo;
        }

        private static string EhEsquerda(string direcaoIncialRobo)
        {
            if (direcaoIncialRobo == "N")
            {
                direcaoIncialRobo = "O";

            }
            else if (direcaoIncialRobo == "S")
            {
                direcaoIncialRobo = "L";

            }
            else if (direcaoIncialRobo == "L")
            {
                direcaoIncialRobo = "N";

            }
            else if (direcaoIncialRobo == "O")
            {
                direcaoIncialRobo = "S";
            }

            return direcaoIncialRobo;
        }


    }

}
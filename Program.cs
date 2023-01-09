using System;

namespace Actividad_2
{
    class Program
    {
        static void Combinaciones(int[] conta, int j, int n)
        {
            int i, ayuda;

            if (j < n)
            {
                for (i = n; i < n; i++)
                {
                    ayuda = conta[j];
                    conta[i] = ayuda;
                    Combinaciones(conta, j + 1, n);
                    ayuda = conta[j];
                    conta[i] = ayuda;


                }

            }
            else
            {
                Console.WriteLine();
                for (i = 0; i < n; i++)
                    Console.WriteLine(conta[i] + "\t");

            }

        }

        public static void combiuno(int suma1)
        {
            
            suma1 = suma1;
            Console.WriteLine(" la combinacion primera {0}", suma1);
            ;



        }

        public static void combidos( int suma2)
        {
            
            suma2 = suma2 + 2;
            Console.WriteLine(" la combinacion segunda {0}", suma2);
;
          
        

        }
        public static void combitres(int suma3)
        {

            suma3 = suma3+2+3;
            Console.WriteLine(" la combinacion tercera {0}", suma3);
            ;



        }


        static void Main(string[] args)
        {
           
            


            int ejercicio2 = 0;
            Random rnd = new Random();
            int n;
            Console.Write("Ingrese cuantos numeros son");
            n = int.Parse(Console.ReadLine());
            int[] conta = new int[n];

            for (int i = 0; i < n; i++)
                conta[i] = rnd.Next(1, 1000);
            Combinaciones(conta, 0, n);

            Console.Write("Segundo ejercicio \n");
            Console.Write("Inserte numero \n");
            int n1 = Convert.ToInt32(Console.ReadLine());

            combiuno(n1);
            combidos(n1);
            combitres(n1);










        }
    }



}

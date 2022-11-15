using System;

namespace tp_8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            const int CantDias=7;
            
            string[] dias = {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo"};

            for (int i = 0; i < CantDias; i++)
            {
                Console.WriteLine("En el elemento {0} es el dia {1}",i,dias[i]);
            }

            Console.WriteLine("Presione una tecla para terminar...");
            Console.ReadKey();
        }
    }
}

using System;

namespace calculadora{
    class Program{
        static void Main(){
            Console.WriteLine("Calculadora");
            ConsoleKeyInfo cki;
            int op;
            Calculadora num = new Calculadora(retornarNUm());
            do{
                opciones();
                op = Convert.ToInt32(Console.ReadLine());
                if(op == 1){num.Suma(retornarNUm());}
                if(op == 2){num.Resta(retornarNUm());}
                if(op == 3){num.Multp(retornarNUm());}
                if(op == 4){num.Div(retornarNUm());}
                if(op == 5){num.Limpiar();}
                Console.Clear();
                System.Console.WriteLine($"Num = {num.X}");
                cki = Console.ReadKey();
            }while(cki.Key != ConsoleKey.Escape);
            
        }

        static void opciones(){
            Console.WriteLine("1) +\t2) -\t3) *\t4) /\t5) AC");
        }
        static double retornarNUm () {
            System.Console.WriteLine("Num:");
            double num = Convert.ToDouble(Console.ReadLine());
            return num;
        }
    }
}

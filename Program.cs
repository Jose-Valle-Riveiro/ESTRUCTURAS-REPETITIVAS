using System;

namespace ESTRUCTURAS_REPETITIVAS
{
    class Ejercicios
    {
        //METODO 1
        public void metodo1()
        {

            int num = 0;
            do
            {
                Console.WriteLine("EJERCICIO 1");
                Console.WriteLine("INGRESE UN NUMERO ENTERO POSITIVO");
                num = Convert.ToInt32(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine(num + " ES PAR");

                }
                else
                {


                }



            } while (num != 99);
        }

        //METODO 2
        public void metodo2()
        {
            Console.WriteLine("EJERCICIO 2");
            Console.WriteLine("INGRESE UN NUMERO DE LINEAS");
            int num = Convert.ToInt32(Console.ReadLine());
            string fila = "";

            for (int i = 1; i <= num; i++)
            {

                fila = fila + i;
                Console.WriteLine(fila);
            }

        }

        //METODO 3

        public void metodo3()
        {
            int suma = 0;
            Console.WriteLine("EJERCICIO 3");

            for (int i = 100; i <= 200; i++)
            {

                if(i % 9 == 0)
                {
                    Console.WriteLine(i);
                    suma = suma + i;

                }
                else
                {

                }

            }

            Console.WriteLine(suma);

        }
        

        //METODO 4
        public void metodo4()
        {
            Console.WriteLine("EJERCIICO 4");
            Console.WriteLine("INGRESE UN NUMERO ENTERO POSITIVO");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {

                Console.Write(i + ": ");
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write((i * j) + "\t");
                }
                Console.Write("\n");
            }



        }


        static void Main(string[] args)
        {
            Ejercicios p = new Ejercicios();


            p.metodo1();

            p.metodo2();

            p.metodo3();

            p.metodo4();

        }
    }
}

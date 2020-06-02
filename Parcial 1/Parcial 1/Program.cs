using System;

namespace Parcial_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Pedir al usuario el precio de un producto y la forma de pagar(efectivo o tarjeta)
             si la forma de pago es mediante tarjeta, pedir el numero de tarjeta(12 digitos). 
             Ojo, validar que el valor ingresado en el sea positivo.*/



             Console.Write(" \n ~ Ingrese el precio del producto: ");
             int precio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n  ~Forma de pago: ");
            Console.WriteLine("  1- Tarjeta ");
            Console.WriteLine("  2- Efectivo ");
            Console.Write(" ~ ");
            int formadepago = Convert.ToInt32(Console.ReadLine());


            switch (formadepago)
            {
                case 1:
                    Console.Write("\n  ~Ingrese el numero de su tarjeta: ");
                    long tarjeta = Convert.ToInt64(Console.ReadLine());
                    if (tarjeta < 0)
                    {
                        Console.WriteLine("  ~El numero es incorrecto ");
                    }
                    else
                    {
                        Console.WriteLine("\n  ~ Su pago se ha hecho satisfactoriamente ~ ");
                        Console.WriteLine("  ~ Gracias por su compra, vuelva pronto ~ ");
                    }
                    break;

                case 2:
                    Console.WriteLine("\n  ~ Su pago se ha hecho satisfactoriamente ~ ");
                    Console.WriteLine("\n  ~ Gracias por su compra, vuelva pronto ~ ");
                    break;
            }


            Console.ReadKey();










        }
    }
}

using System;

namespace Fin_de_Semana
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear un programa que pida el nombre de un dia de la semana e identifique 
                 si es fin de semana o no. En caso de error, indicarlo*/

            Console.Write("\n ~ Ingrese un dia la semana: ");
            string dia = Console.ReadLine();

            if (dia == "Sabado" || dia == "Domingo")
            {
                Console.WriteLine(" \n ~ ES FIN DE SEMANA ~ ");
            }
            else if(dia == "Lunes" || dia == "Martes" || dia == "Miercoles" || dia == "Jueves" || dia == "Viernes")
            {
                Console.WriteLine(" \n ~ NO es fin de semana ~ ");
            }
            else
            {
                Console.WriteLine(" \n ~ Error ~ ");
            }

            Console.ReadKey();
        }
    }
}

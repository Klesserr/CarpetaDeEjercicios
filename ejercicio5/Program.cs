using System;
namespace ejercicios
{
    class Program
    {
        /*Timmy y Sarah creen que están enamorados, pero en el lugar donde viven, 
        solo lo sabrán una vez que cada uno elija una flor. Si una de las flores tiene un número par de pétalos y la otra tiene un número 
        impar de pétalos, significa que están enamorados.
        Escribe una función que tome el número de pétalos de cada flor y devuelva verdadero si están enamorados
        y falso si no lo están.*/
        static void Main(string[] args)
        {
            Console.WriteLine(Love(0, 1));
        }

        public static bool Love(int flower1, int flower2)
        {
            if (flower1 % 2 != 0 && flower2 % 2 == 0)
            {
                return true;
            }
            else if(flower1 % 2 == 0 && flower2 % 2 != 0)
            {
                return true;
            }else{
                return false;
            }

        }
    }
}
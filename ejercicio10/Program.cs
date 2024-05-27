using System;
using System.IO.Compression;
using System.Runtime.InteropServices;
using System.Security.Principal;
namespace ejercicios
{
    class Program
    {
        /*Suma todos los números de una matriz dada (o lista), excepto el elemento más alto y el más bajo (por valor, no por índice).
          El elemento más alto o más bajo respectivamente es un único elemento en cada extremo, 
          incluso si hay más de uno con el mismo valor.
          Ejemplo
          {6,2,1,8,10} => 6 + 2 + 8 = 16
          {1,1,11,2,3} => 1 + 2 + 3 = 6
          Ten en cuenta la validación de entrada
          Si se proporciona un valor vacío (null, None, Nothing, etc.) 
          en lugar de una matriz, o la matriz dada es una lista vacía o una lista con solo 1 elemento, devuelve 0.
*/
        static void Main(string[] args)
        {
            int[] numbers = { 6, 2, 1, 8, 10 };
            // int[] numbers = { 1,1,11,2,3 };
            Console.WriteLine(Sum(numbers));
        }
        public static int Sum(int[] numbers)
        {

            int amountTotal = 0;
            int repeatValue = 0;
            bool isRepeatNumber = true;

            if (numbers == null) 
            {
                return 0;
            }
            else if (numbers.Length == 0)
            {
                return 0;
            }
            else if (numbers.Length == 1)
            {
                return 0;
            }

            int minValue = numbers[0];
            int maxValue = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                int value = numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int nextValue = numbers[j];
                    if (value == nextValue)
                    {
                        repeatValue = value;
                    }
                    else if (value < nextValue)
                    {
                        if (value >= maxValue)
                        {
                            maxValue = nextValue;
                        }
                    }
                    else if (value > nextValue)
                    {
                        if (value <= minValue)
                        {
                            minValue = nextValue;
                        }

                    }
                }
            }
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (isRepeatNumber)
                {
                    amountTotal += repeatValue;
                    isRepeatNumber = false;
                }

                if (numbers[i] != minValue && numbers[i] != maxValue)
                {
                    amountTotal += numbers[i];
                }
            }

            return amountTotal;
        }
    }
    public static int Prueba(int[] numbers)
    {
        int amountTotal = 0;
        int repeatValue = 0;
        bool isRepeatNumber = true;

        if (numbers == null || numbers.Length <= 1)
        {
            return 0;
        }

        int minValue = numbers[0];
        int maxValue = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        { 
            int nextValue = numbers[i];
            if (minValue > nextValue)
            {
                minValue = nextValue;
            }
            if (maxValue < nextValue)
            {
                maxValue = nextValue;
            }
        }


    }
using System;
namespace ejercicios
{
    class Program
    {
        /*En este kata, necesitas verificar el array proporcionado (x) en busca de buenas ideas 'good' y malas ideas 'bad'. 
        Si hay una o dos buenas ideas, devuelve 'Publish!', 
        si hay más de 2, devuelve '¡I smell a series!'. 
        Si no hay buenas ideas, como suele ser el caso, devuelve 'Fail!*/
        static void Main(string[] args)
        {
            string[] x = { "goal", "draw" };
            Console.WriteLine(Well(x));
        }
        public static string Well(string[] x)
        {
            int countGood = 0;
            string result = "";

            for (int i = 0; i < x.Length; i++)
            {
                x[i] = x[i].ToLower();
                if (x[i] == "good")
                {
                    countGood++;
                }
            }

            if (countGood > 2)
            {
                result += "I smell a series!";
                return result;
            }
            else if (countGood >= 1 && countGood <= 2)
            {
                result += "Publish!";
                return result;
            }
            else
            {
                result += "Fail!";
                return result;
            }
        }
    }
}
using System;
namespace ejercicios
{
    class Program
    {
        /*.*/
        static void Main(string[] args)
        {
            string str = "Robin Sight";
            Console.WriteLine(StringToArray(str));
        }

        public static string[] StringToArray(string str)
        {
            string[] actualWords = str.Split(" ");
            
            string[] result = new string[actualWords.Length];

            for(int i = 0; i < actualWords.Length;i++){
                result[i] += actualWords[i];
            }

            return result;
           
        }
    }
}
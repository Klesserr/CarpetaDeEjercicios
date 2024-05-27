using System;
namespace ejercicios
{
    class Program
    {
        /*Se te dará una lista de cadenas. Debes ordenarla alfabéticamente (sensible a mayúsculas y minúsculas, 
        y basado en los valores ASCII de los caracteres) y luego devolver el primer valor.

        El valor devuelto debe ser una cadena y tener "***" entre cada una de sus letras.
        No debes eliminar ni agregar elementos al array.*/
        static void Main(string[] args)
        {
            string[] s = { "use","turn","out","are" };
            Array.Sort(s);

            Console.WriteLine(Prueba(s));
        }

        public static string TwoSort(string[] s)
        {
            string word = "";
            for (int i = 0; i < s.Length;i++)
            {
                string letter = s[i];

                for (int j = 0; j < letter.Length; j++)
                {
                    char characterLetter = letter[j];
                    word += characterLetter;
                    if (characterLetter != letter[letter.Length - 1])
                    {
                        word += "***";
                    }

                }
                return word;
            }
            return word;
        }

        public static string Prueba(string[] s)
        {
            string word = s[0];
            string result = "";
            for (int i = 0; i < word.Length; i++)
            {
                result += word[i] + "***";
                if (i = word.Length - 1)
                {
                    result += word[i];
                }
            }
            return result;
        }
    }
}
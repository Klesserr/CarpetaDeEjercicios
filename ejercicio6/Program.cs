using System;
using System.Data;
namespace ejercicios
{
    class Program
    {
        /*Escribe una función que tome un array de palabras y las una en una oración y devuelva la oración. 
        Puedes ignorar la necesidad de sanear las palabras o añadir puntuación, pero debes agregar espacios entre cada palabra. 
        ¡Ten cuidado, no debería haber un espacio al principio ni al final de la oración!
        Ejemplo: ("hello world") <- {hello ,world}
        */
        static void Main(string[] args)
        {
            string[] words = { "hello","new","world" };
            string aux = Prueba(words);
            Console.WriteLine(aux);
        }
        public static string Smash(string[] words)
        {
            string wordsSeparation;
            string[] samePosition = new string[words.Length];
            string resultWorlds = "";

            for (int i = 0; i < samePosition.Length; i++)
            {
                wordsSeparation = words[i].Replace("\"", " ");//En caso de que llegue un string de comillas, lo quitamos.
                
                string[] wordSplit = wordsSeparation.Split(" "); //wordSplit genera un array de 2 posiciones [0,1](en este caso);

                for (int j = 0; j < wordSplit.Length; j++) //Iteramos sobre wordSplit, ya que contiene el array inicial dividido
                {
                    resultWorlds += wordSplit[j] + " ";

                    if (wordSplit[j] != wordSplit[wordSplit.Length - 1]) //Comprobamos que tengan distinta posicion para agregar ,
                    {
                        resultWorlds += ",";
                    }
                }
            }
            resultWorlds = resultWorlds.Trim();
            return resultWorlds;
        }

        public static string Prueba(string[] words)
        {
            string assist = "";

            for(int i = 0; i < words.Length;i++)
            {
                assist += words[i];
                if (words[i] != words.Length-1)
                {
                    assist+=" "; //Append a un string le va introduciendo cosas.
                }
                
            }
            return assist;
        }
    }
}
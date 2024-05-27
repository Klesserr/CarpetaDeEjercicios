using System;
using System.Dynamic;
namespace ejercicios
{
    class Program
    {
        /*La tarea consiste en escribir una función que convierta un nombre en sus iniciales. 
        Esta tarea asume estrictamente que se proporcionan dos palabras con un espacio entre ellas.
        El resultado debería ser dos letras en mayúsculas con un punto separándolas.
        Ejemplo1: Sam Harris -> S.H / Evan Cole -> E.C
        Ejemplo2: SAM HARRIS -> S.H
        Ejemplo3: sam harris -> S.H*/
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce tú nombre");
            string name = Console.ReadLine();
            string valueName = AbrrevName(name);
            Console.WriteLine(valueName);

            string nom = "Pedro Gomez" ;
            for(int i = 0; i< nom.Length; i++)
            {
                Console.WriteLine(nom[i]);
            }
        }

        public static string AbrrevName(string name)
        {

            string assist = "";
            assist += name[0];
            for (int i = 0; i < name.Length - 1; i++)
            {
                char actualChar = name[i];
                char nextChar = name[i + 1];
                if (!(actualChar >= 65 && actualChar <= 90 && nextChar >= 97 && nextChar <= 122))
                {
                    if (nextChar == ' ' && actualChar != ' ')
                    {
                        assist += nextChar;
                    }
                    if (actualChar == ' ' && nextChar != ' ')
                    {
                        assist += nextChar;
                    }

                }
            }
            assist = assist.Replace(" ", ".");
            assist = assist.ToUpper();
            return assist;
        }

        public static string Prueba(string name)
        {
            string[] splitName = name.Split(' ');
            char inicialNombre = (splitName[0])[0];
            char inicialApellido = (splitName[1])[0];
            return (inicialNombre + "." + inicialApellido).ToUpper();
        }
    }
}
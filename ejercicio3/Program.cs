using System;

namespace ejercicios
{
    class Program
    {
        /*Nuestro equipo de fútbol ha terminado el campeonato.

        Los resultados de los partidos de nuestro equipo están registrados en una colección de cadenas. 
        Cada partido está representado por una cadena en el formato "x:y", donde x es el marcador de nuestro equipo e y es el marcador de nuestros oponentes.
                                                      
        Por ejemplo: ["3:1", "2:2", "0:1", ...]
        Los puntos se otorgan para cada partido de la siguiente manera:

        si x > y: 3 puntos (victoria)
        si x < y: 0 puntos (derrota)
        si x = y: 1 punto (empate)
        Necesitamos escribir una función que tome esta colección y devuelva el número de puntos que nuestro equipo (x)
        obtuvo en el campeonato según las reglas dadas arriba.
        */
        static void Main(string[] args)
        {
            string[] games = [ "1:0", "2:0", "3:0", "4:4", "2:2", "3:3", "1:4", "2:3", "2:4", "3:4"]; //Total points: 12.
            Console.WriteLine(TotalPoints(games));
        }

        public static int TotalPoints(string[] games)
        {
            int points = 0;
            for (int i = 0; i < games.Length; i++)
            {
                string matchResult = games[i];
                for (int j = 0; j < matchResult.Length;)
                {
                    char newCharacter = matchResult[j];
                    char newCharacterEnemy = matchResult[matchResult.Length - 1];

                    int valueTeam = newCharacter - '0';
                    int valueEnemyTeam = newCharacterEnemy - '0';

                    if (valueTeam > valueEnemyTeam)
                    {
                        points += 3;
                        break;
                    }
                    else if (valueTeam < valueEnemyTeam)
                    {
                        points += 0;
                        break;
                    }
                    else
                    {
                        points += 1;
                        break;
                    }
                }
            }
            return points;
        }

        public static int Prueba(string[] games)
        {
            int points = 0;
            foreach (var puntuacio in games)
            {
                string[] equips = puntuacio.Split(':'); //Nos quita los 2 puntos, obtenemos 1 array que es 1 y 0.
                if (equips[0] > equips[1])
                {
                    points += 3;
                }
                else if (equips[0] == equips[1])
                {
                    points += 1;
                }
            }
            return points;
        }

    }
}
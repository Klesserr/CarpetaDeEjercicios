using System;

namespace ejercicios
{
    class Program
    {
        /*Función que devuelve una cadena con el equipo ganador:
        Ejemplo1: WinMatch(["Germany","Ukraine"],[2,0]) At match Germany-Ukraine, Germany won!
        Ejemplo2: WinMatch(["Belgium","Italy"],[0,2]) At match Belgium-Italy, Italy won!
        Ejemplo3: WinMatch(["Portugal","Island"],[1,1]) At match Portugal-Island, teams played draw
        */
        static void Main(string[] args)
        {
            string[] teams = ["Germany", "Ukraine"];
            int[] scores = [2, 0];
            string winTeam = WinMatch(teams, scores);
            Console.WriteLine(winTeam);
        }
            
        public static string WinMatch(string[] teams, int[] scores)
        {
            for (int i = 0; i < teams.Length-1; i++)
            {
                if (scores[i] > scores[i + 1])
                {
                    return "At the match " + teams[i] + " - " + teams[i + 1] + ", " + teams[i] + " won!";
                }
                else if (scores[i + 1] > scores[i])
                {
                    return "At the match " + teams[i] + " - " + teams[i + 1] + ", " + teams[i + 1] + " won!";
                }else{
                    return "At match "+teams[i]+" - "+teams[i + 1] +", teams played draw.";
                }
            }
        }

        public static string Prueba(string[] teams, int[] scores)
        {
            if (scores[0] > scores[1])
            {
                return teams[0];
            }
            else if (scores[0] < scores[1])
            {
                return teams[1];
            }
            else
            {
                return "draw";
            }
        }
    }
}
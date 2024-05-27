using System;
namespace ejercicios{
    class Program{
        /*Completa la función de suma de cuadrados de manera que eleve al cuadrado cada número que se le pase y luego sume los resultados.
         Por ejemplo, para [1, 2, 2] debería devolver 9 porque ; 1^2 + 2^2 + 2^2 = 9.*/
        static void Main(string[]args){
            int[]numbers = [1,2];
            Console.WriteLine(SquareSum(numbers));
        }
        public static int SquareSum(int[] numbers){
            int amount=0;
            
            for(int i = 0 ; i < numbers.Length; i++){
                amount += numbers[i]*numbers[i];
            }
            return amount;
        }
    }
}
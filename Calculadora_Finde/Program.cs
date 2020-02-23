using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Finde
{
    class Program
    {

        static void Main(string[] args)
        {
            float num1 = 0.0f;
            float num2 = 0.0f;
            string valor;
            string valor2;

            Console.WriteLine("Dame un primer número");
            valor = Console.ReadLine();
            num1 = Convert.ToSingle(valor);
            Console.WriteLine("Dame un segundo número");
            valor2 = Console.ReadLine();
            num2 = Convert.ToSingle(valor2);


            float resultadoFinal = Calculadora(ref num1, ref num2); //xq me falla??!

            Console.WriteLine($"El resultado final es: {resultadoFinal}");
        }
           
            static float Calculadora(ref float num1, ref float num2)
            {
            float opcion = 0.0f;
            
            Console.WriteLine("Que operación quieres hacer con estos 2 números?");
            Console.WriteLine("1- Suma");
            Console.WriteLine("2 - Resta");
            Console.WriteLine("3 - Multiplicación");
            Console.WriteLine("4 - División");
            opcion = Convert.ToSingle(Console.ReadLine());

            if (opcion == 1){
            float resultadoFinal = 0.0f;
                
            resultadoFinal = Suma(num1, num2);
            }
            if (opcion == 2){
            Resta(num1, num2);
         
            }
            if (opcion == 3){
            Division(num1, num2);
            
            }            
            if (opcion == 4){
            Multiplicacion(num1, num2);
            
            }

            //switch (opcion)
              //  {
                //    case 1:
                  //      Suma(num1, num2);
             //           break;
              //     case 2:
              //          Resta(num1, num2);
              //          break;
              //      case 3:
             //           Division(num1, num2);
             //           break;
             //       case 4:
             //           Multiplicacion(num1, num2);
             //           break;
                  //  default:
                    //    Console.WriteLine("Opción incorrecta");
                     //   return resultado= 0.0f;
                     //   break;
             //  }
            }

            static float Suma (float num1, float num2)
            {
            float resultado = 0.0f;

            resultado = num1 + num2;
                return resultado;

            }
            static float Resta(float num1, float num2)    
            {

            float resultado = 0.0f;

            resultado = num1 - num2;
                return resultado;

            }
            static float Division(float num1, float num2)  //xq es static i no pot ser public?
            {

            float resultado = 0.0f;


            if (num2 == 0)
                {
                Console.WriteLine("Cualquier número dividido por 0 es infinito");
                return 0.0f; //Investigar
                } else { 

                resultado = num1/num2;
                return resultado;
            }
            }
            static float Multiplicacion(float num1, float num2)
            {

            float resultado = 0.0f;

            resultado = num1 * num2;
                return resultado;

            }

    }
}

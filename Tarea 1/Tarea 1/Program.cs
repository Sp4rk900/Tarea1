using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Punto hola = new Punto(3,5);
            Punto xd = new Punto(7,8);
            float escalar = 5;
            float result_multi = 0;

            Vector vec1 = new Vector(3,7,5,8);
            Vector vec = new Vector(hola, xd);
            Vector result_mult = new Vector();
            Vector result_mult_esc = new Vector();

            //Setters
            /*vec.set_fin(5,5);
            vec.set_origen(4, 4);
            */
           
            
            
            //Multiplicacion vector - escalar 
            result_mult_esc = vec * escalar;

            Console.WriteLine($"Resultado de la multiplicacion escalar : {result_mult_esc.get_x_vector()}--{result_mult_esc.get_y_vector()}\n");

            //Multiplicacion vector - vector

            result_multi = vec1 * vec;

            Console.WriteLine($"Resultado de la multiplicacion punto punto : {result_multi} \n");

            //Resta 

            Vector result_resta = vec - vec;

            Console.WriteLine($"Resultado de la resta : {result_resta.get_origen_x()},{result_resta.get_origen_y()}--{result_resta.get_fin_x()},{result_resta.get_fin_y()} \n");


           Console.ReadKey();

                


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1
{
    class Vector
    {
        private  Punto origen;
        private  Punto fin;
        private  double magnitud;
        private float mult;
        private float x_vector;
        private float y_vector;

        //Constructores
        public Vector()
        {
            origen = new Punto();
            fin = new Punto();
            calcular_magnitud();
        }
        public Vector(Punto _origen, Punto _fin)
        {
            origen = new Punto(_origen.GetX(), _origen.GetY());
            fin = new Punto(_fin.GetX(), _fin.GetY());
            calcular_magnitud();
        }
        public Vector(float x_origen, float y_origen, float x_fin, float y_fin)
        {
            origen = new Punto(x_origen, y_origen);
            fin = new Punto(x_fin, y_fin);
            calcular_magnitud();
        }

        public Vector(float x, float y)
        {

            x_vector = x;
            y_vector = y;

            origen = new Punto();
            fin = new Punto();

        }


        //Metodos

        private void calcular_magnitud()
        {
            magnitud = Math.Sqrt(Math.Pow((fin.GetX() - origen.GetX()), 2) + Math.Pow((fin.GetY() - origen.GetY()), 2));
        }
        //Getter Magnitud
        public double get_magnitud()
        {
            return magnitud;
        }
        //Getter x_vector

        public float get_x_vector()
        {

            return x_vector;

        }

        //Getter y_vector

        public float get_y_vector()
        {

            return y_vector;

        }

        //Getter origen
        public float get_origen_x()
        {

            return origen.GetX();
            

        }
        public float get_origen_y()
        {

            return origen.GetY();


        }
        //Getter fin
        public float get_fin_x()
        {

            return fin.GetX();

        }
        public float get_fin_y()
        {

            return fin.GetY();

        }
        //Setter origen
        public void set_origen(Punto _origen)
        {
            origen = new Punto(_origen.GetX(), _origen.GetY());
            calcular_magnitud();
        }
        public void set_origen(float x, float y)
        {
            origen = new Punto(x, y);
            calcular_magnitud();
        }
        //Setter final
        public void set_fin(Punto _fin)
        {

            fin = new Punto(_fin.GetX(), _fin.GetY());
            calcular_magnitud();

        }

        public void set_fin(float x, float y)
        {

            fin = new Punto(x, y);
            calcular_magnitud();

        }

        //Resta
        public static Vector operator -(Vector factor1, Vector factor2)
        {
            Punto nuevo_origen = new Punto(factor1.origen.GetX() - factor2.origen.GetX(),
                                           factor1.origen.GetY() - factor2.origen.GetY());

            Punto nuevo_fin = new Punto(factor1.fin.GetX() - factor2.fin.GetX(),
                                        factor1.fin.GetY() - factor2.fin.GetY());

            return new Vector(nuevo_origen, nuevo_fin);

        }


        //Escalar
        public static Vector operator *(Vector factor_1, float factor_2)

        {


            float x_1;

            float y_1;

            x_1 = (factor_1.fin.GetX() - factor_1.origen.GetX()) * factor_2;
            
            y_1 = (factor_1.fin.GetY() - factor_1.origen.GetY()) * factor_2;

            return new Vector(x_1,y_1);

        }

        //Vector
        public static float operator *(Vector factor_1, Vector factor_2)

        {

            Vector result = new Vector();

            //result.mult = ((factor_1.origen.GetX() * factor_2.origen.GetX()) + (factor_1.fin.GetY() * factor_2.fin.GetY()));
            float x_1;

            float y_1;

            x_1 = (factor_1.get_fin_x() - factor_1.get_origen_x()) * (factor_2.get_fin_x() - factor_2.get_origen_x());
            
            y_1 = (factor_1.get_fin_y() - factor_1.get_origen_y()) * (factor_2.get_fin_y() - factor_2.get_origen_y());

            result.mult = x_1 + y_1;

            return result.mult;
        }

    }
}
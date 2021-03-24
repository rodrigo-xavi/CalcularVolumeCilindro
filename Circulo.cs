using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Atividade_VolumeCIlindro_
{
    class Circulo
    {
        private double R;

        public void setR (double R)
        {
            this.R = R;
        }
        public double getR()
        {
            return R;
        }
        public double perimetro(double R)
        {
            double P;

            P = 2 * Math.PI *R ;

            return P;
        }
        public double area (double R)
        {
            double A;

            A = Math.PI* Math.Pow(R, 2);

            return A;
        }
    }
    
}

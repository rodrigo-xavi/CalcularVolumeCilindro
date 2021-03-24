using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Atividade_VolumeCIlindro_
{
    class Retangulo
    {
        private double L1;
        private double L2;

        public void setL1(double L1)
        {
            this.L1 = L1;
        }
        public double getL1()
        {
            return L1;
        }
        public void setL2(double L2)
        {
            this.L2 = L2;
        }
        public double getL2()
        {
            return L2;
        }
        public double perimetro(double L1, double L2)
        {
            double P;
            P = 2 * (L1 + L2);
            return P;
        }
        public double Area(double L1, double L2)
        {
            double A;
            A = L1 * L2;

            return A;
        }
    }
    

}

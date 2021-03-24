using System;

namespace _3_Atividade_VolumeCIlindro_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o comprimento do retangulo:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a largura do retangulo:");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o raio do circulo: ");
            double raio = double.Parse(Console.ReadLine());
            
            Retangulo r = new Retangulo();
            Circulo c = new Circulo();
            double Cilindro;

            r.setL1(x);
            r.setL2(y);
            c.setR(raio);

            Cilindro = c.area(c.getR())*r.getL1();

            Console.WriteLine("Perimetro do Retangulo: " + r.perimetro(r.getL1(), r.getL2()));
            Console.WriteLine("Area do Retangulo: "+r.Area(r.getL1(),r.getL2()));
            Console.WriteLine("Perimetro do Circulo: "+c.perimetro(c.getR()));
            Console.WriteLine("Area do Circulo: " + c.area(c.getR()));
            Console.WriteLine("Volume do cilindro: " + Cilindro);
        }
    }
}

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab5_1
{
    class Triangle : Figure
    {
        protected float a;
        protected float b;
        protected float c;
        public Triangle() { }

        
        public override void Input(string file)
        {
            using (StreamReader MyFile = new StreamReader(file))
            {

                a = float.Parse(MyFile.ReadLine());
                b = float.Parse(MyFile.ReadLine());
                c = float.Parse(MyFile.ReadLine());
            }
        }
        public override double Sq()
        {
            double p;
            p = 1.0 / 2.0 *(a+b+c);
            return Math.Pow((p * (p - a) * (p - b) * (p - c)), 1.0 / 2.0);
        }
        public override double Pr()
        {
            return a+b+c;
        }
        public override void Output()
        {
            Console.WriteLine("a = {0}      b = {1}     c = {2}", a, b,c);
            Console.WriteLine("Square of triangle is {0:f2} \nPerimetr of triangle is {1}", Sq(), Pr());
        }

    }
}

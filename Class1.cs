using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab5_1
{
    class Rectangle : Figure
    {
        protected float a;
        protected float b;
        public Rectangle() { }
        public override void Input(string file)
        {
            using (StreamReader MyFile = new StreamReader(file))
            {
                a = float.Parse(MyFile.ReadLine());
                b = float.Parse(MyFile.ReadLine());
            }
        }
        public override double Sq()
        {
            return a * b;
        }
        public override double Pr()
        {
            return 2*(a+b);
        }
        public override void Output()
        {
            Console.WriteLine("a = {0}      b = {1} ",a , b);
            Console.WriteLine("Square of rectangle is {0:f2} \nPerimetr of rectangle is {1:f2}", Sq(),Pr());
        }

    }
}

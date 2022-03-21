using System;

namespace _220321
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //int res = add(3,5);
            //Console.WriteLine(res);

            Car myCar = new Car();

            myCar.ShowInfo();
        }

        static private int add(int a,int b)
        {
            return a + b;
        }
    }
}

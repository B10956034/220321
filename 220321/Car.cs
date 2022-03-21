using System;
using System.Collections.Generic;
using System.Text;

namespace _220321
{
    class Car
    {
        string color = "Black";
        int cc = 1500;
        string brand = "BMW";

        public void StartEngin()
        {
            Console.WriteLine("發動引擎");
        }

        public void ShowInfo()
        {
            Console.WriteLine("顏色是：" + color);
            Console.WriteLine("CC數是：" + cc);
            Console.WriteLine("品牌是：" + brand);
        }

        public virtual void opendoor()
        {
            Console.WriteLine("側門打開");
        }

    }
}

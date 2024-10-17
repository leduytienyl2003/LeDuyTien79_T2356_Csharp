using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_3
{
    internal class Circle:Shape
    {
        //phương thức nhập liệu
        public void InputData()
        {
            Console.Write("nhâp bán kính:");
            radius= int.Parse(Console.ReadLine());
        }
        //ghi đè phương thức tính diện tích
        public override float Area()
        {
            return radius * 3.14F * radius; 
        }
        //ghi đè phương thức tính chu vi
        public override float CircumFerence()
        {
            return 2 * 3.14F * radius;
        }
    }
}

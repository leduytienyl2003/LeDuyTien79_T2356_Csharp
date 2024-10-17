using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_3
{
    internal class Rectangle:Shape
    {
        //phương thức nhập liệu
        public void InputData()
        {
            Console.Write("nhập chiều dài:");
            length=int.Parse(Console.ReadLine());
            Console.Write("nhập chiều rộng:");
            width=int.Parse(Console.ReadLine());
        }
        //ghi đè phương thức tính diện tích
        public override float Area()
        {
            return length*width;
        }
        //ghi đè phương thức tính chu vi
        public override float CircumFerence()
        {
            return length*2*width;
        }
    }
}

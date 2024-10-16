using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_1
{
    internal class Car
    {
        
        //khai báo các trường với phạm vi public
        public string make;
        public string model;
        public string color;
        public int year;

        //định nghĩa phương thức start
        public void start() {
            System.Console.WriteLine(model + "khởi động");        
        }
        //định nghĩa phương thức stop
        public void stop() { System.Console.WriteLine(model + "dừng"); }
    }
}

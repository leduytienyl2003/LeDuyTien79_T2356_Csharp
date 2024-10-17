﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    internal class StudentUniversity:StudentCollege
    {
        protected double score4;
        //constructor
        public StudentUniversity(string name,int year, double score1, double score2, double score3, double score4) : base(name, year, score1, score2, score3)
        {
            this.score4 = score4;
        }
        //phương thức tính trung bình điểm
        public override double Average()
        {
            return (score1+score2+score3+score4)/4;
        }
        //phương thức hiển thị thông tin
        public new void Display()
        {
            base.Display();
            Console.WriteLine("score4: {0:N}", score4);
        }
    }
}

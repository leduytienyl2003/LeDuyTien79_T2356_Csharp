﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_2
{
    internal class Business
    {
        //lớp nhà ở
        public class House
        {
            public string HouseNo { get; set; }
            public decimal Price { get; set; }
        }
        //tạo namespace con đại lý lồng bên trong namespace kinh doanh
        namespace Dealership
        { 
        //tạo lớp xe
        public class Car
        {
        public string CarNo { get; set; }
        public decimal Price { get; set; }
        }
    }
 }


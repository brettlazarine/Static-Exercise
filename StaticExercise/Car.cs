﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public class Car
    {
        public Car()
        {
            CarLot.numberOfCars++;
        }
    }
}

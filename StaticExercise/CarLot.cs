using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public class CarLot
    {
        public static int numberOfCars { get; set; }
        public CarLot()
        {
            numberOfCars++;
        }
    }
}

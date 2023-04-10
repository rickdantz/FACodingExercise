using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCar
{
    class Ford: Car
    {
        public override void Run()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The car runs");
        }
        public override void Accelerate()
        {
            Console.WriteLine("The car accelerates");
        }

        public override void Stop()
        {
            Console.WriteLine("The car stops");
        }
    }
}

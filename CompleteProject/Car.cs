using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCar
{
    abstract class Car    {

        private string make;
        private int year;
        private string model;

        public string Make
        {
            get { return make; }
            set
            {
                make = value;
            }
        }
        public int Year
        {
            get { return Year; }
            set
            {
                year = value;
            }
        }
        public string Model
        {
            get { return model; }
            set
            {
                model = value;
            }
        }

        public abstract void Run();
        public abstract void Accelerate();
        public abstract void Stop();

        public int Age(int curYear)
        {
            // Calculate Age by substracting Year of the cars from CurrentYear 
            int ageOfCar = curYear - year;
            return ageOfCar;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace understanding_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.make = "Ford";
            myCar.color = "Blue";
            myCar.model = "Ford Ranger";
            myCar.year = 2015;

            Console.WriteLine("I won a {0}, it is {1} in color. " +
                "It's also a {2} model so its market value is roughly about {3:C}",
                myCar.model,
                myCar.color,
                myCar.year,
                myCar.DetermineMarketValue());

            Car myOtherCar = new Car("Toyota", "Prado V8", 2018, "White");

            Console.WriteLine("I won a {0}, it is {1} in color. " +
                "It's also a {2} model so its market value is roughly about {3:C}",
                myOtherCar.model,
                myOtherCar.color,
                myOtherCar.year,
                myOtherCar.DetermineMarketValue());
            Console.ReadLine();
        }
    }

    //create a class that represents cars
    class Car
    {
        //set some simple attributes
        public string make { get; set; }
        public string color { get; set; }
        public int year { get; set; }
        public string model { get; set; }

        public Car()
        {

        }

        public Car(string Make, string Model, int Year, string Color)
        {
            make = Make;
            model = Model;
            year = Year;
            color = Color;
        }

        public decimal DetermineMarketValue()
        {
            decimal carValue;
            if (year < 2008)
            {
                carValue = 500000.0M;
            }
            else
            {
                carValue = 1500000.0M;
            }
         
            return carValue;
        }
    }
}

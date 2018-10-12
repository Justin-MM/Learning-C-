using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqAndCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //add cars to our inventory using an arraylist
            List<Car> carsInventory = new List<Car>() {
                new Car() {make="Toyota", model="Prado V8", year=2017, value=9000000.0M },
                new Car() {make="Isuzu", model="DMAX", year=2018, value=1800000.0M },
                new Car() {make="Toyota", model="Land Cruiser", year=2017, value=9000000.0M },
                new Car() {make="Subaru", model="Imprezza", year=2011, value=1400000.0M },
                new Car() {make="Land Rover", model="Range Rover Sport", year=2015, value=6000000.0M }
            };

            //working with Linq method
            //sort
            var sortedByMake = carsInventory.OrderBy(p => p.make);
            sortedByMake = carsInventory.OrderBy(p => p.model);
            foreach (Car car in sortedByMake)
            {
                Console.WriteLine("{0} {1}", car.make, car.model);
            }

            //filter
            /*
            Console.WriteLine("++++++++ filters +++++++++++");
            var toyotas = carsInventory.Where(p => p.make.ToLower() == "toyota");
            foreach (Car car in toyotas)
            {
                
                Console.WriteLine("{0} {1}", car.make, car.model);
            }
            */



            //working with Linq queries
            Console.WriteLine("+++++++ LINQ QUERIES +++++++");
            //sort
            var sortByMake = from Car car in carsInventory
                             orderby car.make ascending
                             select car;

            foreach (Car car in sortByMake)
            {
                Console.WriteLine("{0} {1}", car.make, car.model);
            }

            //filter
            Console.WriteLine("++++++++ filters +++++++++++");
            var toyota = from Car car in carsInventory
                         where car.make == "Toyota"
                         select car;

            foreach (Car car in toyota)
            {
                Console.WriteLine("{0} {1}", car.make, car.model);
            }

            // dictionaries
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();

            Car car1 = new Car(Make:"Ford", Model: "Ranger", Year: 2015, Value: 2000000.0M);
            Car car2 = new Car(Make: "Nissan", Model: "Murano", Year: 2014, Value: 1400000.0M);
            myDictionary.Add("1", car1);
            myDictionary.Add("2", car2);

            Console.WriteLine("{0} {1} {2:C}", myDictionary["2"].make, myDictionary["2"].model, 
                myDictionary["2"].value);
            Console.ReadLine();
        }
    }
    class Car
    {
        public string make { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public decimal value { get; set; }

        public Car()
        {

        }
        public Car(string Make, string Model, int Year, decimal Value)
        {
            make = Make;
            model = Model;
            year = Year;
            value = Value;
        }
    }
}

using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            InMemoryCarDal inMemoryCarDal = new InMemoryCarDal();
            foreach (var car in inMemoryCarDal.GetAll())
            {
                Console.WriteLine(car.DailyPrice);
            }
            Console.ReadLine();
        }
    }
}

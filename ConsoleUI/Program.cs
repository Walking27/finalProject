using Business.Concrate;
using DataAccess.Concrate.InMemory;
using Entities.Concrate;
using System;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var Car in carManager.GetAll())
            {
                Console.WriteLine(Car.Id);
            }
        }
    }
}


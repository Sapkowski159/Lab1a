using Lab1a.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;



namespace Lab1a.Data
{
    public class DealershipMgr
    {
        private static Lab1aContext _context;
        public DealershipMgr()
        {
            var options = new DbContextOptionsBuilder<Lab1aContext>()
                .UseInMemoryDatabase(databaseName: "DealershipMgrDb").Options;

            _context = new Lab1aContext(options);
            Car car1 = new Car { Make = "Toyota", Model = "Corolla", Color = "Blue", Year = 2011, VIN = "123" };
            Car car2 = new Car { Make = "Tesla", Model = "S", Color = "Black", Year = 2019, VIN = "456" };
            Car car3 = new Car { Make = "VW", Model = "Golf", Color = "Yellow", Year = 2012, VIN = "789" };
            Car car4 = new Car { Make = "Mazda", Model = "Mazda3", Color = "Purple", Year = 2010, VIN = "987" };

            _context.AddRange(car1, car2, car3, car4);
             _context.SaveChangesAsync();
        }

        public IEnumerable<Car> GetCars()
        {
            return _context.Car; ;
        }
        // GET: api/CarsApi/5
        [HttpGet("{id}")]
        public Car GetCar(string id)
        {
            var car = _context.Car.Find(id);

            if (car == null)
            {
                return null;
            }

            return car;
        }

        // DELETE: api/CarsApi/5
        [HttpDelete("{id}")]
        public Car DeleteCar(string id)
        {
            var car =  _context.Car.Find(id);
            if (car == null)
            {
                return null ;
            }

            _context.Remove(car);
             _context.SaveChangesAsync();

            return car;
        }

    }
}

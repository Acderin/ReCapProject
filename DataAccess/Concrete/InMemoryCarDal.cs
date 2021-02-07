using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : IInMemoryCarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{ Id=1, BrandId=1, ColorId=1, DailyPrice=80, ModelYear=1990, Description="Description"},
                new Car{ Id=2, BrandId=2, ColorId=2, DailyPrice=140, ModelYear=2000, Description="Description1"},
                new Car{ Id=3, BrandId=3, ColorId=3, DailyPrice=300, ModelYear=2020, Description="Description2"},

            };

        }
        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }
        public List<Car> GetAll()
        {
            return _cars;
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }
        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

        }
        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);

        }

    }
}

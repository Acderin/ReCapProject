using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        IInMemoryCarDal _inMemoryCarDal;
        public void Add(Car entity)
        {
            if (entity.Name.Length>2 && entity.DailyPrice>0)
            {
                _inMemoryCarDal.Add(entity);
            }
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}

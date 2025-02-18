﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    interface IBrandService  : IServiceBase<Brand>
    {

        List<Brand> GetCarsByBrandId(int id);
    }
}

﻿using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarsManager : ICarsService
    {
        ICarsDal _carsDal;

        public CarsManager(ICarsDal carsDal)
        {
            _carsDal = carsDal;
        }

        public List<Cars> GetAll()
        {
            return _carsDal.GetAll();
        }
    }
}

﻿using Demo.DataAccess.Abstract;
using Demo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:IProductDal
    {
        public List<Product> GetAll()
        {
            return new List<Product>
            {
                new Product
                {
                    Id=1, Name = "Laptop"
                },
                new Product
                {
                    Id=2, Name = "Monitör"
                }
            };
        }
    }
}

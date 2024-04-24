using Demo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();
    }
}

using Demo.Business.Abstract;
using Demo.DataAccess.Abstract;
using Demo.DataAccess.Concrete.EntityFramework;
using Demo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Business.Concrete
{
    public class ProductManager:IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public List<Product> GetAll()
        {
            //İş kodları burada yazılır.
            //    EfProductDal efProductDal = new EfProductDal();
            //    return efProductDal.GetAll();
            //}
            return _productDal.GetAll();
        }
    }

   
}

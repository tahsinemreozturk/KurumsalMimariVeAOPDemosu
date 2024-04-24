using Demo.Business.Abstract;
using Demo.Business.Concrete;
using Demo.DataAccess.Concrete.EntityFramework;
using Demo.DataAccess.Concrete.NHibernate;

public class Program
{
    public static void Main(string[] args)
    {
        IProductService productService = new ProductManager(new NhProductDal());
        foreach (var product in productService.GetAll())
        {
            Console.WriteLine(product.Name);
        }

    }
}
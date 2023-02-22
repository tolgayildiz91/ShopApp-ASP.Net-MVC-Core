using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetProductsByCategory(string category);
        Product GetById(int id);
        Product GetProductDetails(int id);
        void Create(Product entity);
        void Delete(Product entity);
        void Update(Product entity);


    }
}

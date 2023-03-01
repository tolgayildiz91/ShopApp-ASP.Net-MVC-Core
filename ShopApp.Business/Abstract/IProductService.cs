using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Business.Abstract
{
    public interface IProductService:IValidator<Product>
    {
        List<Product> GetAll();
        List<Product> GetProductsByCategory(string category, int page,int pageSize);
        Product GetById(int id);
        Product GetProductDetails(int id);
        bool Create(Product entity);
        void Delete(Product entity);
        void Update(Product entity);
        int GetCountByCategory(string category);
        Product GetByIdWithCategories(int id);
        void Update(Product entity, int[] categoryIds);
    }
}

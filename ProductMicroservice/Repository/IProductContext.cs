using ProductMicroservice.Model;
using System.Collections.Generic;

namespace ProductMicroservice.Repository
{
    public interface IProductContext
    {
        IEnumerable<Product> GetProducts();
        Product GetProductByID(int ProductId);
        void InsertProduct(Product product);
        void DeleteProduct(int Productid);
        void UpdateProduct(Product Product);
        void BuySomething(Product product);
        void UpdateStockNumber(Product product);

        void Save();
    }
}
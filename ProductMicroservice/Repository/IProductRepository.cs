using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductMicroservice.Model;

namespace ProductMicroservice.Repository
{
    interface IProductRepository 
    {
        IEnumerable<Product> GetProducts();
        Product GetProductByID(int ProductId);
        void InsertProduct(Product product);
        void DeleteProduct(int Productid);
        void UpdateProduct(Product Product);
        void Save();
    }
}

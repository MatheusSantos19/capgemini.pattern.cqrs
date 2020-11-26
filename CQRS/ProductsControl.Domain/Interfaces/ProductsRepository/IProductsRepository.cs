using ProductsControl.Domain.Products;
using System;
using System.Collections.Generic;
using System.Text;



namespace ProductsControl.Domain.Interfaces.ProductsRepository
{
    public interface IProductsRepository
    {
        Product Get(int id);
        void Post(Product products);
    }
}

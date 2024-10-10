using System.Collections.Generic;
using System.Linq;
using WpfApp1.Model;

namespace WpfApp1.Repository
{
    internal class ProductRepository : IProductRepository
    {
        private ICollection<ProductModel> productModels = new List<ProductModel>(
            Enumerable.Range(0, 5).Select(x => new ProductModel
            {
                ProductId = x,
                ProductName = "Product" + x,
                UnitPrice = x * x
            }));

        public ICollection<ProductModel> GetAllProducts()
        {
            return productModels;
        }

        public ProductModel GetProductByName(string name)
        {
            return productModels.FirstOrDefault(x => x.ProductName == name);
        }
    }
}

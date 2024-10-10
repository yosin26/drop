using System.Collections.Generic;
using WpfApp1.Model;

namespace WpfApp1.Repository
{
    public interface IProductRepository
    {
        ICollection<ProductModel> GetAllProducts();
        ProductModel GetProductByName(string name);
    }
}

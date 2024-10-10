using System.Collections.ObjectModel;
using System.Windows.Input;
using WpfApp1.Command;
using WpfApp1.Model;
using WpfApp1.Repository;

namespace WpfApp1.ViewModel
{
    public class ProductViewModel : Notifier
    {
        private ObservableCollection<ProductModel> products;
        public ObservableCollection<ProductModel> Products => products;

        private ProductModel _selectProduct;
        public ProductModel SelectProduct
        {
            get => _selectProduct;
            set => SetProperty(ref _selectProduct, value);
        }

        private ProductModel currentProduct;
        public ProductModel CurrentProduct
        {
            get => currentProduct;
            set => SetProperty(ref currentProduct, value);
        }

        public ProductViewModel(IProductRepository productRepository)
        {
            products = new ObservableCollection<ProductModel>(productRepository.GetAllProducts());
        }

        private ICommand _getProductCommand;
        public ICommand GetProductCommand =>
            _getProductCommand = new RelayCommand(param => GetProduct());

        private ICommand _saveProductCommand;
        public ICommand SaveProductCommand =>
            _saveProductCommand = new RelayCommand(param => SaveProduct(), param => CurrentProduct != null);

        private void GetProduct()
        {
            if (SelectProduct != null)
            {
                CurrentProduct = new ProductModel
                {
                    ProductName = SelectProduct.ProductName,
                    UnitPrice = SelectProduct.UnitPrice,
                    ProductId = SelectProduct.ProductId
                };
            }
        }

        private void SaveProduct()
        {
            // Сохранение продукта
        }
    }
}

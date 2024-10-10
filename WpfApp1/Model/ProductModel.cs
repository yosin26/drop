using WpfApp1.ViewModel;

namespace WpfApp1.Model
{
    public class ProductModel : Notifier
    {
        private int _productId;
        public int ProductId
        {
            get => _productId;
            set => SetProperty(ref _productId, value);
        }

        private string _productName;
        public string ProductName
        {
            get => _productName;
            set => SetProperty(ref _productName, value);
        }

        private decimal _unitPrice;
        public decimal UnitPrice
        {
            get => _unitPrice;
            set => SetProperty(ref _unitPrice, value);
        }
    }
}

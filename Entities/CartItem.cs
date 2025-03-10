namespace E_Ticaret_WebAssembly.Entities
{
    public class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        public CartItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
            TotalPrice = Quantity * Product.Fiyat;
        }
        public void AddQuantity(int value)
        {
            Quantity += value;
            TotalPrice = Quantity * Product.Fiyat;
        }
        public void UpdateQuantity(int value)
        {
            Quantity = value;
            TotalPrice = Quantity * Product.Fiyat;
        }
        public void UpdateProductPrice(decimal value)
        {
            Product.Fiyat = value;
            TotalPrice = Quantity * Product.Fiyat;
        }
    }
}

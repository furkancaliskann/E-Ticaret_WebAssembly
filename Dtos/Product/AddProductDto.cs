namespace E_Ticaret_WebAssembly.Dtos.Product
{
    public class AddProductDto
    {
        public string UrunKodu { get; set; } = string.Empty;
        public string UrunAdi { get; set; } = string.Empty;
        public decimal Fiyat { get; set; }
    }
}

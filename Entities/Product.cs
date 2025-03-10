using System.ComponentModel.DataAnnotations.Schema;

namespace E_Ticaret_WebAssembly.Entities
{
    [Table("Urun")]
    public class Product
    {
        public int Id { get; set; }
        public string UrunKodu { get; set; } = string.Empty;
        public string UrunAdi { get; set; } = string.Empty;
        public decimal Fiyat { get; set; }
        public bool IsDeleted { get; set; }
    }
}

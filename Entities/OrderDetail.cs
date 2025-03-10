using System.ComponentModel.DataAnnotations.Schema;

namespace E_Ticaret_WebAssembly.Entities
{
    [Table("SiparisDetay")]
    public class OrderDetail
    {
        public int Id { get; set; }
        public int SiparisId { get; set; }  // Foreign Key
        public int UrunId { get; set; }     // Foreign Key
        public int Miktar { get; set; }
        public decimal Fiyat { get; set; }
    }
}

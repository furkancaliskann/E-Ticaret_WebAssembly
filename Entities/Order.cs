using System.ComponentModel.DataAnnotations.Schema;

namespace E_Ticaret_WebAssembly.Entities
{
    [Table("Siparis")]
    public class Order
    {
        public int Id { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public int KullaniciId { get; set; } // Foreign Key
    }
}

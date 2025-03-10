using System.ComponentModel.DataAnnotations.Schema;

namespace E_Ticaret_WebAssembly.Entities
{
    [Table("Kullanici")]
    public class User
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; } = string.Empty;
        public byte[] Parola { get; set; } = Array.Empty<byte>();
        public string Rol { get; set; } = string.Empty;
    }
}

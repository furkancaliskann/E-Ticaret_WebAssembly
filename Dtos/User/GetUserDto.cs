namespace E_Ticaret_WebAssembly.Dtos.User
{
    public class GetUserDto
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; } = string.Empty;
        public string Rol { get; set; } = string.Empty;
    }
}

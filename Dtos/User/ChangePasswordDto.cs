namespace E_Ticaret_WebAssembly.Dtos.User
{
    public class ChangePasswordDto
    {
        public string KullaniciAdi { get; set; } = string.Empty;
        public string EskiParola { get; set; } = string.Empty;
        public string YeniParola { get; set; } = string.Empty;
    }
}

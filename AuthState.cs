using E_Ticaret_WebAssembly.Dtos;
using E_Ticaret_WebAssembly.Dtos.User;
using Microsoft.JSInterop;
using System.Net.Http.Json;
using System.Text.Json;

namespace E_Ticaret_WebAssembly
{
    public class AuthState
    {
        private readonly IJSRuntime _jsRuntime;
        private readonly HttpClient _httpClient;

        public event Action? OnLogin;
        public event Action? OnLogout;

        public AuthState(IJSRuntime jsRuntime, HttpClient httpClient)
        {
            _jsRuntime = jsRuntime;
            _httpClient = httpClient;
        }

        public async Task MarkUserAsAuthenticated(string username, string password)
        {
            await _jsRuntime.InvokeVoidAsync("localStorage.setItem", "Username", username);
            await _jsRuntime.InvokeVoidAsync("localStorage.setItem", "Password", password);
            OnLogin?.Invoke();
        }
        public async Task MarkUserAsLoggedOut()
        {
            await _jsRuntime.InvokeVoidAsync("localStorage.removeItem", "Username");
            await _jsRuntime.InvokeVoidAsync("localStorage.removeItem", "Password");
            OnLogout?.Invoke();
        }
        public async Task<GetUserDto?> GetAuthenticationStateAsync()
        {
            var username = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", "Username");
            var password = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", "Password");

            if (username == null || password == null) return null;

            var loginUserDto = new LoginUserDto
            {
                KullaniciAdi = username,
                Parola = password
            };

            try
            {
                var response = await _httpClient.PostAsJsonAsync("https://localhost:7144/api/users/login", loginUserDto);

                var result = await response.Content.ReadFromJsonAsync<Result>();

                if (result?.StatusCode == StatusCodeEnum.Ok && result.Data != null)
                {
                    var userDto = JsonSerializer.Deserialize<GetUserDto>(result.Data.ToString()!, 
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                    return userDto;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Bir hata oluştu: {ex.Message}");
                return null;
            }
        }
    }
}


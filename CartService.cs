using E_Ticaret_WebAssembly.Entities;
using Microsoft.JSInterop;
using System.Text.Json;

namespace E_Ticaret_WebAssembly
{
    public class CartService
    {
        private readonly IJSRuntime _jsRuntime;

        public CartService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task SaveCartToLocalStorage(string userName, List<CartItem> cartList)
        {
            await _jsRuntime.InvokeVoidAsync("localStorage.setItem", "cart_" + userName, JsonSerializer.Serialize(cartList));
        }
        public async Task<List<CartItem>?> LoadCartFromLocalStorage(string userName)
        {
            try
            {
                var cartJson = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", "cart_" + userName);

                if (string.IsNullOrEmpty(cartJson))
                {
                    return new List<CartItem>();
                }

                return JsonSerializer.Deserialize<List<CartItem>>(cartJson) ?? new List<CartItem>();
            }
            catch (Exception)
            {
                return new List<CartItem>();
            }
        }
    }
}

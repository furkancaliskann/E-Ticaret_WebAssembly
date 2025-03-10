namespace E_Ticaret_WebAssembly.Dtos.Order
{
    public class AddOrderDto
    {
        public int UserId { get; set; }
        public List<OrderProductDto> Products { get; set; }
    }
}

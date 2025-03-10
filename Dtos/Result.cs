namespace E_Ticaret_WebAssembly.Dtos
{
    public class Result
    {
        public StatusCodeEnum StatusCode { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;
        public object? Data { get; set; }
    }

    public enum StatusCodeEnum
    {
        Ok,
        NoContent,
        NotFound,
        BadRequest,
        Conflict,
        Unauthorized,
        ServerError,
    }
}

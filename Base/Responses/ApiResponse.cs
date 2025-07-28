namespace Solus.Microservice.Base.Responses
{
    public class ApiResponse<T>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
        public string Error { get; set; }
        public string Message { get; set; }

        public ApiResponse(bool success, T data, string error = null, string message = null)
        {
            Success = success;
            Data = data;
            Error = error;
            Message = message;
        }
    }
}
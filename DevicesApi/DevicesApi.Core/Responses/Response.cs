namespace DevicesApi.Core.Responses
{
    public class Response<T>
    {
        public bool IsSuccess { get; set; } = false; // zero trust policy
        public string Message { get; set; } = "Error";
        public T? Data { get; set; }

    }
}

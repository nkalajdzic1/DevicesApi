namespace DevicesApi.Core.Responses
{
    public class Response<T>
    {
        public T? Data { get; set; }
        public int StatusCode { get; set; }
    }
}

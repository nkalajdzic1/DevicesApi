using DevicesApi.Core.Constants;
using Microsoft.AspNetCore.Http;

namespace DevicesApi.Core.Classes
{
    public class Helper
    {
        public static void AddResponseHeader(IHttpContextAccessor contextAccessor, string key, string value)
        {
            contextAccessor.HttpContext.Response.Headers.Add(key, value);
        }

        public static void AddXTotalCount(IHttpContextAccessor contextAccessor, string value)
        {
            AddResponseHeader(contextAccessor, Headers.XTotalCount, value);
        }
    }
}

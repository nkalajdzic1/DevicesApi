using DevicesApi.Core.Interfaces;
using DevicesApi.Core.Responses;

namespace DevicesApi.Infrastructure.Services
{
    public class RandomService : IRandomService
    {
        public RandomService()
        {
            // initialize attributes from the service here via dependency injection
        }

        /// <summary>
        /// function that returns 'Hello', example of a service
        /// </summary>
        /// <returns></returns>
        public Response<string> GetRandom()
        {
            return new()
            {
                IsSuccess = true,
                Message = "Success",
                Data = "Hello"
            };
        }

        /// <summary>
        ///     returns string 'Hello' with id appended to it (id is from request)
        /// </summary>
        /// <param name="id"> id param from request </param>
        /// <returns> 'Hello' string with appended id </returns>
        public Response<string> GetRandomById(int id)
        {
            return new()
            {
                IsSuccess = true,
                Message = "Success",
                Data = $"Hello {id}"
            };
        }

    }
}

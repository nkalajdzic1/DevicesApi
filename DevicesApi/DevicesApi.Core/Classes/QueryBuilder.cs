namespace DevicesApi.Core.Classes
{
    public class QueryBuilder
    {
        public static void AddPagination<T>(int pageNumber, int pageSize, ref IQueryable<T> query)
        {
            query = query.Skip((pageNumber - 1) * pageSize)
                         .Take(pageSize);
        }
    }
}

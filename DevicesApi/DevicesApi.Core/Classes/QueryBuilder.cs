using DevicesApi.Core.Enums;

namespace DevicesApi.Core.Classes
{
    public class QueryBuilder
    {
        /// <summary>
        /// Query builder to add pagination to the query
        /// </summary>
        /// <typeparam name="T"> entity type </typeparam>
        /// <param name="query"> entity queryable type </param>
        /// <param name="pageNumber"> page number </param>
        /// <param name="pageSize"> page size </param>
        public static void AddPagination<T>(ref IQueryable<T> query, int pageNumber = 1, int pageSize = 10)
        {
            query = query.Skip((pageNumber - 1) * pageSize)
                         .Take(pageSize);
        }

        /// <summary>
        /// Query builder to add sorting to the query
        /// </summary>
        /// <typeparam name="T"> entity type </typeparam>
        /// <param name="query"> entity queryable type </param>
        /// <param name="order"> property on which the ordering will be executed </param>
        /// <param name="direction"> type of ordering - ascending or descending </param>
        /// <exception cref="ArgumentException"></exception>
        public static void AddSorting<T>(ref IQueryable<T> query, string order = "", SortOrder direction = SortOrder.Asc)
        {
            if (!query.Any() || string.IsNullOrWhiteSpace(order)) return;

            try
            {
                var property = DynamicExpressions.DynamicExpressions.GetPropertyGetter<T>(order);
                query = direction == SortOrder.Asc ? query.OrderBy(property) : query.OrderByDescending(property);
            }
            catch
            {
                throw new ArgumentException($"Property {order} does not exist");
            }
        }
    }
}

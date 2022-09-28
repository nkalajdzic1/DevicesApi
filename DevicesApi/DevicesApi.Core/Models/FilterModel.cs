using DevicesApi.Core.Enums;

namespace DevicesApi.Core.Models
{
    // add filtering, sorting, search criterias and etc.
    public class FilterModel : PaginationModel
    {
        public SortOrder Order { get; set; } = SortOrder.Asc;
        
        public string OrderBy { get; set; } = string.Empty;
    }
}

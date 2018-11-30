namespace XmlComments.Models
{
    public class PagingParams
    {
        /// <summary>
        /// Pagination page number
        /// </summary>
        /// <example>5</example>
        public int PageNo { get; set; }

        /// <summary>
        /// Pagination page size
        /// </summary>
        /// <example>20</example>
        public int PageSize { get; set; }
    }
}

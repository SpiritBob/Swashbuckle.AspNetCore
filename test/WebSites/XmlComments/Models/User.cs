namespace XmlComments.Models
{
    /// <summary>
    /// A user
    /// </summary>
    public class User
    {
        /// <summary>
        /// Unique ID
        /// </summary>
        /// <example>123</example>
        public int Id { get; }

        /// <summary>
        /// Unique username
        /// </summary>
        /// <example>johnsmith</example>
        public string Username { get; set; }
    }
}

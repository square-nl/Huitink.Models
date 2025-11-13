namespace Huitink.Models
{
    /// <summary>
    /// Represents a channel with Id, Title, and Description.
    /// </summary>
    public class Channel
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
    }
}
namespace MiniMfs.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Phone { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string PinHash { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public Account? Account { get; set; }
    }
}

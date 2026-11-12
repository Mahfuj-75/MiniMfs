namespace MiniMfs.Models
{
    public class Account
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }

        public decimal Balance { get; set; }

        public User? User { get; set; }
    }
}

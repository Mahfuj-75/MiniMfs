namespace MiniMfs.Models
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public TransactionType Type { get; set; }
        public Guid? FromAccountId { get; set; }
        public Guid? ToAccountId { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}

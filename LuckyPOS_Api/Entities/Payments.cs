namespace LuckySystem_Api.Entities
{
    public class Payments
    {
        public int Id { get; set; }
        public DateTime DatePay { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; }
        public decimal TotalAmmount { get; set; }

    }
}

namespace Assignment3.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Products { get; set; }
        public DateTime OrderDate { get; set; }
    }
}

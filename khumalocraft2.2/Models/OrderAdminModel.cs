namespace khumalocraft2._2.Models
{
    public class OrderAdminModel
    {
        
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string UserEmail { get; set; }
        public string? Status { get; set; }
    }
}

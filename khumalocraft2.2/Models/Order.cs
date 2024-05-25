using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace khumalocraft2._2.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public string UserId { get; set; }

        public DateTime OrderDate { get; set; }

        public string? Status { get; set; }

        public virtual ICollection<Transactions> Transaction { get; set; } = new List<Transactions>();

        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }
    }
}

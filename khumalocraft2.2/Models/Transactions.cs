using System.ComponentModel.DataAnnotations;

namespace khumalocraft2._2.Models
{
    public class Transactions
    {
        [Key]
        public int TransactionsId { get; set; }

        public int OrderId { get; set; }

        public int ProductId { get; set; }


        public virtual Order Order { get; set; } = null!;

        public virtual Product Product { get; set; } = null!;

    }
}

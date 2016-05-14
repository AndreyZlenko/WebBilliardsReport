using System.ComponentModel.DataAnnotations;

namespace BilliardsReport.Domain.Models
{
    public class DiscountCard
    {
        [Key]
        public int id { get; set; }

        public int CardId { get; set; }

        public bool Blocked { get; set; }

        [StringLength(20)]
        public string FirstName { get; set; }

        [StringLength(20)]
        public string LastName { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        public int Discount { get; set; }

        [Required]
        public int GameHallId { get; set; }
    }
}

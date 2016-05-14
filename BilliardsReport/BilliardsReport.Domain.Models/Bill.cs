using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BilliardsReport.Domain.Models
{
    public class Bill
    {
        [Key]
        public int id { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime ElapsedTime { get; set; }

        public int Total { get; set; }

        [Required]
        public int DiscountCardId { get; set; }

        [ForeignKey("DiscountCardId")]
        public virtual DiscountCard DiscountCard { get; set; }

        [Required]
        public int TableId { get; set; }
    }
}

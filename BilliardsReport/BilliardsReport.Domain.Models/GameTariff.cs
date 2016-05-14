using System;
using System.ComponentModel.DataAnnotations;

namespace BilliardsReport.Domain.Models
{
    public class GameTariff
    {
        [Key]
        public int id { get; set; }

        [StringLength(20)]
        public string Type { get; set; }

        public DateTime SatrtTime { get; set; }

        public DateTime EndTime { get; set; }

        public int Discount { get; set; }

        [Required]
        public int TableCategoryId { get; set; }
    }
}

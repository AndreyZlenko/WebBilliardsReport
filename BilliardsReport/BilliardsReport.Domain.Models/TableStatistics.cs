using System;
using System.ComponentModel.DataAnnotations;

namespace BilliardsReport.Domain.Models
{
    public class TableStatistics
    {
        [Key]
        public int id { get; set; }

        public DateTime Date { get; set; }

        public DateTime MorningElapsedTime { get; set; }

        public DateTime DayElapsedTime { get; set; }

        public DateTime EveningElapsedTime { get; set; }

        [Required]
        public int TableId { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace BilliardsReport.Domain.Models
{
    public class HallStatistics
    {
        [Key]
        public int id { get; set; }

        public DateTime Date { get; set; }

        public int TotalOfWorkShift { get; set; }

        public int TotalOfDiscount { get; set; }

        [Required]
        public int GameHallId { get; set; }
    }
}

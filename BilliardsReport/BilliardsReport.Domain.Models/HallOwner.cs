using System;
using System.ComponentModel.DataAnnotations;

namespace BilliardsReport.Domain.Models
{
    public class HallOwner
    {
        [Key]
        public int Id { get; set; }

        public Guid Owner { get; set; }

        [Required]
        public int GameHallId { get; set; }
    }
}

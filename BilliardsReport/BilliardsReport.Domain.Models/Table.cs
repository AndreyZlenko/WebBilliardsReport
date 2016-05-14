using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BilliardsReport.Domain.Models
{
    public class Table
    {
        [Key]
        public int id { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [ForeignKey("TableId")]
        public virtual ICollection<Bill> BillsList { get; set; }

        [ForeignKey("TableId")]
        public virtual ICollection<TableStatistics> Statistics { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual TableCategory Category { get; set; }

        [Required]
        public int GameHallId { get; set; }
    }
}

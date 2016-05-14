using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BilliardsReport.Domain.Models
{
    public class GameHall
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("GameHallId")]
        public virtual ICollection<HallOwner> HallOwners { get; set; }

        [ForeignKey("GameHallId")]
        public virtual ICollection<Table> GameTables { get; set; }

        [ForeignKey("GameHallId")]
        public virtual ICollection<DiscountCard> DiscountCards { get; set; }

        [ForeignKey("GameHallId")]
        public virtual ICollection<HallStatistics> HallStatistics { get; set; }
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BilliardsReport.Domain.Models
{
    public class TableCategory
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("TableCategoryId")]
        public List<GameTariff> GameTariffs { get; set; }
    }
}

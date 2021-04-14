using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PizzaBox.Storing.Entities
{
    public partial class PizzaStore
    {
        [Key]
        [Column("id", TypeName = "numeric(18, 0)")]
        public decimal Id { get; set; }
        [Column("stores")]
        [StringLength(50)]
        public string Stores { get; set; }
        [Column("orders")]
        [StringLength(50)]
        public string Orders { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PizzaBox.Storing.Entities
{
    public partial class PizzaTopping
    {
        [Key]
        [Column("id", TypeName = "numeric(18, 0)")]
        public decimal Id { get; set; }
        [StringLength(50)]
        public string Toppings { get; set; }
        [Column(TypeName = "smallmoney")]
        public decimal? Price { get; set; }
    }
}

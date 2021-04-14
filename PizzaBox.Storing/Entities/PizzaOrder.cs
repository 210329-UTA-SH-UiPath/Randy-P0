using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PizzaBox.Storing.Entities
{
    [Table("PizzaOrder")]
    public partial class PizzaOrder
    {
        [Key]
        [Column("id", TypeName = "numeric(18, 0)")]
        public decimal Id { get; set; }
        [Required]
        [Column("store")]
        [StringLength(50)]
        public string Store { get; set; }
        [Required]
        [Column("pizzas")]
        [StringLength(50)]
        public string Pizzas { get; set; }
        [Required]
        [Column("orders")]
        [StringLength(50)]
        public string Orders { get; set; }
        [Column("totalprice", TypeName = "smallmoney")]
        public decimal Totalprice { get; set; }
        [Required]
        [Column("customer")]
        [StringLength(50)]
        public string Customer { get; set; }
    }
}

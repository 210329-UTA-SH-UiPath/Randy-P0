using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PizzaBox.Storing.Entities
{
    [Keyless]
    [Table("PizzaBuild")]
    public partial class PizzaBuild
    {
        [Column("id")]
        public int Id { get; set; }
        [StringLength(50)]
        public string PizzaType { get; set; }
        [StringLength(50)]
        public string Crust { get; set; }
        [StringLength(50)]
        public string Size { get; set; }
        public string Toppings { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? Price { get; set; }
    }
}

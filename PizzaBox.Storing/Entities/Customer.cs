using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PizzaBox.Storing.Entities
{
    [Table("Customer")]
    public partial class Customer
    {
        [Key]
        [Column("id", TypeName = "numeric(18, 0)")]
        public decimal Id { get; set; }
        [StringLength(50)]
        public string CustomerName { get; set; }
    }
}

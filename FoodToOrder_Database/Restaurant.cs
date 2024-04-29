using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FoodToOrder_Database;

[Keyless]
[Table("Restaurant")]
public partial class Restaurant
{
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string RestaurantName { get; set; } = null!;

    [Column("ROpen")]
    public bool Ropen { get; set; }

    public int UserId { get; set; }
}

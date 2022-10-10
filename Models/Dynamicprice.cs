using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DynamicPrice.Models
{
    [Keyless]
    [Table("Dynamicprice")]
    public partial class Dynamicprice
    {
        [Column("boxid")]
        [StringLength(200)]
        [Unicode(false)]
        public string? Boxid { get; set; }
        [Column("box_name")]
        [StringLength(1000)]
        [Unicode(false)]
        public string? BoxName { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Category { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Stock { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? SellCount { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? BuyCount { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Sell { get; set; }
        [Column("cashbuyprice")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Cashbuyprice { get; set; }
        [Column("exchangeprice")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Exchangeprice { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? PrevPrice { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Datadt { get; set; }
        [Column("Column 11")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Column11 { get; set; }
    }
}

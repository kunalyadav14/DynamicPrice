using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DynamicPrice.Models
{
    
    [Table("Dynamicprice")]
    public partial class Dynamicprice
    {
        [StringLength(50)]
        [Unicode(false)]
        public string? Sno { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? BoxId { get; set; }
        [Column("Box_Name")]
        [StringLength(500)]
        [Unicode(false)]
        public string? BoxName { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Category { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? TotalStock { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Brand { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? CashBuyPrice { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? ExchangePrice { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? SellPrice { get; set; }
        [Column("P1SellPrice")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P1sellPrice { get; set; }
        [Column("P2SellPrice")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P2sellPrice { get; set; }
        [Column("p1_dt")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P1Dt { get; set; }
        [Column("p2_dt")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P2Dt { get; set; }
        [Column("p3_dt")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P3Dt { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? SellQty { get; set; }
        [Column("P1SellQty")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P1sellQty { get; set; }
        [Column("P2SellQty")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P2sellQty { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? BuyQty { get; set; }
        [Column("P1BuyQty")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P1buyQty { get; set; }
        [Column("P2BuyQty")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P2buyQty { get; set; }
        [Column("datadt")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Datadt { get; set; }
        [Column("p1_date")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P1Date { get; set; }
        [Column("p2_date")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P2Date { get; set; }
        [Column("p3_date")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P3Date { get; set; }
        [Column("p1_days")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P1Days { get; set; }
        [Column("p2_days")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P2Days { get; set; }
        [Column("P1SellRatio")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P1sellRatio { get; set; }
        [Column("P2SellRatio")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P2sellRatio { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? SellRatio { get; set; }
        [Column("P1BuyRatio")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P1buyRatio { get; set; }
        [Column("P2BuyRatio")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P2buyRatio { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? BuyRatio { get; set; }
        [Column("P1SellPriceDelta")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P1sellPriceDelta { get; set; }
        [Column("P2SellPriceDelta")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P2sellPriceDelta { get; set; }
        [Column("P1SellQtyDelta")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P1sellQtyDelta { get; set; }
        [Column("P2SellQtyDelta")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P2sellQtyDelta { get; set; }
        [Column("P1BuyQtyDelta")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P1buyQtyDelta { get; set; }
        [Column("P2BuyQtyDelta")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P2buyQtyDelta { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? CategoryCode { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? BrandCode { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? PricingModel { get; set; }
        [Column("Pricing_Delta")]
        [StringLength(50)]
        [Unicode(false)]
        public string? PricingDelta { get; set; }
        [Column("MLPredicted")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Mlpredicted { get; set; }
        [Column("TFPredicted")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Tfpredicted { get; set; }
    }
}

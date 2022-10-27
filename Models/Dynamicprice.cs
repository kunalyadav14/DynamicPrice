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
        public string? Box_Name { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Category { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? TotalStock { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string?PredictSellPrice { get; set; }
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
        public string?p1_dt { get; set; }
        [Column("p2_dt")]
        [StringLength(50)]
        [Unicode(false)]
        public string? p2_dt { get; set; }
        [Column("p3_dt")]
        [StringLength(50)]
        [Unicode(false)]
        public string? p3_dt { get; set; }
        [Column("p4_dt")]
        [StringLength(50)]
        [Unicode(false)]
        public string? p4_dt { get; set; }
        [Column("p5_dt")]
        [StringLength(50)]
        [Unicode(false)]
        public string? p5_dt { get; set; }
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
        [Column("P3SellQty")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P3sellQty { get; set; }
        [Column("P4SellQty")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P4sellQty { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? BuyQty { get; set; }
        [Column("P1BuyQty")]
        [StringLength(50)]
        [Unicode(false)]
        public string?P1BuyQty { get; set; }
        [Column("P2BuyQty")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P2BuyQty { get; set; }
        [Column("P3BuyQty")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P3BuyQty { get; set; }
        [Column("P4BuyQty")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P4BuyQty { get; set; }
        [Column("datadt")]
        [StringLength(50)]
        [Unicode(false)]
        public string? datadt { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Brand { get; set; }
        [Column("p1_date")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P1_date { get; set; }
        [Column("p2_date")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P2_date { get; set; }
        [Column("p3_date")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P3_date { get; set; }
        [Column("p1_days")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P1_days { get; set; }
        [Column("p2_days")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P2_days { get; set; }
        [Column("P1SellRatio")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P1SellRatio { get; set; }
        [Column("P1BuyRatio")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P1BuyRatio { get; set; }
        [Column("P2SellRatio")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P2SellRatio { get; set; }
        [Column("P2BuyRatio")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P2BuyRatio { get; set; }
        //[Column("P2BuyRatio")]
        //[StringLength(50)]
        //[Unicode(false)]
        //public string? P2buyRatio { get; set; }
        //[StringLength(50)]
        //[Unicode(false)]
        //public string? BuyRatio { get; set; }
        [Column("P1SellPriceDelta")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P1SellPriceDelta { get; set; }
        [Column("P2SellPriceDelta")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P2SellPriceDelta { get; set; }
        [Column("P1SellQtyDelta")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P1SellQtyDelta { get; set; }
        [Column("P2SellQtyDelta")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P2SellQtyDelta { get; set; }
        [Column("P1BuyQtyDelta")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P1BuyQtyDelta { get; set; }
        [Column("P2BuyQtyDelta")]
        [StringLength(50)]
        [Unicode(false)]
        public string? P2BuyQtyDelta { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? CategoryCode { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? BrandCode { get; set; }
        //[StringLength(50)]
        //[Unicode(false)]
        //public string? PricingModel { get; set; }
        //[Column("Pricing_Delta")]
        //[StringLength(50)]
        //[Unicode(false)]
        //public string? PricingDelta { get; set; }
        [Column("PredictedPrice")]
        [StringLength(50)]
        [Unicode(false)]
        public string? PredictedPrice { get; set; }
        [Column("PredictedPrice_ML")]
        [StringLength(50)]
        [Unicode(false)]
        public string? PredictedPrice_ML { get; set; }
    }
}

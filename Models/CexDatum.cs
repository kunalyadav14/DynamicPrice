using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DynamicPrice.Models
{
 
    public partial class CexDatum
    {
        [Column("Column 0")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Column0 { get; set; }
        [Key]
        [Column("boxid")]
        [StringLength(500)]
        [Unicode(false)]
        public string? Boxid { get; set; }
        [Column("box_name")]
        [StringLength(1000)]
        [Unicode(false)]
        public string? BoxName { get; set; }
        [Column("box_category")]
        [StringLength(50)]
        [Unicode(false)]
        public string? BoxCategory { get; set; }
        [Column("stkqty")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Stkqty { get; set; }
        [Column("slsqty")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Slsqty { get; set; }
        [Column("buysqty")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Buysqty { get; set; }
        [Column("cashbuyprice")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Cashbuyprice { get; set; }
        [Column("exchangeprice")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Exchangeprice { get; set; }
        [Column("datadt")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Datadt { get; set; }
        [Column("prevsellprice")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Prevsellprice { get; set; }
        [Column("sellprice")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Sellprice { get; set; }
        [Column("predict_sellprice_standard")]
        [StringLength(50)]
        [Unicode(false)]
        public string? PredictSellpriceStandard { get; set; }
        [Column("predict_sellprice_normalisation")]
        [StringLength(50)]
        [Unicode(false)]
        public string? PredictSellpriceNormalisation { get; set; }
        [Column("predict_sellprice")]
        [StringLength(50)]
        [Unicode(false)]
        public string? PredictSellprice { get; set; }
        [Column("predict-current")]
        [StringLength(50)]
        [Unicode(false)]
        public string? PredictCurrent { get; set; }
    }
}

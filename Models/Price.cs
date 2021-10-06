using System;
using System.Collections.Generic;

#nullable disable

namespace MusicShop.Models
{
    public partial class Price
    {
        public int Xid { get; set; }
        public int InstrumentId { get; set; }
        public int Price1 { get; set; }
        public int? PreferntialPrice { get; set; }
        public DateTime? Year { get; set; }
    }
}

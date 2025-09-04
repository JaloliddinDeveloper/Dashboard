using System;

namespace Dashboard.Models
{
    public class TradeData
    {
        public Guid Id { get; set; }
        public DateTimeOffset Year { get; set; }
        public decimal Export { get; set; }    
        public decimal Import { get; set; }
    }
}

using System;

namespace Dashboard.Models
{
    public class GdpData
    {
        public Guid Id { get; set; }
        public DateTimeOffset Year { get; set; }         
        public decimal Value { get; set; }
    }
}

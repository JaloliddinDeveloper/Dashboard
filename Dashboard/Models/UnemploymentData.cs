using System;

namespace Dashboard.Models
{
    public class UnemploymentData
    {
        public Guid Id { get; set; }
        public DateTimeOffset Year { get; set; }         
        public double Rate { get; set; }
    }
}

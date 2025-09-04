using System;

namespace Dashboard.Models
{
    public class CurrencyRateData
    {
        public Guid Id { get; set; }
        public DateTimeOffset Year { get; set; }
        public decimal UsdToUzs { get; set; }  
        public decimal EurToUzs { get; set; }  
    }
}

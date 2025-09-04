using System;

namespace Dashboard.Models
{
    public class DemographyData
    {
        public Guid Id { get; set; }
        public DateTimeOffset Year { get; set; }
        public long Population { get; set; }      
        public double UrbanPercent { get; set; }  
        public double RuralPercent { get; set; }  
    }
}

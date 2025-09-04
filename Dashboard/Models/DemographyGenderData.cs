using System;

namespace Dashboard.Models
{
    public class DemographyGenderData
    {
        public Guid Id { get; set; }
        public DateTimeOffset Year { get; set; }
        public long Male { get; set; }
        public long Female { get; set; }
    }

}

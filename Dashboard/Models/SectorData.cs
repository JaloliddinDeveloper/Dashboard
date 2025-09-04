using System;

namespace Dashboard.Models
{
    public class SectorData
    {
        public Guid Id { get; set; }
        public DateTimeOffset Year { get; set; }
        public double Agriculture { get; set; }   
        public double Industry { get; set; }      
        public double Services { get; set; }      
    }
}

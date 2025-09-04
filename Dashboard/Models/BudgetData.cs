using System;

namespace Dashboard.Models
{
    public class BudgetData
    {
        public Guid Id { get; set; }
        public DateTimeOffset Year { get; set; }
        public decimal Education { get; set; }      
        public decimal Healthcare { get; set; }     
        public decimal Defense { get; set; }        
        public decimal Infrastructure { get; set; } 
        public decimal Other { get; set; }          
    }
}

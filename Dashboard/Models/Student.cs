using System;

namespace Dashboard.Models
{
    public class Student
    {
        public int Id { get; set; }            
        public string FullName { get; set; }   
        public DateTimeOffset BirthDate { get; set; }
        public string Gender { get; set; }     
        public string Course { get; set; }     
        public int GroupId { get; set; }       
        public double GPA { get; set; }        
        public decimal Balance { get; set; }   
        public bool IsActive { get; set; }     
    }
}

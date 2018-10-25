using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public abstract class Task
    {
        public long Id {get;set;}
        public string Title{get;set;}
        public string Description{get;set;}
        [NotMapped]
        public string[] Answers { get; set; }
        public District District{get;set;}
        public long DistrictId { get; set; } //FK

    }
    
}
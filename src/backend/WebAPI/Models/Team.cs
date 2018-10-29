using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace Models
{
    public class Team
    {
        public long Id{get;set;}
        public string Name{get; set;}

        [ForeignKey("Session")]
        public long SessionId { get; set; }
        [JsonIgnore]
        public Session Session { get; set; }

        public string SessionCode {get; set;}
        [NotMapped]        
        public Color TeamColor{get;set;}
    }
    
}
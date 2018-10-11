using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace Models
{
    public class Team
    {
        public long TeamId{get;set;}
        public long SessionId{get;set;}

        [NotMapped]        
        public Color TeamColor{get;set;}
    }
    
}
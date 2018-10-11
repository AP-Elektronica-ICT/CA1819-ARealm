using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using interfaces;

namespace Models
{
    public class Session
    {
        public long SessionId {get;set;}
        public string SessionCode{get;set;}
        public List<Team> Teams {get;set;}
        public List<District> Districts {get;set;}
        [NotMapped]
        public ISessionState CurrentState{get;set;}
    }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Session;
using Newtonsoft.Json;

namespace Models
{
    // Finite state machine + states voor Session class
    public interface ISessionState
    {
        // Hier komen alle actions die een session kan uitvoeren 
        // voor van state te veranderen
        // Vb.: Active --> Completed als het finaal spel gedaan is
        // en de spelers het finaal spel krijgen te zien.

    }

    public class Active : ISessionState
    {
        private readonly Session session;
        public Active(Session session)
        {
            this.session = session;
        }
    }
    public class Completed : ISessionState
    {
        private readonly Session session;
        public Completed(Session session)
        {
            this.session = session;
        }
    }
    public class Inactive : ISessionState
    {
        private readonly Session session;
        public Inactive(Session session)
        {
            this.session = session;
        }
    }

    public class Setup : ISessionState
    {
        private readonly Session session;
        public Setup(Session session)
        {
            this.session = session;
        }
    }
    public class Session
    {
        public long Id {get;set;}
        public string SessionCode{get;set;}
        [JsonIgnore]
        public ICollection<Team> Teams {get;set;}

        public List<District> Districts {get;set;}

        //String voor state op te slagen:
        public string CurrentStateString{get;set;}
        [NotMapped]
        public ISessionStore CurrentState{get;set;}
    }

}
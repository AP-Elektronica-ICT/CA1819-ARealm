using Models;

namespace interfaces
{
    // Finite state machine + states voor Session class
    public interface ISessionState
    {
        // Hier komen alle actions die een session kan uitvoeren 
        // voor van state te veranderen
        // Vb.: Active --> Completed als het finaal spel gedaan is
        // en de spelers het finaal spel krijgen te zien.
        
    }

    public class Active: ISessionState
    {
        private readonly Session session;
        public Active(Session session)
        {
            this.session = session;
        }
    }
    public class Completed: ISessionState
    {
        private readonly Session session;
        public Completed(Session session)
        {
            this.session = session;
        }
    }
    public class Inactive: ISessionState
    {
        private readonly Session session;
        public Inactive(Session session)
        {
            this.session = session;
        }
    }

    public class Setup: ISessionState
    {
        private readonly Session session;
        public Setup(Session session)
        {
            this.session = session;
        }
    }

}
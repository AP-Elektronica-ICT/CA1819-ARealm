using Models;

namespace interfaces
{

    // Finite state machine + states for District class

    public interface IDistrictState
    {
        //Hier komen alle actions die een district 
        //kan uitvoeren voor van state te veranderen
        //Vb.: Unlocked --> Captured als team het district captured
    }
    public class Unlocked: IDistrictState
    {
        private readonly District district;

        public Unlocked(District district)
        {
            this.district = district;
        }
    }
    
    public class Locked: IDistrictState
    {
        private readonly District district;

        public Locked(District district)
        {
            this.district = district;
        }
    }
    public class Captured: IDistrictState
    {
        private readonly District district;
        public Team Team;
        public Captured(District district)
        {
            this.district = district;
        }
    }


}
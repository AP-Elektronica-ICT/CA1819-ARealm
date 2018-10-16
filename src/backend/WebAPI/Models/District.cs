using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class District
    {
        public long Id{get;set;}
        public Task Task{get;set;}
        public Session Session{get;set;}

        //public long StateId {get;set;}

        //CurrentStateString voor het opslagen van de current state v/h district:
        public string CurrentStateString {get;set;}
        [NotMapped]
        public IDistrictState CurrentState{get;set;}

    }

    public interface IDistrictState
    {
        //Hier komen alle actions die een district 
        //kan uitvoeren voor van state te veranderen
        //Vb.: Unlocked --> Captured als team het district captured
    }
    public class Unlocked : IDistrictState
    {
        private readonly District district;

        public Unlocked(District district)
        {
            this.district = district;
        }
    }

    public class Locked : IDistrictState
    {
        private readonly District district;

        public Locked(District district)
        {
            this.district = district;
        }
    }
    public class Captured : IDistrictState
    {
        private readonly District district;
        public Team Team;
        public Captured(District district)
        {
            this.district = district;
        }
    }

}
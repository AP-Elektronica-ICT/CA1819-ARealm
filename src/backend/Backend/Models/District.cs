using System.ComponentModel.DataAnnotations.Schema;
using interfaces;

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
}
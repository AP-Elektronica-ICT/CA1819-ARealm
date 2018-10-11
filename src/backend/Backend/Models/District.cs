using System.ComponentModel.DataAnnotations.Schema;
using interfaces;

namespace Models
{
    public class District
    {
        public long DistrictId{get;set;}
        public long SessionId{get;set;}
        public Task DistrictTask{get;set;}

        [NotMapped]
        public IDistrictState CurrentState{get;set;}

    }
}
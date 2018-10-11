namespace Models
{
    public abstract class Task
    {
        public long TaskId {get;set;}
        public long DistrictId{get;set;}
        public string Title{get;set;}
        public string Description{get;set;}

    }
    
}
using System.Collections.Generic;
using System.Linq;
using Models;

namespace Repositories
{
    public class DBInitializer
    {
        public static void Initialize(ARealmContext context)
        {
            //create db if not yet exists
            context.Database.EnsureCreated();      

            if(!context.Sessions.Any())
            {

                var task1 = new PhotoTask()
                {
                    Title = "phototask 1",
                    Description = "this is a phototask"
                };
                context.PhotoTasks.Add(task1);

                var task2 = new PhotoTask()
                {
                    Title = "phototask 2",
                    Description = "this is a phototask"
                };
                context.PhotoTasks.Add(task2);

                var task3 = new PhotoTask()
                {
                    Title = "puzzletask 1",
                    Description = "this is a phto"
                };
                context.PhotoTasks.Add(task3);

                var task4 = new PhotoTask()
                {
                    Title = "puzzletask 2",
                    Description = "this is a photo"
                };
                context.PhotoTasks.Add(task4);


                var district1 = new District()
                {
                    Title = "this is locked district 1",
                    Task = task1

                };
                district1.CurrentState = new Locked(district1);
                context.Districts.Add(district1);

                var district2 = new District()
                {
                    Title = "this is locked district 2",
                    Task = task2

                };
                district2.CurrentState = new Locked(district2);
                context.Districts.Add(district2);

                var district3 = new District()
                {
                    Title = "this is locked district 3",
                    Task = task3

                };
                district3.CurrentState = new Locked(district3);
                context.Districts.Add(district3);

                var district4 = new District()
                {
                    Title = "this is locked district 4",
                    Task = task4

                };
                district4.CurrentState = new Locked(district4);
                context.Districts.Add(district4);

                var districtList = new LockedDistricts()
                {
                    Districts = new List<District>()
                };
                districtList.Districts.Add(district1);
                districtList.Districts.Add(district2);
                districtList.Districts.Add(district3);
                districtList.Districts.Add(district4);
                context.LockedDistricts.Add(districtList);
                //save changes to DB
                context.SaveChanges();
            }

            
        }
    }
}
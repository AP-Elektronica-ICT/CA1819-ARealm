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
                var TestSession = new Session()
                {
                    SessionCode = "1234",
                    Districts = new List<District> { },
                };

                var Team1 = new Team()
                {
                    Name =  "team1",
                    Session = TestSession
                    
                };
                 var Team2 = new Team()
                {
                    Name =  "team2",
                    Session = TestSession

                 };
                var Team3 = new Team()
                {
                    Name =  "team3",
                    Session = TestSession
                    
                };
                var TestDistrict = new District()
                {
                    Session = TestSession,
                };

                var TestPuzzleTask = new PuzzleTask()
                {
                    Question = "Wie is de beste codeur in het ARealm team?",
                    Answer = "Joris niet",
                    Title = "TestPuzzleTask",
                    Description = "PuzzleTask voor te testen :)",
                    District = TestDistrict,
                };
                TestDistrict.Task = TestPuzzleTask;
                TestDistrict.CurrentState = new Unlocked(TestDistrict);



                TestSession.CurrentStateString= "Active";

                context.Sessions.Add(TestSession);
                context.Teams.Add(Team1);
                context.Teams.Add(Team2);
                context.Teams.Add(Team3);

                context.PuzzleTasks.Add(TestPuzzleTask);
                context.Districts.Add(TestDistrict);
                //save changes to DB
                context.SaveChanges();
            }

            
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using interfaces;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Models
{
    public class DBInitializer
    {
        public static void Initialize(CollectionContext context)
        {
            //create db if not yet exists
            context.Database.EnsureCreated();

            if(!context.TodoItems.Any()) //check if database is empty
            {
                var item1 = new TodoItem() // add item
                {
                    Name = "item1"
                };
                
                var item2 = new TodoItem2()// add item
                {
                    Name = "item2"
                };


                context.TodoItems.Add(item1);
                context.TodoItems2.Add(item2);
                //save all the changes to the DB
                context.SaveChanges();         
            }

            if(!context.Sessions.Any())
            {
                var TestSession = new Session
                {
                    SessionCode = "TestCode",
                    Teams = new List<Team>{},
                    Districts =  new List<District>{},
                };
                TestSession.CurrentState= new Active(TestSession);

                context.Sessions.Add(TestSession);
                context.SaveChanges();
            }
        }
    }
}
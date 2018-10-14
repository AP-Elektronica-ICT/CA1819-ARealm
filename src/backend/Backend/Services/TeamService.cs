using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Models;
using Controllers;

namespace Services
{
    public class TeamService
    {
        ARealmContext context;

        public TeamService(ARealmContext _context)
        {
            context = _context;
        }

        // Vergelijkt de sessesioncode van het team met de sessie code's van de betaande sessie's. 
        // Match => voeg het team toe aan de sessie.
        public IActionResult CheckSessionCode(Team team,TeamController controller) 
        {
            List<Session> sessions = context.Sessions.ToList();
            for(int i = 0; i < sessions.Count; i++)
            {
                if(team.SessionCode == sessions[i].SessionCode)
                {
                    team.Session = sessions[i]; 
                    context.Teams.Update(team);
                    context.SaveChanges();
                    return controller.Ok(team);
                }
            } 
            return controller.NotFound();
        }
    }

}
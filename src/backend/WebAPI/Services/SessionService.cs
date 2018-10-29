using System;
using System.Collections.Generic;
using System.Text;
using Repositories;
using Models;

namespace Services
{
    //logic
    public class SessionService
    {
        private SessionRepository _sessionRepository;
        private LockedDistrictsRepository _lockedDistrictsRepository;
        private DistrictRepository _districtRepository;
        private SessionCodeRepository _sessionCodeRepository;
        private TeamRepository _teamRepository;


        public SessionService(SessionRepository sessinoRepository, LockedDistrictsRepository lockedDistrictsRepository, DistrictRepository districtRepository , SessionCodeRepository sessionCodeRepository, TeamRepository teamRepository)
        {
            _sessionRepository = sessinoRepository;
            _lockedDistrictsRepository = lockedDistrictsRepository;
            _districtRepository = districtRepository;
            _sessionCodeRepository = sessionCodeRepository;
            _teamRepository = teamRepository;
        }

        public Session Create(SessionCode code) //create new sessin with code
        {
            _sessionCodeRepository.Post(code);
            var session = new Session()
            {
                Teams = null,
                SessionCode = code,
                CurrentStateString = "active session active!",
                CurrentState = null
            };
            _sessionRepository.Post(session);
            CopyDistricts(session); //copies hardcoded districts no session
            return session;
        }

        public Session Update(Session session) // not used in controller
        {
            return _sessionRepository.Put(session);
        }

        public bool Delete(long id)
        {
            var districtIds = new List<long>();
            foreach(District d in _sessionRepository.Get(id).Districts)
            {
                districtIds.Add(d.Id);
            }
            for(int i = 0; i <districtIds.Count; i++) // delete  districts from session
            {
                _districtRepository.Delete(districtIds[i]);
            }

            var teamIds = new List<long>();
            foreach(Team t in _sessionRepository.Get(id).Teams)
            {
                teamIds.Add(t.Id);
            }
            for (int i = 0; i < teamIds.Count; i++) // delete  teams from session
            {
                _teamRepository.Delete(teamIds[i]);
            }

            return _sessionRepository.Delete(id);
        }

        public List<Session> GetAll()
        {

            return _sessionRepository.GetAll();
        }

        public Session Get(long id)
        {
            return _sessionRepository.Get(id);
        }

        public List<District> CopyDistricts(Session session) //TODO bad code??
        {
            var lockedDistrict = _lockedDistrictsRepository.Get()[0];          
            var newDistricts = new List<District>(lockedDistrict.Districts); // copy wihtout reference
            foreach(District d in newDistricts)
            {
                var district = new District()
                {
                    Task = d.Task,
                    Title = d.Title,
                    CurrentState = d.CurrentState,
                    Session = session
                };
                _districtRepository.Post(district);
            }
            //var newDistricts = new List<District>();

         /*  foreach(District d in oldDistricts)
            {
                var district = new District()
                {
                    Task = d.Task,
                    Title = d.Title,
                    CurrentState = d.CurrentState,
                    Session = session
                };               
                newDistricts.Add(_districtRepository.Post(district));
            } */
            return newDistricts;
        }
    }
}

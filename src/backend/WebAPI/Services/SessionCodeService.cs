using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using Repositories;

namespace Services
{
    //logic
    public class SessionCodeService
    {
        private static Random random;
        private int codeLength;
        private SessionService _sessionService;

        public SessionCodeService(SessionService sessionService)
        {
            _sessionService = sessionService;
            random = new Random();
            codeLength = 16;
        }

        public SessionCode Create()
        {
            var sessionCode = RandomString(codeLength);          
            //create code
            var code = new SessionCode()
            {
                Code = sessionCode
            };
            _sessionService.Create(code); // creates new session with code
            return code; 
        }

        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}

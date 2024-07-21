using DAL.Models;
using DAL.Models.Main;
using DAL.Repositories;
using DAL.Repositories.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class SessionService
    {
        SessionRepository sessionRepository = new SessionRepository();
        public SessionService()
        {
            sessionRepository = new SessionRepository();
        }

        public SessionDto ConvertToDtoSession(Session session)
        {
            SessionDto sessionDto = new SessionDto();
            sessionDto.SessionId = session.SessionId;
            sessionDto.IsLoggedIn = session.IsLoggedIn;
            sessionDto.UserId = session.UserId;

            return sessionDto;
        }
        public int CreateSession(int userId, bool isLoggedIn)
        {
            return sessionRepository.CreateSession(userId, isLoggedIn);
        }

        public void UpdateSession(int sessionId, bool isLoggedIn)
        {
            sessionRepository.UpdateSession(sessionId, isLoggedIn);
        }

        public SessionDto GetSession(int sessionId)
        {
            Session session = sessionRepository.GetSession(sessionId);
            SessionDto sessionDto = ConvertToDtoSession(session);

            return sessionDto;
        }
        public int GetSessionId(int uerId)
        {
            int sessionId = sessionRepository.GetSessionId(uerId);

            return sessionId;
        }
    }
}

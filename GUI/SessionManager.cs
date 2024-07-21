using DTO;
using BLL.Services;
using DAL.Models;

namespace GUI
{
    public static class SessionManager
    {
        private static readonly SessionService sessionService = new SessionService();
        private static int sessionId;
        private static int userId;

        public static void UpdateSession(int session)
        {
            sessionService.UpdateSession(session, true);
        }

        public static int SessionId
        {
            get { return sessionId; }
            set { sessionId = value; }
        }
        public static int GetSessionId()
        {
            return sessionId;
        }
        public static void SetSession(int sessionID)
        {
            sessionId = sessionID;
        }
        public static int GetuUserId(int sessionId)
        {
            var session = sessionService.GetSession(sessionId);
            userId = session.UserId;
            return userId;
        }

        public static (bool IsLoggedIn, int UserId) IsUserLoggedIn(int sessionId)
        {
            SessionDto session = sessionService.GetSession(sessionId);
            bool isLoggedIn = session != null && session.IsLoggedIn == 1;
            int userId = session?.UserId ?? 0;
            return (isLoggedIn, userId);
        }

        public static void Logout(int session)
        {
            sessionService.UpdateSession(session, false);
        }
    }
}
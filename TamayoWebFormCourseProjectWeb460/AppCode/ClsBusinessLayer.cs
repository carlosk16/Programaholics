using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TamayoWebFormCourseProjectWeb460.AppCode
{
    public class ClsBusinessLayer
    {
        public bool CheckUserCredentials(System.Web.SessionState.HttpSessionState currentSession, string username, string password)
        {
            bool isValid = ClsDataLayer.Authentication(username, password);

            currentSession["LockedSession"] = false;

            //saves login attemps
            int totalAttempts = Convert.ToInt32(currentSession["AttemptCount"]) + 1;
            currentSession["AttemptCount"] = totalAttempts;

            //saves user login attemps
            int userAttempts = Convert.ToInt32(currentSession[username]) + 1;
            currentSession[username] = userAttempts;

            //sets limit on user login attempts
            if ((userAttempts >= 3) || (totalAttempts >= 6))
            {
                currentSession["LockedSession"] = true;
                ClsDataLayer.LockUserAccount(username);
            }
            return isValid;
        }
    }
}
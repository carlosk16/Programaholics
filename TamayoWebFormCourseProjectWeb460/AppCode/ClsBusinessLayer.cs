using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TamayoWebFormCourseProjectWeb460.Models;

namespace TamayoWebFormCourseProjectWeb460.AppCode
{
    public class ClsBusinessLayer
    {
        public static UserAccount CheckUserCredentials(System.Web.SessionState.HttpSessionState currentSession, string username, string password)
        {
            UserAccount userAccount = ClsDataLayer.Authentication(username, password);

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
            return userAccount;
        }

       
    }
}
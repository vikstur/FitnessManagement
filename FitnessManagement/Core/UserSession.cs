using System;
using System.Collections.Generic;
using System.Text;
using FitnessManagement.Models;

namespace FitnessManagement.Core
{
    public static class UserSession
    {
        public static  User? CurrentUser { get; set; }

        public static bool IsLoggedIn => CurrentUser != null;

        public static void Logout()
        {
            CurrentUser = null;
        }
    }
}

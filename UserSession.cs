using System;
using System.Collections.Generic;
using System.Text;

namespace HOTEL_RESERVATION
{
    public static class UserSession
    {

        public static bool IsLoggedIn { get; set; } = false;

        public static string CurrentName { get; set; } = "";
        public static string CurrentSurname { get; set; } = "";

        public static string CurrentEmail { get; set; } = "";
        public static string CurrentIdcard { get; set; } = "";

        public static string CurrentContact { get; set; } = "";

    }
}

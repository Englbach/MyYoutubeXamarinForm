using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace Youtube.Helpers
{
    /// <summary>
    /// We will save AccessToken, UserId... to AppSetting after logged in successfully
    /// The application will no longer call the method login again.
    /// </summary>
    public static class Settings
    {

        private static ISettings AppSettings
        {
            get { return CrossSettings.Current; }
        }

        #region Settings Contants

        private const string UserIdKey = "user_id_key";
        private static readonly int UserIdDefault = 0;

        private const string ProfileIdKey = "profile_id_key";
        private static readonly int ProfileIdDefault = 0;

        private const string AccessTokenKey = "access_token_key";
        private static readonly string AcessTokenDefault = string.Empty;

        private const string UwpWindowSizeKey = "uwp_window_size";
        private static readonly string UwpWindowSizeDefault = string.Empty;

        public static int UserId
        {
            get { return AppSettings.GetValueOrDefault(UserIdKey, UserIdDefault); }
            set { AppSettings.AddOrUpdateValue(UserIdKey, value); }
        }

        public static int ProfileId
        {
            get { return AppSettings.GetValueOrDefault(ProfileIdKey, ProfileIdDefault); }
            set { AppSettings.AddOrUpdateValue(ProfileIdKey, value); }
        }

        public static string AccessToken
        {
            get { return AppSettings.GetValueOrDefault(AccessTokenKey, AcessTokenDefault); }
            set { AppSettings.AddOrUpdateValue(AccessTokenKey, value); }
        }

        public static string UwpWindowSize
        {
            get { return AppSettings.GetValueOrDefault(UwpWindowSizeKey, UwpWindowSizeDefault); }
            set { AppSettings.AddOrUpdateValue(UwpWindowSizeKey, value); }
        }

        public static void RemoveUserId()
        {
            AppSettings.Remove(UserIdKey);
        }

        public static void RemoveProfileId()
        {
            AppSettings.Remove(ProfileIdKey);
        }

        public static void RemoveAccessToken()
        {
            AppSettings.Remove(AccessTokenKey);
        }



        #endregion
    }
}

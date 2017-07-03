using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace WhatTheHell
{
    /// <summary>
    /// This is the Settings static class that can be used in your Core solution or in any
    /// of your client applications. All settings are laid out the same exact way with getters
    /// and setters. 
    /// </summary>
    public static class Settings
    {
        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        #region Setting Constants
        const string UserIdKey = "userid";
        static readonly string UserIdDefault = "1";

        const string AuthTokenKey = "authtoken";
        static readonly string AuthTokenDefault = string.Empty;


        static string API_KEY = "ApiKey";
        static string ApiUrlKey = "ApiUrlKey";

        static string ApiKeyDefault = "fe83f3db0a7c4d6d95fb11f58f4a07e1";
        static string ApiUrlDefault = "https://newsapi.org/v1/articles?source=techcrunch&sortBy=latest&apiKey=" + ApiKey;

        #endregion
        public static string ApiKey
        {
            get
            {
                return AppSettings.GetValueOrDefault<string>(API_KEY, ApiKeyDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue<string>(API_KEY, value);
            }
        }
        public static string ApiUrl
        {
            get
            {
                return AppSettings.GetValueOrDefault<string>(ApiUrlKey, ApiUrlDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue<string>(ApiUrlKey, value);
            }
        }

        public static string AuthToken
        {
            get
            {
                return AppSettings.GetValueOrDefault<string>(AuthTokenKey, AuthTokenDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue<string>(AuthTokenKey, value);
            }
        }

        public static bool IsLoggedIn => !string.IsNullOrWhiteSpace(UserId);
        public static string UserId
        {
            get
            {
                return AppSettings.GetValueOrDefault<string>(UserIdKey, UserIdDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue<string>(UserIdKey, value);
            }
        }
    }
}

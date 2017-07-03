using System;
using System.Collections.Generic;

namespace WhatTheHell
{
    public partial class App
    {
        public static bool UseMockDataStore = false;
        //public static string BackendUrl = "http://localhost:5000";

        public static string BackendUrl = Settings.ApiUrl;


        public App()
        {
        }

        public static void Initialize()
        {
            if (UseMockDataStore)
                ServiceLocator.Instance.Register<IDataStore<Item>, MockDataStore>();
            else
                ServiceLocator.Instance.Register<IDataStore<Item>, CloudDataStore>();

#if __IOS__
            ServiceLocator.Instance.Register<IMessageDialog, iOS.MessageDialog>();
#else
            ServiceLocator.Instance.Register<IMessageDialog, Droid.MessageDialog>();
#endif
        }

        public static IDictionary<string, string> LoginParameters => null;
    }
}

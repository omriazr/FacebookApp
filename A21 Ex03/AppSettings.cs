using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace A21_Ex03
{
    public class AppSettings
    {
        public string LastAccessToken { get; set; }

        public bool IfRememberUser { get; set; }

        public static AppSettings Instance = new AppSettings();

        private AppSettings()
        {
            LastAccessToken = null;
            IfRememberUser = false;
        }
    }
}

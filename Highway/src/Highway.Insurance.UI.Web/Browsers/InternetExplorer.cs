﻿using Microsoft.VisualStudio.TestTools.UITesting;

namespace Highway.Insurance.UI.Web.Browsers
{
    public class InternetExplorer : Browser, IBrowser
    {
        public static string Name = "ie";
        
        public InternetExplorer()
            : base(Name, "iexplore", "IEFrame", "Internet Explorer_TridentDlgFrame")
        {
        }
    }
}

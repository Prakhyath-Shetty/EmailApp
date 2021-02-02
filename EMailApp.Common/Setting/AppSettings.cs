using System;
using System.Collections.Generic;
using System.Text;

namespace EMailApp.Common.Setting
{
    public class AppSettings
    {
        public string ConnectionString { get; set; }
        public string Secret { get; set; }
        public TokenSettings TokenSettings { get; set; }
    }
}

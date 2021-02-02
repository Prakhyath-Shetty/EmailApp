using System;
using System.Collections.Generic;
using System.Text;

namespace EMailApp.Common.Setting
{
    public class TokenSettings
    {
        public int SessionExpiryInMinutes { get; set; }
        public int ShortExpiryInMinutes { get; set; }
        public int LongExpiryInMinutes { get; set; }
    }
}

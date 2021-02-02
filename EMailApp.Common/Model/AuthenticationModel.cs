using System;
using System.Collections.Generic;
using System.Text;

namespace EMailApp.Common.Model
{
    public class AuthenticationModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }        
        public int RoleId { get; set; }
        public DateTime TokenExpiryDate { get; set; }
        public string Token { get; set; }
    }
}

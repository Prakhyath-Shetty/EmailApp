using System;
using System.Collections.Generic;
using System.Text;

namespace EMailApp.Common.ViewModel
{
    public class MailViewModel
    {
        public int Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

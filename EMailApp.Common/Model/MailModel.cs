using System;
using System.Collections.Generic;
using System.Text;

namespace EMailApp.Common.Model
{
    public class MailModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
    }
}

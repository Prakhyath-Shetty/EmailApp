using System;
using System.Collections.Generic;

#nullable disable

namespace EMailApp.Repository.Entity
{
    public partial class User
    {
        public User()
        {
            MailReceivers = new HashSet<Mail>();
            MailSenders = new HashSet<Mail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<Mail> MailReceivers { get; set; }
        public virtual ICollection<Mail> MailSenders { get; set; }
    }
}

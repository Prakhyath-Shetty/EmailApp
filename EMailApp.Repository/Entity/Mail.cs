using System;
using System.Collections.Generic;

#nullable disable

namespace EMailApp.Repository.Entity
{
    public partial class Mail
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public int? SenderId { get; set; }
        public int? ReceiverId { get; set; }
        public bool? IsDraft { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual User Receiver { get; set; }
        public virtual User Sender { get; set; }
    }
}

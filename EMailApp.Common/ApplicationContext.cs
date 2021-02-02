using System;

namespace EMailApp.Common
{
    public class ApplicationContext
    {
        public string CorrelationId { get; } = Guid.NewGuid().ToString();
        public int UserId { get; set; } = -1;
    }
}

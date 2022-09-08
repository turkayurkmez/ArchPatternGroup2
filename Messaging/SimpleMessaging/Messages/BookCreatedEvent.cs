using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    public class BookCreatedEvent
    {
        public BookCreatedEvent()
        {
            EventId = Guid.NewGuid();
        }
        public Guid EventId { get; set; }
        public DateTime CheckInDate { get; set; }
        public int Duration { get; set; }
        public string Email { get; set; }
    }
}


using Microsoft.EntityFrameworkCore;
using SQLink_test.Entity;


namespace SQLink_test.Data
{
    public class TicketsDb
    {
        public List<User> Users { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}

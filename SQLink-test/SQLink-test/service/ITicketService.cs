using SQLink_test.Entity;

namespace SQLink_test.service
{
    public interface ITicketService
    {
        public List<Ticket> GetAllTickets();
        public bool AddTicket(Ticket ticket);
        public bool UpdateTicket(Ticket ticket);
        public void DeleteTicket(int ticketId);
        public Ticket GetTicketById(int ticketId);

    }
}

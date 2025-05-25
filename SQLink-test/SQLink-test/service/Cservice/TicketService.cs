using Microsoft.EntityFrameworkCore;
using SQLink_test.Data;
using SQLink_test.Entity;

namespace SQLink_test.service.Cservice
{
    public class TicketService : ITicketService
    {
        readonly DbcontextTicket _db;
        public TicketService(DbcontextTicket db) { _db = db; }
        public List<Ticket> GetAllTickets()
        {
            var data = _db.LoadData();
            if (data == null) { return null; }
            return data;
        }
        public Ticket GetTicketById(int ticketId)
        {
            var data = _db.LoadData();
            if (data == null)
                return null;
            return data.Where(t => t.ticketId == ticketId).FirstOrDefault();
        }

        public bool AddTicket(Ticket ticket)
        {
            var data = _db.LoadData();
            if (data == null)
                return false;
            data.Add(ticket);
            return _db.SaveData(data);
        }

        public bool UpdateTicket(Ticket ticket)
        {
            return true;
        }
        public void DeleteTicket(int ticketId)
        {

        }


    }

}

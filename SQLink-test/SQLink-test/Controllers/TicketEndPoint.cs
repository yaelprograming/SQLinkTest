using SQLink_test.Entity;
using SQLink_test.service;

namespace SQLink_test.Controllers
{
    public class TicketEndPoint
    {
        public static void MapTicketEndpoints(WebApplication app)
        {
            app.MapGet("/tickets", async (ITicketService ticketService) =>ticketService.GetAllTickets());
            // .RequireAuthorization(); ;

            app.MapGet("/tickets/{id}", async (int id, ITicketService ticketService) => ticketService.GetTicketById(id));
            //.RequireAuthorization(); ;

            app.MapPost("/tickets", async (Ticket ticket, ITicketService ticketService) => ticketService.AddTicket(ticket));
            // .RequireAuthorization("Editor", "Admin"); ;

            app.MapPut("/tickets/{id}", async (int id, Ticket ticket, ITicketService ticketService) =>
            {
                ticket.ticketId = id; 
                return ticketService.UpdateTicket(ticket);
            });
            //.RequireAuthorization( "Editor", "Admin" ); ;

            app.MapDelete("/tickets/{id}", async (int id, ITicketService ticketService) =>ticketService.DeleteTicket(id));//.RequireAuthorization( "Editor", "Admin"); ;
        }
    }
}


namespace SQLink_test.Entity
{
    public class Ticket
    {
        public int ticketId { get; set; }
        public User User { get; set; }
        public bool Status { get; set; }
        public string Img { get; set; }//?
        public string Summary { get; set; }
        public int Description { get; set; }
        public string Solution { get; set; }
    }
}

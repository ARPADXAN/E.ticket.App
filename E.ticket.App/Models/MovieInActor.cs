namespace E.ticket.App.Models
{
    public class MovieInActor
    {
        public long ActorId { get; set; }
        public Actor Actor { get; set; } 
        public long MovieId { get; set; }
        public Movie Movie { get; set; }
    }

}

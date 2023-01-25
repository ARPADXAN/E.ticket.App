using System.ComponentModel.DataAnnotations;
using System.Data;

namespace E.ticket.App.Models
{
    public class Actor
    {
        [Key]
        public long Id { get; set; }
        public string ProfilePicURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
        //Relationship
        public List<MovieInActor> MovieInActors { get; set; }
        
    }
}

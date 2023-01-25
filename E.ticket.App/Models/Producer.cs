using System.ComponentModel.DataAnnotations;

namespace E.ticket.App.Models
{
    public class Producer
    {
        [Key]
        public long Id { get; set; }
        public string ProfilePicURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
        public List<Movie> Movies { get; set; }
    }
}

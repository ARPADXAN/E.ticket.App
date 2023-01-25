using System.ComponentModel.DataAnnotations;

namespace E.ticket.App.Models
{
    public class Cinema
    {
        [Key]
        public long Id { get; set; }
        public string LogoUrl { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Movie> Movies { get; set; }
    }

}

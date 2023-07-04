using System.ComponentModel.DataAnnotations;

namespace Estate.Models
{
    public class UpdateDate
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Estate.Models
{
    public class Portfolio
    {
        [Key]
        public int Id { get; set; }
        public string Mahalle { get; set; }
        public string AdaParsel { get; set; }
        public string Konum { get; set; }
        public string Alan { get; set; }
        public string Emsal { get; set; }
        public double Fiyat { get; set; }
        public double MFiyat { get; set; }
        public string Acıklama { get; set; }
        public string Sunum { get; set; }
        public DateTime Tarih { get; set; }
        public bool Status { get; set; }
    }
}

namespace CMRS.Models
{
    public class Medijator
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Prebivaliste { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public bool Aktivan {  get; set; }
    }
}

namespace CMRS.Models
{
    public class Institucija
    {
        public int Id { get; set; }
        public string Naziv {  get; set; }
        public string Sjediste { get; set; }
        public string Grad {  get; set; }
        public string OIB { get; set; }
        public string KontaktSjedista { get; set; }
        public bool Aktivna { get; set; }
    }
}

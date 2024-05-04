namespace Jurnal_Modul_10_1302223110
{
    public class Mahasiswa
    {
        public string Nama { get; set; }
        public string NIM { get; set; }
        public List<string> Course { get; set; }
        public int Year { get; set; }

        public Mahasiswa()
        {
            this.Nama = Nama;
            this.NIM = NIM;
            this.Course = new List<string>();
            this.Year = Year;
        }
    }
}

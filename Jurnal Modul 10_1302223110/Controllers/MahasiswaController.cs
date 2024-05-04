using Microsoft.AspNetCore.Mvc;

namespace Jurnal_Modul_10_1302223110.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
   
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> listMahasiswa = new List<Mahasiswa>
    {
        new Mahasiswa{Nama= "Adib Faizulhaq Armadhani", NIM= "1302223110", Course= ["KPL", "PBO", "basdat"], Year = 2022 },
        new Mahasiswa{Nama= "Kevin Albany Junaidi", NIM= "1302223027", Course= ["KPL", "PBO", "basdat"], Year = 2022 },
        new Mahasiswa{Nama= "Adrian Fahren Setiawan", NIM= "1302220018", Course= ["KPL", "PBO", "basdat"], Year = 2022 }
    };
        [HttpGet]

        public IEnumerable<Mahasiswa> Get()
        {
            return listMahasiswa;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return listMahasiswa[id];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa mahasiswa)
        {
            listMahasiswa.Add(mahasiswa);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            listMahasiswa.RemoveAt(id);
        }
    }
}

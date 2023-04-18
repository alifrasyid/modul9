using Microsoft.AspNetCore.Mvc;

namespace modul9_1302210098.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> _mahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa() {Name = "Muhammad Alif Rasyid Ramdhani", Nim = "1302210098", Course = new List<string> {"KPL", "BD", "PBO"}, Year = 2021},
            new Mahasiswa() {Name = "Aryasatya Pratama", Nim = "1302210082", Course = new List<string> {"KPL", "BD", "PBO"}, Year = 2021},
            new Mahasiswa() {Name = "Zakkiya Hakeem", Nim = "1302213025", Course = new List<string> {"KPL", "BD", "PBO"}, Year = 2021},
            new Mahasiswa() {Name = "Muhammad Zaidan Rafif", Nim = "1302213072", Course = new List<string> {"KPL", "BD", "PBO"}, Year = 2021},
            new Mahasiswa() {Name = "Hafid Naoya", Nim = "1302210129", Course = new List<string> {"KPL", "BD", "PBO"}, Year = 2021}
        };

        // GET /api/mahasiswa
        [HttpGet]
        public ActionResult<IEnumerable<Mahasiswa>> GetAll()
        {
            return _mahasiswa;
        }

        // GET /api/mahasiswa/{id}
        [HttpGet("{id}")]
        public ActionResult<Mahasiswa> Get(int id)
        {
            if (id >= 0 && id < _mahasiswa.Count)
            {
                return _mahasiswa[id];
            }
            else
            {
                return NotFound();
            }
        }

        // POST /api/mahasiswa
        [HttpPost]
        public void Post(Mahasiswa mahasiswa)
        {
            _mahasiswa.Add(mahasiswa);
        }

        // DELETE /api/mahasiswa/{index}
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (id >= 0 && id < _mahasiswa.Count)
            {
                _mahasiswa.RemoveAt(id);
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }
    }
}

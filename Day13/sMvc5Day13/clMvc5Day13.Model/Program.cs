using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clMvc5Day13.Model
{
    public class Program
    {
        [Key]
        public int ProgramId { get; set; }
        [MaxLength(15)]
        public string ProgramName { get; set; }
        public int JurusanId { get; set; }
        public Jurusan Jurusan { get; set; }
        public ICollection<Siswa> Siswas { get; set; }
    }
}

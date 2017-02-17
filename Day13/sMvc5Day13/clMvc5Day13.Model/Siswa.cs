using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace clMvc5Day13.Model
{
    public class Siswa
    {
        [Key]
        public int SiswaId { get; set; }
        [MaxLength(15)]
        
        public string  SiswaName { get; set; }
        public int Age { get; set; }
        [MaxLength(6)]
        public string Gender { get; set; }
        public int ProgramId { get; set; }
        public Program Program { get; set; }
    }
}

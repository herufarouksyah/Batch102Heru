using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clMvc5Day13.Model
{
    public class Jurusan
    {
        [Key]
        public int JurusanId { get; set; }
        [MaxLength(15)]
        public string JurusanName { get; set; }
        public ICollection<Program> Programs { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace clMvc5Day13.Model
{
    public partial class KampusContext: DbContext      
    {
        public KampusContext():
            base("name=DB")
        {

        }

        //protected override void OnModelCreating(DbModelBuilder mdlBuilder)
        //{
        //    base.OnModelCreating(mdlBuilder);
        //}

        public DbSet<Jurusan> Jurusans { get; set; }
        public DbSet<Program> Programs { get; set; }
        public DbSet<Siswa> Siswas { get; set; }
    }
}

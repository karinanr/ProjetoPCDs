using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPCD.Models
{
    public class Context : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Vaga> Vagas { get; set; }
        public DbSet<Candidatura> Candidatura { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = localhost; Database = ProjetoPcdDb; Trusted_Connection = True");
        }
    }
}

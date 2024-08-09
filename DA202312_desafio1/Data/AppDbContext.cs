using DA202312_desafio1.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using DA202312_desafio1.Models;

namespace DA202312_desafio1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Libro> Libros { get; set; }
    }
}

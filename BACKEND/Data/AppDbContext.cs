using BACKEND.Models;
using Microsoft.EntityFrameworkCore;

namespace BACKEND.Data;

public class AppDbContext : DbContext{
    public DbSet<Livros> LivrosModels { get; set; }

    override protected void OnConfiguring(DbContextOptionsBuilder options){
        options.UseSqlServer(@"Server=DESKTOP-H7797U1\SQLEXPRESS;
                             Database=Biblioteca;
                             Integrated Security=True;
                             Encrypt=False");
    }

    override protected void OnModelCreating(ModelBuilder builder){
        builder.Entity<Livros>().ToTable("Livros");
    }
}
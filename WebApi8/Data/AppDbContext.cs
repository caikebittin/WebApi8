﻿using Microsoft.EntityFrameworkCore;
using WebApi8.Models;

namespace WebApi8.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<AutorModel> Autores { get; set; }
        public DbSet<LivroModel> Livros { get; set; }
        public DbSet<PessoaModel> Pessoa { get; set; }
        public DbSet<EnderecoModel> Endereco { get; set; }
        public DbSet<AluguelLivroModel> AluguelLivro { get; set; }
    }

}

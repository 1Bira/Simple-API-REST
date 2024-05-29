using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using ApplicationCore.Entities;
using System;

public class ApplicationDbContext: DbContext
{
    private readonly IConfiguration _configuration;
    public ApplicationDbContext(){ }
    public ApplicationDbContext(IConfiguration configurarion)
    {
        _configuration = configurarion;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_configuration.GetConnectionString('EfConnBase'));
    }

    public virtual DbSet<Vaga> Vagas {get; set;}
    public virtual DbSet<Localidade> Localidade {get; set;}
    public virtual DbSet<Empresa> Empresa {get; set;}

}
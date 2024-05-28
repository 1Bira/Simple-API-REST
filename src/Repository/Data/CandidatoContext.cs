using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ApplicationCore.Entities;


public class CandidatoContext : DbContext
{
    public DbSet<Candidato> Candidatos;
    
    
}
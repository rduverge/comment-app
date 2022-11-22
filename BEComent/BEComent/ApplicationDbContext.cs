using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BEComent.Models;

namespace BEComent
{
public class AplicationDbContext : DbContext
{
  public DbSet<Comentario> Comentario { get; set; }

  public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
  {

  }
}
}

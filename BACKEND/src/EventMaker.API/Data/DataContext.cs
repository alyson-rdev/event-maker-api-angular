using EventMaker.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EventMaker.API.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) :base(options){}
        public DbSet<Evento> Eventos { get; set; }
    }
}
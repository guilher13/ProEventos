using Microsoft.EntityFrameworkCore;
using ProEventos.API.Models;

namespace ProEventos.API.Data
{
    //usarei essa classe para criar a tabela de eventos que usarei no banco de dados
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<Evento> Eventos { get; set; }
    }
}
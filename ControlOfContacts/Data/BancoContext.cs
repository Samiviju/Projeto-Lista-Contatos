using ControlOfContacts.Models;
using Microsoft.EntityFrameworkCore;

namespace ControlOfContacts.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options)
            : base(options)
        {
        }

        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
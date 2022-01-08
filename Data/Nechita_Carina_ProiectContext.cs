using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nechita_Carina_Proiect.Models;

namespace Nechita_Carina_Proiect.Data
{
    public class Nechita_Carina_ProiectContext : DbContext
    {
        public Nechita_Carina_ProiectContext (DbContextOptions<Nechita_Carina_ProiectContext> options)
            : base(options)
        {
        }

        public DbSet<Nechita_Carina_Proiect.Models.Client> Client { get; set; }

        public DbSet<Nechita_Carina_Proiect.Models.Cont> Cont { get; set; }

        public DbSet<Nechita_Carina_Proiect.Models.Tranzactie> Tranzactie { get; set; }

        public DbSet<Nechita_Carina_Proiect.Models.Imprumut> Imprumut { get; set; }
    }
}

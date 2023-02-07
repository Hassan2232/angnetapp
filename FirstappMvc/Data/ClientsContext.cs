using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FirstappMvc.Models;

    public class ClientsContext : DbContext
    {
        public ClientsContext (DbContextOptions<ClientsContext> options)
            : base(options)
        {
        }

        public DbSet<FirstappMvc.Models.ClientMessage> ClientMessage { get; set; } = default!;
    }

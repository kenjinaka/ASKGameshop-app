using Microsoft.EntityFrameworkCore;
using ASKGameShopAPI.Models.Admin;
using ASKGameShopAPI.Models.Client;
using ASKGameShopAPI.Models.NN;

namespace ASKGames.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext() { }
       
        public DataBaseContext (DbContextOptions<DataBaseContext> options): base(options) {  }    
   
        public DbSet<Cliente> Cliente { get; set; }  
        
        public DbSet<Usuario> Usuario { get; set; }   
        
        public DbSet<Jogo> Jogo { get; set; }

        public DbSet<Cartao> Cartao { get; set; }       

        public DbSet<Pedido> Pedido { get; set; }

        public DbSet<JogoNaSacola> JogoNaSacola { get; set; }

        public DbSet<FormaPagamento> FormaPagamento { get; set; }

        public DbSet<ClienteJogo> ClienteJogo { get; set; }

       

    }
}

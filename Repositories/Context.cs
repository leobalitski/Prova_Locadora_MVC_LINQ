using Microsoft.EntityFrameworkCore;
using Models;

namespace DbRespositorie
{
    //classes derivadas do DB
    public class Context : DbContext
    {
        // DbSet propriedades        
        /// <value> Get and Set properties of customers  </value>
        public DbSet<ClienteModels> Clientes { get; set; }
        /// <value> Get and Set properties of movies  </value>
        public DbSet<FilmeModels> Filmes { get; set; }
        /// <value> Get and Set properties of rentals  </value>
        public DbSet<LocacaoModels> Locacoes { get; set; }
        /// <value> Get and Set properties of class "FilmeLocacao" </value>
        public DbSet<LocacaoFilmeModels> LocacaoFilme { get; set; }


        /// <summary>
        /// inicializa DbContextOptions
        /// </summary>
        /// <param name="options"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql("Server=localhost;User Id=root;Database=locadorakadu");
        }
    }
}
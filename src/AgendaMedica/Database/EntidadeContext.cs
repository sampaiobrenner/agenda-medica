using AgendaMedica.Classes;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMedica.Database {
    public class EntidadeContext : DbContext {
        //Lista de Médicos
        public DbSet<Medico> Medicos { get; set; }

        //Sobrescrevendo a configuração do Entity        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {

            //O ConfigurationManager é uma Referência adicionada ao projeto.
            //Com ele, é possível pegar dados da configuração (App.config)
            //Neste Caso, pegamos a configuração AgendaMedicaConnectionString e o atributo ConnectionString
            string StringConexao = ConfigurationManager.ConnectionStrings["AgendaMedicaConnectionString"].ConnectionString;

            //Aqui definimos o uso do SQL server, passando a string de conexão
            optionsBuilder.UseSqlServer(StringConexao);
            base.OnConfiguring(optionsBuilder);
        }
    }
}

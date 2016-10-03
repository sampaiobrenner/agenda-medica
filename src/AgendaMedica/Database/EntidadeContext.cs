using AgendaMedica.Entidades;
using Microsoft.Data.Entity;
using System.Configuration;


namespace AgendaMedica.Database {
    public class EntidadeContext : DbContext {
        //Lista de Médicos
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Convenio> Convenios { get; set; }
        public DbSet<Atendente> Atendentes { get; set; }      
        public DbSet<Consulta> Consultas { get; set; }

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

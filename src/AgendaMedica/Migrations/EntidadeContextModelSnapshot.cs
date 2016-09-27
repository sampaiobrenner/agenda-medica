using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using AgendaMedica.Database;

namespace AgendaMedica.Migrations
{
    [DbContext(typeof(EntidadeContext))]
    partial class EntidadeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AgendaMedica.Classes.Medico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Celular");

                    b.Property<int>("Cep");

                    b.Property<string>("Cidade");

                    b.Property<string>("Complemento");

                    b.Property<string>("Cpf");

                    b.Property<string>("Crm");

                    b.Property<string>("DataNascimento");

                    b.Property<string>("Email");

                    b.Property<string>("Endereco");

                    b.Property<string>("Estado");

                    b.Property<string>("Nome");

                    b.Property<string>("Numero");

                    b.Property<string>("Rg");

                    b.Property<string>("Sexo");

                    b.Property<string>("Sobrenome");

                    b.Property<string>("Telefone");

                    b.HasKey("Id");
                });
        }
    }
}

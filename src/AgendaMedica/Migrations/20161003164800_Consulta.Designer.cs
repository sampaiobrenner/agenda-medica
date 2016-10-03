using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using AgendaMedica.Database;

namespace AgendaMedica.Migrations
{
    [DbContext(typeof(EntidadeContext))]
    [Migration("20161003164800_Consulta")]
    partial class Consulta
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AgendaMedica.Entidades.Atendente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro");

                    b.Property<string>("Celular");

                    b.Property<string>("Cep");

                    b.Property<string>("Cidade");

                    b.Property<string>("Complemento");

                    b.Property<string>("Cpf");

                    b.Property<string>("DataNascimento");

                    b.Property<string>("Email");

                    b.Property<string>("Endereco");

                    b.Property<string>("Estado");

                    b.Property<string>("Nome");

                    b.Property<string>("Numero");

                    b.Property<string>("OrgaoEmissor");

                    b.Property<string>("Rg");

                    b.Property<string>("Sexo");

                    b.Property<string>("Sobrenome");

                    b.Property<string>("Telefone");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("AgendaMedica.Entidades.Consulta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DataConsulta");

                    b.Property<string>("Especialidade");

                    b.Property<int>("IdConvenio");

                    b.Property<int>("IdMedico");

                    b.Property<int?>("MedicoId");

                    b.Property<string>("Paciente");

                    b.Property<int?>("convenioId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("AgendaMedica.Entidades.Convenio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("AgendaMedica.Entidades.Medico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro");

                    b.Property<string>("Celular");

                    b.Property<string>("Cep");

                    b.Property<string>("Cidade");

                    b.Property<string>("Complemento");

                    b.Property<string>("Cpf");

                    b.Property<string>("Crm");

                    b.Property<string>("DataNascimento");

                    b.Property<string>("Email");

                    b.Property<string>("Endereco");

                    b.Property<string>("Especialidade");

                    b.Property<string>("Estado");

                    b.Property<string>("Nome");

                    b.Property<string>("Numero");

                    b.Property<string>("OrgaoEmissor");

                    b.Property<string>("Rg");

                    b.Property<string>("Sexo");

                    b.Property<string>("Sobrenome");

                    b.Property<string>("Telefone");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("AgendaMedica.Entidades.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro");

                    b.Property<string>("Celular");

                    b.Property<string>("Cep");

                    b.Property<string>("Cidade");

                    b.Property<string>("Complemento");

                    b.Property<int>("ConvenioID");

                    b.Property<string>("Cpf");

                    b.Property<string>("DataNascimento");

                    b.Property<string>("Email");

                    b.Property<string>("Endereco");

                    b.Property<string>("Estado");

                    b.Property<string>("Nome");

                    b.Property<string>("Numero");

                    b.Property<string>("NumeroCarteiraConvenio");

                    b.Property<string>("OrgaoEmissor");

                    b.Property<string>("Rg");

                    b.Property<string>("Sexo");

                    b.Property<string>("Sobrenome");

                    b.Property<string>("Telefone");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("AgendaMedica.Entidades.Consulta", b =>
                {
                    b.HasOne("AgendaMedica.Entidades.Medico")
                        .WithMany()
                        .HasForeignKey("MedicoId");

                    b.HasOne("AgendaMedica.Entidades.Convenio")
                        .WithMany()
                        .HasForeignKey("convenioId");
                });

            modelBuilder.Entity("AgendaMedica.Entidades.Paciente", b =>
                {
                    b.HasOne("AgendaMedica.Entidades.Convenio")
                        .WithMany()
                        .HasForeignKey("ConvenioID");
                });
        }
    }
}

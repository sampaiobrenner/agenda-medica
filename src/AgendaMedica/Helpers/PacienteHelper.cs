using AgendaMedica.DAO;
using AgendaMedica.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaMedica.Helpers {
    public class PacienteHelper {
        private Cadastro contextoCadastro;
        private Pesquisar contextoPesquisar;

        public PacienteHelper(Pesquisar pesquisar) {
            this.contextoPesquisar = pesquisar;
        }

        public PacienteHelper(Cadastro contexto) {
            this.contextoCadastro = contexto;
        }

        public void cadastrarPaciente() {

            try {
                if (validarFormPaciente()) {
                    var convenio = new Convenio();
                    var convenioDAO = new ConvenioDAO();

                    var paciente = new Paciente() {
                        Nome = contextoCadastro.txtNomePaciente.Text,
                        Sobrenome = contextoCadastro.txtSobrenomePaciente.Text,
                        DataNascimento = contextoCadastro.dtpDataNascPaciente.Text,
                        Sexo = (contextoCadastro.rdbSexoFPaciente.Checked ? "F" : "M"),
                        Cpf = contextoCadastro.txtCpfPaciente.Text,
                        Rg = contextoCadastro.txtRgPaciente.Text,
                        OrgaoEmissor = contextoCadastro.txtOrgaoEmiPaciente.Text,
                        Endereco = contextoCadastro.txtEnderecoPaciente.Text,
                        Numero = contextoCadastro.txtNumeroEndPaciente.Text,
                        Complemento = contextoCadastro.txtComplementoPaciente.Text,
                        Bairro = contextoCadastro.txtBairroPaciente.Text,
                        Cidade = contextoCadastro.cbxCidadePaciente.Text,
                        Estado = contextoCadastro.cbxUFPaciente.Text,
                        Cep = contextoCadastro.txtCepPaciente.Text,
                        Telefone = contextoCadastro.txtTelefonePaciente.Text,
                        Celular = contextoCadastro.txtCelularPaciente.Text,
                        Email = contextoCadastro.txtEmailPaciente.Text,
                        ConvenioID = convenioDAO.SearchByName(contextoCadastro.cbxConvenioPaciente.Text),
                        NumeroCarteiraConvenio = contextoCadastro.txtNumCarteirinhaPaciente.Text
                    };
                    var pacienteDAO = new PacienteDAO();

                    pacienteDAO.Save(paciente);

                    MessageBox.Show("Paciente cadastrado com sucesso!");
                }
            } catch (Exception e) {
                var erro = new ExceptionsHelper(e, "Erro ao cadastrar o Paciente no banco de dados");
                erro.lancaException();
            }
        }

        internal void FillGrid(List<Paciente> listaPacientes) {
            contextoPesquisar.dtgListaPacientes.Rows.Clear();

            foreach (var pac in listaPacientes) {

                var nomeCompletoPaciente = pac.Nome + " " + pac.Sobrenome;
                contextoPesquisar.dtgListaPacientes.Rows
                    .Add(pac.Id, nomeCompletoPaciente, pac.Email, pac.Telefone, pac.Celular);
            }
        }

        public bool validarFormPaciente() {
            var campo = "";

            if (String.IsNullOrEmpty(contextoCadastro.txtNomePaciente.Text)) {
                campo = "Nome";
            } else if (String.IsNullOrEmpty(contextoCadastro.txtSobrenomePaciente.Text)) {
                campo = "Sobrenome";
            } else if (String.IsNullOrEmpty(contextoCadastro.dtpDataNascPaciente.Text)) {
                campo = "Data de Nascimento";
            } else if (String.IsNullOrEmpty(contextoCadastro.txtCpfPaciente.Text)) {
                campo = "CPF";
            } else if (String.IsNullOrEmpty(contextoCadastro.txtRgPaciente.Text)) {
                campo = "RG";
            } else if (String.IsNullOrEmpty(contextoCadastro.txtNumeroEndPaciente.Text)) {
                campo = "Número";
            } else if (String.IsNullOrEmpty(contextoCadastro.txtCepPaciente.Text)) {
                campo = "CEP";
            } else if (String.IsNullOrEmpty(contextoCadastro.txtBairroPaciente.Text)) {
                campo = "Bairro";
            } else if (String.IsNullOrEmpty(contextoCadastro.cbxCidadePaciente.Text)) {
                campo = "Cidade";
            } else if (String.IsNullOrEmpty(contextoCadastro.cbxUFPaciente.Text)) {
                campo = "UF";
            } else if (String.IsNullOrEmpty(contextoCadastro.txtTelefonePaciente.Text) || String.IsNullOrEmpty(contextoCadastro.txtCepPaciente.Text)) {
                campo = "Telefone ou Celular";
            } else if (String.IsNullOrEmpty(contextoCadastro.txtEmailPaciente.Text)) {
                campo = "E-mail";
            } else if (String.IsNullOrEmpty(contextoCadastro.txtNumCarteirinhaPaciente.Text)) {
                campo = "Nº Carteirinha";
            } else if (String.IsNullOrEmpty(contextoCadastro.cbxConvenioPaciente.Text)) {
                campo = "Convênio";
            }

            if (!String.IsNullOrEmpty(campo)) {
                MessageBox.Show("Por favor, informe o campo " + campo);
                return false;
            }
            return true;

        }

    }
}

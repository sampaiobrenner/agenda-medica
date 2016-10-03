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
        private Cadastro contexto;

        public PacienteHelper(Cadastro contexto) {
            this.contexto = contexto;
        }

        public void cadastrarPaciente() {

            try {
                if (validarFormPaciente()) {
                    var convenio = new Convenio();
                    var convenioDAO = new ConvenioDAO();

                    var paciente = new Paciente() {
                        Nome = contexto.txtNomePaciente.Text,
                        Sobrenome = contexto.txtSobrenomePaciente.Text,
                        DataNascimento = contexto.txtNascPaciente.Text,
                        Sexo = (contexto.rdbSexoFPaciente.Checked ? "F" : "M"),
                        Cpf = contexto.txtCpfPaciente.Text,
                        Rg = contexto.txtRgPaciente.Text,
                        OrgaoEmissor = contexto.txtOrgaoEmiPaciente.Text,
                        Endereco = contexto.txtEnderecoPaciente.Text,
                        Numero = contexto.txtNumeroEndPaciente.Text,
                        Complemento = contexto.txtComplementoPaciente.Text,
                        Bairro = contexto.txtBairroPaciente.Text,
                        Cidade = contexto.cbxCidadePaciente.Text,
                        Estado = contexto.cbxUFPaciente.Text,
                        Cep = contexto.txtCepPaciente.Text,
                        Telefone = contexto.txtTelefonePaciente.Text,
                        Celular = contexto.txtCelularPaciente.Text,
                        Email = contexto.txtEmailPaciente.Text,
                        ConvenioID = convenioDAO.SearchByName(contexto.cbxConvenioPaciente.Text),
                        NumeroCarteiraConvenio = contexto.txtNumCarteirinhaPaciente.Text
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

        public bool validarFormPaciente() {
            var campo = "";

            if (String.IsNullOrEmpty(contexto.txtNomePaciente.Text)) {
                campo = "Nome";
            } else if (String.IsNullOrEmpty(contexto.txtSobrenomePaciente.Text)) {
                campo = "Sobrenome";
            } else if (String.IsNullOrEmpty(contexto.txtNascPaciente.Text)) {
                campo = "Data de Nascimento";
            } else if (String.IsNullOrEmpty(contexto.txtCpfPaciente.Text)) {
                campo = "CPF";
            } else if (String.IsNullOrEmpty(contexto.txtRgPaciente.Text)) {
                campo = "RG";
            } else if (String.IsNullOrEmpty(contexto.txtNumeroEndPaciente.Text)) {
                campo = "Número";
            } else if (String.IsNullOrEmpty(contexto.txtCepPaciente.Text)) {
                campo = "CEP";
            } else if (String.IsNullOrEmpty(contexto.txtBairroPaciente.Text)) {
                campo = "Bairro";
            } else if (String.IsNullOrEmpty(contexto.cbxCidadePaciente.Text)) {
                campo = "Cidade";
            } else if (String.IsNullOrEmpty(contexto.cbxUFPaciente.Text)) {
                campo = "UF";
            } else if (String.IsNullOrEmpty(contexto.txtTelefonePaciente.Text) || String.IsNullOrEmpty(contexto.txtCepPaciente.Text)) {
                campo = "Telefone ou Celular";
            } else if (String.IsNullOrEmpty(contexto.txtEmailPaciente.Text)) {
                campo = "E-mail";
            } else if (String.IsNullOrEmpty(contexto.txtNumCarteirinhaPaciente.Text)) {
                campo = "Nº Carteirinha";
            } else if (String.IsNullOrEmpty(contexto.cbxConvenioPaciente.Text)) {
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

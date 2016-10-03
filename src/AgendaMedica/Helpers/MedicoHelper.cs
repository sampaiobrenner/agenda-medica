using AgendaMedica.DAO;
using AgendaMedica.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaMedica.Helpers {



    class MedicoHelper {
        private Cadastro contexto;

        public MedicoHelper(Cadastro contexto) {
            this.contexto = contexto;
        }

        public void cadastrarMedico() {
            try {
                if (validarFormMedico()) {
                    var medico = new Medico() {
                        Nome = contexto.txtNomeMed.Text,
                        Sobrenome = contexto.txtSobrenomeMed.Text,
                        DataNascimento = contexto.dtpDataNascPaciente.Text,
                        Sexo = (contexto.rdbSexoFMed.Checked ? "F" : "M"),
                        Cpf = contexto.txtCpfMed.Text,
                        Rg = contexto.txtRgMed.Text,
                        OrgaoEmissor = contexto.txtOrgaoEmiMed.Text,
                        Endereco = contexto.txtEnderecoMed.Text,
                        Numero = contexto.txtNumeroEndMed.Text,
                        Complemento = contexto.txtComplementoMed.Text,
                        Cep = contexto.txtCepMed.Text,
                        Bairro = contexto.txtBairroMed.Text,
                        Estado = contexto.cbxUFMed.Text,
                        Cidade = contexto.cbxCidadeMed.Text,
                        Telefone = contexto.txtTelefoneMed.Text,
                        Celular = contexto.txtCelularMed.Text,
                        Email = contexto.txtEmailMed.Text,
                        Especialidade = contexto.cbxEspecialidadeMed.Text,
                        Crm = contexto.txtCrm.Text
                    };

                    var dao = new MedicoDAO();

                    dao.Save(medico);

                    MessageBox.Show("Médico Cadastrado com Sucesso");
                }
            } catch (Exception e) {
                var erro = new ExceptionsHelper(e, "Erro ao cadastrar o Médico no banco de dados");
                erro.lancaException();
            }
        }

        private bool validarFormMedico() {
            string nome = "";

            if (String.IsNullOrEmpty(contexto.txtNomeMed.Text)) {
                nome = "Nome";
            } else if (String.IsNullOrEmpty(contexto.txtSobrenomeMed.Text)) {
                nome = "Sobrenome";
            } else if (String.IsNullOrEmpty(contexto.dtpDataNascPaciente.Text)) {
                nome = "Data de Nascimento";
            } else if (String.IsNullOrEmpty(contexto.txtCpfMed.Text)) {
                nome = "CPF";
            } else if (String.IsNullOrEmpty(contexto.txtRgMed.Text)) {
                nome = "RG";
            } else if (String.IsNullOrEmpty(contexto.txtOrgaoEmiMed.Text)) {
                nome = "Orgão Emissor";
            } else if (String.IsNullOrEmpty(contexto.txtEnderecoMed.Text)) {
                nome = "Endereço";
            } else if (String.IsNullOrEmpty(contexto.txtNumeroEndMed.Text)) {
                nome = "Número";
            } else if (String.IsNullOrEmpty(contexto.txtCepMed.Text)) {
                nome = "CEP";
            } else if (String.IsNullOrEmpty(contexto.txtBairroMed.Text)) {
                nome = "Bairro";
            } else if (String.IsNullOrEmpty(contexto.cbxUFMed.Text)) {
                nome = "UF";
            } else if (String.IsNullOrEmpty(contexto.cbxCidadeMed.Text)) {
                nome = "Cidade";
            } else if (String.IsNullOrEmpty(contexto.txtTelefoneMed.Text)) {
                nome = "Telefone";
            } else if (String.IsNullOrEmpty(contexto.txtCelularMed.Text)) {
                nome = "Celular";
            } else if (String.IsNullOrEmpty(contexto.txtEmailMed.Text)) {
                nome = "E-mail";
            } else if (String.IsNullOrEmpty(contexto.cbxEspecialidadeMed.Text)) {
                nome = "Especialidade";
            } else if (String.IsNullOrEmpty(contexto.txtCrm.Text)) {
                nome = "CRM";
            } else if (!contexto.rdbSexoFMed.Checked && !contexto.rdbSexoMMed.Checked) {
                nome = "Sexo";
            }

            //Retorna
            if (!String.IsNullOrEmpty(nome)) {
                MessageBox.Show("Preencha o campo: " + nome);
                return false;
            }
            return true;

        }
    }


}

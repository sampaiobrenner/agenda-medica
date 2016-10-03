using AgendaMedica.DAO;
using AgendaMedica.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaMedica.Helpers {



    class MedicoHelper {
        private Cadastro contextoCadastro;
        private Pesquisar contextoPesquisa;

        public MedicoHelper(Cadastro contexto) {
            this.contextoCadastro = contexto;
        }

        public MedicoHelper(Pesquisar pesquisar) {
            this.contextoPesquisa = pesquisar;
        }

        public void cadastrarMedico() {
            try {
                if (validarFormMedico()) {
                    var medico = new Medico() {
                        Nome = contextoCadastro.txtNomeMed.Text,
                        Sobrenome = contextoCadastro.txtSobrenomeMed.Text,
                        DataNascimento = contextoCadastro.dtpDataNascPaciente.Text,
                        Sexo = (contextoCadastro.rdbSexoFMed.Checked ? "F" : "M"),
                        Cpf = contextoCadastro.txtCpfMed.Text,
                        Rg = contextoCadastro.txtRgMed.Text,
                        OrgaoEmissor = contextoCadastro.txtOrgaoEmiMed.Text,
                        Endereco = contextoCadastro.txtEnderecoMed.Text,
                        Numero = contextoCadastro.txtNumeroEndMed.Text,
                        Complemento = contextoCadastro.txtComplementoMed.Text,
                        Cep = contextoCadastro.txtCepMed.Text,
                        Bairro = contextoCadastro.txtBairroMed.Text,
                        Estado = contextoCadastro.cbxUFMed.Text,
                        Cidade = contextoCadastro.cbxCidadeMed.Text,
                        Telefone = contextoCadastro.txtTelefoneMed.Text,
                        Celular = contextoCadastro.txtCelularMed.Text,
                        Email = contextoCadastro.txtEmailMed.Text,
                        Especialidade = contextoCadastro.cbxEspecialidadeMed.Text,
                        Crm = contextoCadastro.txtCrm.Text
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

        internal void FillGrid(List<Medico> listaMedicos) {
            contextoPesquisa.dtgListaMedicos.Rows.Clear();

            foreach (var med in listaMedicos) {

                var nomeCompletoMedico = med.Nome + " " + med.Sobrenome;
                contextoPesquisa.dtgListaMedicos.Rows
                    .Add(med.Id, nomeCompletoMedico, med.Email, med.Telefone, med.Celular);
            }
        }

        private bool validarFormMedico() {
            string nome = "";

            if (String.IsNullOrEmpty(contextoCadastro.txtNomeMed.Text)) {
                nome = "Nome";
            } else if (String.IsNullOrEmpty(contextoCadastro.txtSobrenomeMed.Text)) {
                nome = "Sobrenome";
            } else if (String.IsNullOrEmpty(contextoCadastro.txtCpfMed.Text)) {
                nome = "CPF";
            } else if (String.IsNullOrEmpty(contextoCadastro.txtRgMed.Text)) {
                nome = "RG";
            } else if (String.IsNullOrEmpty(contextoCadastro.txtOrgaoEmiMed.Text)) {
                nome = "Orgão Emissor";
            } else if (String.IsNullOrEmpty(contextoCadastro.txtEnderecoMed.Text)) {
                nome = "Endereço";
            } else if (String.IsNullOrEmpty(contextoCadastro.txtNumeroEndMed.Text)) {
                nome = "Número";
            } else if (String.IsNullOrEmpty(contextoCadastro.txtCepMed.Text)) {
                nome = "CEP";
            } else if (String.IsNullOrEmpty(contextoCadastro.txtBairroMed.Text)) {
                nome = "Bairro";
            } else if (String.IsNullOrEmpty(contextoCadastro.cbxUFMed.Text)) {
                nome = "UF";
            } else if (String.IsNullOrEmpty(contextoCadastro.cbxCidadeMed.Text)) {
                nome = "Cidade";
            } else if (String.IsNullOrEmpty(contextoCadastro.txtTelefoneMed.Text)) {
                nome = "Telefone";
            } else if (String.IsNullOrEmpty(contextoCadastro.txtCelularMed.Text)) {
                nome = "Celular";
            } else if (String.IsNullOrEmpty(contextoCadastro.txtEmailMed.Text)) {
                nome = "E-mail";
            } else if (String.IsNullOrEmpty(contextoCadastro.cbxEspecialidadeMed.Text)) {
                nome = "Especialidade";
            } else if (String.IsNullOrEmpty(contextoCadastro.txtCrm.Text)) {
                nome = "CRM";
            } else if (!contextoCadastro.rdbSexoFMed.Checked && !contextoCadastro.rdbSexoMMed.Checked) {
                nome = "Sexo";
            }

            //Retorna
            if (!String.IsNullOrEmpty(nome)) {
                MessageBox.Show("Preencha o campo: " + nome);
                return false;
            }
            return true;

        }

        internal void carregaMedicos() {
            try {
                var dao = new MedicoDAO();
                var medico = new Medico();
                var listaConveniosCbx = (IList)contextoCadastro.cbxConvenioPaciente.Items;

                IList resultado = dao.Get();

                foreach (var m in resultado) {

                    medico = (Medico)m;
                    if (!listaConveniosCbx.Contains(medico.Nome)) {
                        contextoCadastro.cbxMedicoConsulta.Items.Add(medico.Nome +" "+ medico.Sobrenome);                        
                    }

                }
            } catch (Exception e) {
                throw new Exception("Erro ao carregar os convênios");
            }
        }



    }


}

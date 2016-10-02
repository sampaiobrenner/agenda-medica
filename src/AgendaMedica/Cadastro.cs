using AgendaMedica.Entidades;
using AgendaMedica.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgendaMedica.DAO;
using System.Collections;
using AgendaMedica.Helpers;

namespace AgendaMedica {
    public partial class Cadastro : Form {
        public Cadastro() {

            InitializeComponent();

        }

        private void carregaConvenios() {
            try {
                var dao = new ConvenioDAO();
                var convenio = new Convenio();
                var listaConveniosCbx = (IList)cbxConvenioPaciente.Items;

                IList resultado = dao.Get();
                                                
                foreach (var c in resultado) {

                    convenio = (Convenio)c;
                    if (!listaConveniosCbx.Contains(convenio.Nome)) {
                        cbxConvenioPaciente.Items.Add(convenio.Nome);
                    }
                    
                }
            } catch (Exception e) {
                throw new Exception("Erro ao carregar os convênios");
            }

        }

        private void Form1_Load(object sender, EventArgs e) {
            lbDateTime_Tick(e, e);
        }

        private void lbDateTime_Tick(object sender, EventArgs e) {
            var dataHora = DateTime.Now;
            lbDateTime.Text = "Data: " + dataHora.ToShortDateString() + " | Hora: " + dataHora.ToLongTimeString();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e) {

            switch (tabCadastrar.SelectedTab.Name) {
                case "tabAgendamento":
                    cadastrarAgendamento();
                    break;
                case "tabPaciente":
                    cadastrarPaciente();
                    break;
                case "tabMedicos":
                    cadastrarMedico();
                    break;
                case "tabConvenio":
                    cadastrarConvenio();
                    break;
            }

        }

        private void cadastrarConvenio() {
            try {

                var dao = new ConvenioDAO();

                if (validaFormConvenio()) {
                    var convenio = new Convenio() {
                        Nome = txtNomeConvenio.Text
                    };

                    dao.Save(convenio);
                    MessageBox.Show("Convênio Cadastrado Com sucesso");
                };

            } catch (Exception e) {
                MessageBox.Show("Erro ao salvar o formulário no banco de dados");
                Console.WriteLine(e);
            }
        }




        private void cadastrarMedico() {
            try {
                if (validarFormMedico()) {
                    var medico = new Medico() {
                        Nome = txtNomeMed.Text,
                        Sobrenome = txtSobrenomeMed.Text,
                        DataNascimento = txtNascMed.Text,
                        Sexo = (rdbSexoFMed.Checked ? "F" : "M"),
                        Cpf = txtCpfMed.Text,
                        Rg = txtRgMed.Text,
                        OrgaoEmissor = txtOrgaoEmiMed.Text,
                        Endereco = txtEnderecoMed.Text,
                        Numero = txtNumeroEndMed.Text,
                        Complemento = txtComplementoMed.Text,
                        Cep = txtCepMed.Text,
                        Bairro = txtBairroMed.Text,
                        Estado = cbxUFMed.Text,
                        Cidade = cbxCidadeMed.Text,
                        Telefone = txtTelefoneMed.Text,
                        Celular = txtCelularMed.Text,
                        Email = txtEmailMed.Text,
                        Especialidade = cbxEspecialidadeMed.Text,
                        Crm = txtCrm.Text
                    };

                    var dao = new MedicoDAO();
                    dao.Save(medico);

                    MessageBox.Show("Médico Cadastrado com Sucesso");
                }
            } catch (Exception e) {
                var erro = new Exceptions(e, "Erro ao cadastrar o Médico no banco de dados");
                erro.lancaException();
            }
        }

        private void cadastrarPaciente() {
            try {
                if (validarFormPaciente()) {
                    var paciente = new Paciente() {
                        Nome = txtNomePaciente.Text,
                        Sobrenome = txtSobrenomePaciente.Text,
                        DataNascimento = txtNascPaciente.Text,
                        //sexo
                        Cpf = txtCpfPaciente.Text,
                        Rg = txtRgPaciente.Text,
                        OrgaoEmissor = txtOrgaoEmiPaciente.Text,
                        Endereco = txtEnderecoPaciente.Text,
                        Numero = txtNumeroEndPaciente.Text,
                        Complemento = txtComplementoPaciente.Text,
                        Bairro = txtBairroPaciente.Text,
                        Cidade = cbxCidadePaciente.Text,
                        Estado = cbxUFPaciente.Text,
                        Telefone = txtTelefonePaciente.Text,
                        Celular = txtCelularPaciente.Text,
                        Email = txtEmailPaciente.Text,
                        //ConvenioID = cbxConvenioPaciente.Text,
                        NumeroCarteiraConvenio = txtNumCarteirinhaPaciente.Text
                    };
                    var dao = new PacienteDAO();

                    dao.Save(paciente);

                    MessageBox.Show("Paciente cadastrado com sucesso!");
                }
            } catch (Exception e) {
                var erro = new Exceptions(e, "Erro ao cadastrar o Paciente no banco de dados");
                erro.lancaException();
            }
        }

        private bool validarFormMedico() {
            string nome = "";

            if (String.IsNullOrEmpty(txtNomeMed.Text)) {
                nome = "Nome";
            } else if (String.IsNullOrEmpty(txtSobrenomeMed.Text)) {
                nome = "Sobrenome";
            } else if (String.IsNullOrEmpty(txtNascMed.Text)) {
                nome = "Data de Nascimento";
            } else if (String.IsNullOrEmpty(txtCpfMed.Text)) {
                nome = "CPF";
            } else if (String.IsNullOrEmpty(txtRgMed.Text)) {
                nome = "RG";
            } else if (String.IsNullOrEmpty(txtOrgaoEmiMed.Text)) {
                nome = "Orgão Emissor";
            } else if (String.IsNullOrEmpty(txtEnderecoMed.Text)) {
                nome = "Endereço";
            } else if (String.IsNullOrEmpty(txtNumeroEndMed.Text)) {
                nome = "Número";
            } else if (String.IsNullOrEmpty(txtCepMed.Text)) {
                nome = "CEP";
            } else if (String.IsNullOrEmpty(txtBairroMed.Text)) {
                nome = "Bairro";
            } else if (String.IsNullOrEmpty(cbxUFMed.Text)) {
                nome = "UF";
            } else if (String.IsNullOrEmpty(cbxCidadeMed.Text)) {
                nome = "Cidade";
            } else if (String.IsNullOrEmpty(txtTelefoneMed.Text)) {
                nome = "Telefone";
            } else if (String.IsNullOrEmpty(txtCelularMed.Text)) {
                nome = "Celular";
            } else if (String.IsNullOrEmpty(txtEmailMed.Text)) {
                nome = "E-mail";
            } else if (String.IsNullOrEmpty(cbxEspecialidadeMed.Text)) {
                nome = "Especialidade";
            } else if (String.IsNullOrEmpty(txtCrm.Text)) {
                nome = "CRM";
            } else if (!rdbSexoFMed.Checked && !rdbSexoMMed.Checked) {
                nome = "Sexo";
            }

            //Retorna
            if (!String.IsNullOrEmpty(nome)) {
                MessageBox.Show("Preencha o campo: " + nome);
                return false;
            }
            return true;

        }

        public bool validarFormPaciente() {
            var campo = "";

            if (String.IsNullOrEmpty(txtNomePaciente.Text)) {
                campo = "Nome";
            } else if (String.IsNullOrEmpty(txtSobrenomePaciente.Text)) {
                campo = "Sobrenome";
            } else if (String.IsNullOrEmpty(txtNascPaciente.Text)) {
                campo = "Data de Nascimento";
            } else if (String.IsNullOrEmpty(txtCpfPaciente.Text)) {
                campo = "CPF";
            } else if (String.IsNullOrEmpty(txtRgPaciente.Text)) {
                campo = "RG";
            } else if (String.IsNullOrEmpty(txtNumeroEndPaciente.Text)) {
                campo = "Número";
            } else if (String.IsNullOrEmpty(txtCepPaciente.Text)) {
                campo = "CEP";
            } else if (String.IsNullOrEmpty(txtBairroPaciente.Text)) {
                campo = "Bairro";
            } else if (String.IsNullOrEmpty(cbxCidadePaciente.Text)) {
                campo = "Cidade";
            } else if (String.IsNullOrEmpty(cbxUFPaciente.Text)) {
                campo = "UF";
            } else if (String.IsNullOrEmpty(txtTelefonePaciente.Text) || String.IsNullOrEmpty(txtCepPaciente.Text)) {
                campo = "Telefone ou Celular";
            } else if (String.IsNullOrEmpty(txtEmailPaciente.Text)) {
                campo = "E-mail";
            } else if (String.IsNullOrEmpty(txtNumCarteirinhaPaciente.Text)) {
                campo = "Nº Carteirinha";
            } else if (String.IsNullOrEmpty(cbxConvenioPaciente.Text)) {
                campo = "Convênio";
            }

            if (!String.IsNullOrEmpty(campo)) {
                MessageBox.Show("Por favor, informe o campo " + campo);
                return false;
            }
            return true;

        }

        private bool validaFormConvenio() {
            var campo = "";
            if (String.IsNullOrEmpty(txtNomeConvenio.Text)) {
                campo = "Nome";
            }

            if (!String.IsNullOrEmpty(campo)) {
                MessageBox.Show("Por favor, preencha o campo" + campo);
                return false;
            }
            return true;
        }



        private void cadastrarAgendamento() {
            throw new NotImplementedException();
        }

        private void btnLimpar_Click(object sender, EventArgs e) {
            LimparTextBox(this.tabMedicos);
        }


        public void LimparTextBox(Control controle) {

            foreach (Control ctle in controle.Controls) {
                Console.WriteLine(ctle);
                if (ctle is TextBox) {

                    ((TextBox)ctle).Text = string.Empty;
                } else if (ctle.Controls.Count > 0) {
                    LimparTextBox(ctle);
                }
            }
        }

        private void cbxConvenioPaciente_Click(object sender, EventArgs e) {

            try {
                carregaConvenios();
            } catch (Exception ex) {

            }
        }
    }
}
using AgendaMedica.Classes;
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

namespace AgendaMedica
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbDateTime_Tick(e, e);
        }

        private void lbDateTime_Tick(object sender, EventArgs e)
        {
            DateTime dataHora = DateTime.Now;
            lbDateTime.Text = "Data: " + dataHora.ToShortDateString() + " | Hora: " + dataHora.ToLongTimeString();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtNascMed_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {


            switch (tabCadastrar.SelectedTab.Name)
            {
                case "tabAgendamento":
                    cadastrarAgendamento();
                    break;
                case "tabPacientes":
                    cadastrarPaciente();
                    break;
                case "tabMedicos":
                    cadastrarMedico();
                    break;
            }

        }

        private void cadastrarMedico()
        {

            if (validarFormMedico())
            {
                EntidadeContext contexto = new EntidadeContext();
                Medico medico = new Medico()
                {
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


                contexto.Medicos.Add(medico);
                contexto.SaveChanges();
                contexto.Dispose();

                MessageBox.Show("Médico Cadastrado com Sucesso");
            }
        }

        private bool validarFormMedico()
        {
            string nome = "";

            if (String.IsNullOrEmpty(txtNomeMed.Text))
            {
                nome = "Nome";
            }
            else if (String.IsNullOrEmpty(txtSobrenomeMed.Text))
            {
                nome = "Sobrenome";
            }
            else if (String.IsNullOrEmpty(txtNascMed.Text))
            {
                nome = "Data de Nascimento";
            }
            else if (String.IsNullOrEmpty(txtCpfMed.Text))
            {
                nome = "CPF";
            }
            else if (String.IsNullOrEmpty(txtRgMed.Text))
            {
                nome = "RG";
            }
            else if (String.IsNullOrEmpty(txtOrgaoEmiMed.Text))
            {
                nome = "Orgão Emissor";
            }
            else if (String.IsNullOrEmpty(txtEnderecoMed.Text))
            {
                nome = "Endereço";
            }
            else if (String.IsNullOrEmpty(txtNumeroEndMed.Text))
            {
                nome = "Número";
            }
            else if (String.IsNullOrEmpty(txtCepMed.Text))
            {
                nome = "CEP";
            }
            else if (String.IsNullOrEmpty(txtBairroMed.Text))
            {
                nome = "Bairro";
            }
            else if (String.IsNullOrEmpty(cbxUFMed.Text))
            {
                nome = "UF";
            }
            else if (String.IsNullOrEmpty(cbxCidadeMed.Text))
            {
                nome = "Cidade";
            }
            else if (String.IsNullOrEmpty(txtTelefoneMed.Text))
            {
                nome = "Telefone";
            }
            else if (String.IsNullOrEmpty(txtCelularMed.Text))
            {
                nome = "Celular";
            }
            else if (String.IsNullOrEmpty(txtEmailMed.Text))
            {
                nome = "E-mail";
            }
            else if (String.IsNullOrEmpty(cbxEspecialidadeMed.Text))
            {
                nome = "Especialidade";
            }
            else if (String.IsNullOrEmpty(txtCrm.Text))
            {
                nome = "CRM";
            }
            else if (!rdbSexoFMed.Checked && !rdbSexoMMed.Checked)
            {
                nome = "Sexo";
            }

            //Retorna
            if (!String.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Preencha o campo: " + nome);
                return false;
            }
            return true;

        }

        private void cadastrarPaciente()
        {
            throw new NotImplementedException();
        }

        private void cadastrarAgendamento()
        {
            throw new NotImplementedException();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparTextBox(this);
        }

        
        public void LimparTextBox(Control controle)
        {
            foreach (Control ctle in controle.Controls)
            {
                if (ctle is TextBox)
                {
                    ((TextBox)ctle).Text = string.Empty;
                }else if(ctle.Controls.Count > 0)
                {
                    LimparTextBox(ctle);
                }
            }
        }

        
    }
}
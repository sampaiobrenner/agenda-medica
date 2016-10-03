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
                case "tabConsulta":
                    var consultaHelper = new ConsultaHelper(this);
                    consultaHelper.cadastrarConsulta();
                    break;
                case "tabPaciente":
                    var pacienteHelper = new PacienteHelper(this);
                    pacienteHelper.cadastrarPaciente();
                    break;
                case "tabMedico":
                    var medicoHelper = new MedicoHelper(this);
                    medicoHelper.cadastrarMedico();
                    break;
                case "tabConvenio":
                    var convenioHelper = new ConvenioHelper(this);
                    convenioHelper.cadastrarConvenio();
                    break;
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e) {
            LimparTextBox(this.tabMedico);
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

        private void carregaConvenio(object sender, EventArgs e) {
            try {
                var convenio = new ConvenioHelper(this);
                convenio.carregaConvenios();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void carregaMedicos(object sender, EventArgs e) {
            try {
                var medico = new MedicoHelper(this);
                medico.carregaMedicos();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
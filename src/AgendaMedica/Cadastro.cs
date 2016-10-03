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
                case "tabAgendamento":
                    cadastrarAgendamento();
                    break;
                case "tabPacientes":
                    var pacienteHelper = new PacienteHelper(this);
                    pacienteHelper.cadastrarPaciente();
                    break;
                case "tabMedicos":
                    var medicoHelper = new MedicoHelper(this);
                    medicoHelper.cadastrarMedico();
                    break;
                case "tabConvenio":
                    var convenioHelper = new ConvenioHelper(this);
                    convenioHelper.cadastrarConvenio();
                    break;
            }

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

        private void cbxConvenioPaciente_Focus(object sender, EventArgs e) {

            try {
                var convenio = new ConvenioHelper(this);
                convenio.carregaConvenios();
            } catch (Exception ex) {

            }
        }
    }
}
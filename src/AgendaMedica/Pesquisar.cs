using AgendaMedica.DAO;
using AgendaMedica.Entidades;
using AgendaMedica.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaMedica {
    public partial class Pesquisar : Form {
        public Pesquisar() {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e) {
            DateTime dataHour = DateTime.Now;
            lblTimerTicker.Text = "Data: " + dataHour.ToShortDateString() + " | Hora: " + dataHour.ToLongTimeString();

        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Pesquisar_Load(object sender, EventArgs e) {
            timer1_Tick(e, e);
        }


        private void btnPesquisarConsultas_Click(object sender, EventArgs e) {

            var consultaDao = new ConsultaDAO();
            var consultaHelper = new ConsultaHelper(this);

            consultaHelper.FillGrid(consultaDao.SearchByDate(dtpDataConsulta.Text));
        }

        private void btnPesquisar_click(object sender, EventArgs e) {
            pesquisarPaciente();
        }

        private void keyDownEnterPaciente(object sender, KeyEventArgs e) {            
            if (e.KeyCode == Keys.Enter) {
                pesquisarPaciente();
                //Remove o Barulho do keypress
                e.SuppressKeyPress = true;
            }
        }

        private void keyDownEnterMedico(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                pesquisarMedicos();
                //Remove o Barulho do keypress
                e.SuppressKeyPress = true;
            }
        }

        private void pesquisarPaciente() {
            var pacienteDao = new PacienteDAO();
            var pacienteHelper = new PacienteHelper(this);

            pacienteHelper.FillGrid(pacienteDao.getListByName(txtNomePacientePesquisa.Text));
        }

        private void btnPesquisarMedico_Click(object sender, EventArgs e) {
            pesquisarMedicos();
        }

        private void pesquisarMedicos() {
            var medicoDao = new MedicoDAO();
            var medicoHelper = new MedicoHelper(this);  
                      
            medicoHelper.FillGrid(medicoDao.getListByName(txtNomeMedicoPesquisa.Text));
        }
    }
}

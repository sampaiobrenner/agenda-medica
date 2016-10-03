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

namespace AgendaMedica {
    public partial class MDI_AM : Form {        

        public MDI_AM() {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e) {
            Cadastro frmCadastro = new Cadastro();
            abreTela(frmCadastro);

        }

      

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

      

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e) {
            foreach (Form childForm in MdiChildren) {
                childForm.Close();
            }
        }

        private void menuItemPesquisar_Click(object sender, EventArgs e) {
            Pesquisar formPesquisa = new Pesquisar();
            abreTela(formPesquisa);
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e) {
            Sobre formSobre = new Sobre();
            abreTela(formSobre);
        }

        private void btnPesquisar_Click(object sender, EventArgs e) {
            Pesquisar formPesquisa = new Pesquisar();
            abreTela(formPesquisa);
        }



        private void abreTela(Form tela) {
            tela.MdiParent = this;
            tela.Show();
            tela.WindowState = FormWindowState.Maximized;
        }
       
    }
}

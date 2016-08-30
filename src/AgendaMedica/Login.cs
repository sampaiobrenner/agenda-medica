using System;
using System.Windows.Forms;

namespace AgendaMedica {
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
            //Centraliza a janela
            this.CenterToScreen();
        }

        //Inicio da aplicação
        private void Login_Load(object sender, EventArgs e) {
            

        }

        private void btnLogin_Click(object sender, EventArgs e) {
            string usuario = "raul";
            string password = "123";

            if(txtUsuario.Text == usuario && txtSenha.Text == password) {
                Principal p = new Principal();
                p.Show();
                this.Hide();
            } else {
                MessageBox.Show("Usuário ou senha incorretos");
                txtSenha.Text = "";
            }

            
        }

        private void label1_Click(object sender, EventArgs e) {

        }
    }
}

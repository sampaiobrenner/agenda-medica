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
    class ConvenioHelper {
        private Cadastro contexto;

        public ConvenioHelper(Cadastro contexto) {
            this.contexto = contexto;
        }

        public void cadastrarConvenio() {
            try {

                var dao = new ConvenioDAO();

                if (validaFormConvenio()) {
                    var convenio = new Convenio() {
                        Nome = contexto.txtNomeConvenio.Text
                    };

                    dao.Save(convenio);
                    MessageBox.Show("Convênio Cadastrado Com sucesso");
                };

            } catch (Exception e) {
                MessageBox.Show("Erro ao salvar o formulário no banco de dados");
                Console.WriteLine(e);
            }
        }

        public void carregaConvenios() {
            try {
                var dao = new ConvenioDAO();
                var convenio = new Convenio();
                var listaConveniosCbx = (IList)contexto.cbxConvenioPaciente.Items;

                IList resultado = dao.Get();

                foreach (var c in resultado) {

                    convenio = (Convenio)c;
                    if (!listaConveniosCbx.Contains(convenio.Nome)) {
                        contexto.cbxConvenioPaciente.Items.Add(convenio.Nome);
                        contexto.cbxConvenioConsulta.Items.Add(convenio.Nome);
                    }

                }
            } catch (Exception e) {
                throw new Exception("Erro ao carregar os convênios");
            }
        }

        private bool validaFormConvenio() {
            var campo = "";
            if (String.IsNullOrEmpty(contexto.txtNomeConvenio.Text)) {
                campo = "Nome";
            }

            if (!String.IsNullOrEmpty(campo)) {
                MessageBox.Show("Por favor, preencha o campo" + campo);
                return false;
            }
            return true;
        }
    }
}

using AgendaMedica.DAO;
using AgendaMedica.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaMedica.Helpers {
    class ConsultaHelper {
        public Cadastro contextoCadastro;
        public Pesquisar contextoPesquisa;

        public ConsultaHelper(Cadastro contexto) {
            this.contextoCadastro = contexto;
        }

        public ConsultaHelper(Pesquisar contexto) {
            this.contextoPesquisa = contexto;
        }

        public void cadastrarConsulta() {
            try {

                var consultaDao = new ConsultaDAO();
                var convenioDao = new ConvenioDAO();
                var medicoDao = new MedicoDAO();


                if (validaFormConsulta()) {
                    var consulta = new Consulta() {
                        DataConsulta = contextoCadastro.dtpDataConsulta.Text,
                        IdMedico = medicoDao.SearchByName(contextoCadastro.cbxMedicoConsulta.Text),
                        IdConvenio = convenioDao.SearchByName(contextoCadastro.cbxConvenioConsulta.Text),
                        Especialidade = contextoCadastro.cbxEspecialidadeConsulta.Text,
                        Paciente = contextoCadastro.txtPacienteConsulta.Text,
                    };

                    consultaDao.Save(consulta);
                    MessageBox.Show("Consulta cadastrada com sucesso!");
                };

            } catch (Exception e) {
                MessageBox.Show("Erro ao salvar o formulário no banco de dados");
                Console.WriteLine(e);
            }
        }

        private bool validaFormConsulta() {
            var campo = "";
            if (String.IsNullOrEmpty(contextoCadastro.cbxMedicoConsulta.Text)) {
                campo = "Médico";
            } else if (String.IsNullOrEmpty(contextoCadastro.cbxEspecialidadeConsulta.Text)) {
                campo = "Especialidade";
            } else if (String.IsNullOrEmpty(contextoCadastro.txtPacienteConsulta.Text)) {
                campo = "Paciente";
            } else if (String.IsNullOrEmpty(contextoCadastro.cbxConvenioConsulta.Text)) {
                campo = "Convênio";
            }

            if (!String.IsNullOrEmpty(campo)) {
                MessageBox.Show("Por favor, preencha o campo" + campo);
                return false;
            }
            return true;
        }

        internal void FillGrid(List<Consulta> listaConsulta) {
            contextoPesquisa.dtgListaConsultas.Rows.Clear();
            var consulta = new Consulta();
            var medicoDao = new MedicoDAO();
            var convenioDao = new ConvenioDAO();
            var medico = new Medico();



            foreach (var con in listaConsulta) {
                medico = medicoDao.SearchById(con.IdMedico);
                var nomeCompletoMedico = medico.Nome + " " + medico.Sobrenome;
                contextoPesquisa.dtgListaConsultas.Rows
                    .Add(con.DataConsulta, con.Paciente, nomeCompletoMedico, convenioDao.SearchById(con.IdConvenio).Nome,con.Id);



            }
        }
    }
}

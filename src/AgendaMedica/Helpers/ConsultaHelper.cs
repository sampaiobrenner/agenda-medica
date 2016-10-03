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
        public Cadastro contexto;

        public ConsultaHelper(Cadastro contexto) {
            this.contexto = contexto;
        }

        public void cadastrarConsulta() {
            try {

                var consultaDao = new ConsultaDAO();
                var convenioDao = new ConvenioDAO();
                var medicoDao = new MedicoDAO();


                if (validaFormConsulta()) {
                    var consulta = new Consulta() {
                        DataConsulta = contexto.dtpDataConsulta.Text,
                        IdMedico = medicoDao.SearchByName(contexto.cbxMedicoConsulta.Text),
                        IdConvenio = convenioDao.SearchByName(contexto.cbxConvenioConsulta.Text),
                        Especialidade = contexto.cbxEspecialidadeConsulta.Text,
                        Paciente = contexto.txtPacienteConsulta.Text,                        
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
            if (String.IsNullOrEmpty(contexto.cbxMedicoConsulta.Text)) {
                campo = "Médico";
            } else if (String.IsNullOrEmpty(contexto.cbxEspecialidadeConsulta.Text)) {
                campo = "Especialidade";
            } else if (String.IsNullOrEmpty(contexto.txtPacienteConsulta.Text)) {
                campo = "Paciente";
            } else if (String.IsNullOrEmpty(contexto.cbxConvenioConsulta.Text)) {
                campo = "Convênio";
            }

            if (!String.IsNullOrEmpty(campo)) {
                MessageBox.Show("Por favor, preencha o campo" + campo);
                return false;
            }
            return true;
        }
    }
}

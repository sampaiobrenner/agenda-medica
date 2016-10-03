using AgendaMedica.Database;
using AgendaMedica.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMedica.DAO {
    class PacienteDAO {

        EntidadeContext contexto = new EntidadeContext();

        public void Save(Paciente paciente) {
            contexto.Pacientes.Add(paciente);
            contexto.SaveChanges();
        }
        public void Delete(Paciente paciente) {
            contexto.Pacientes.Remove(paciente);
            contexto.SaveChanges();
        }
        public void Update() {
            contexto.SaveChanges();
        }
        public Paciente SearchById(int id) {
            return contexto.Pacientes.FirstOrDefault(p => p.Id == id);
        }

        public List<Paciente> SearchByName(string nome) {
            var pacientes = new List<Paciente>();
            IQueryable<Paciente> busca;
            try {
                if (String.IsNullOrEmpty(nome)) {
                    busca = from paciente in contexto.Pacientes
                            orderby paciente.Nome
                            select paciente;
                } else {
                    nome = nome.ToUpper();
                    busca = from paciente in contexto.Pacientes
                            where nome.Contains(paciente.Nome)
                            || paciente.Nome.Contains(nome)
                            orderby paciente.Nome
                            select paciente;
                }

                foreach (var paciente in busca) {
                    pacientes.Add(paciente);
                }

                return pacientes;
            } catch (Exception e) {
                Console.WriteLine(e);
                return pacientes;
            }

        }
    }
}

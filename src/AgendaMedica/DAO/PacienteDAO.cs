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
    }
}

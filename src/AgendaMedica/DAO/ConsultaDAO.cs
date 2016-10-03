using AgendaMedica.Database;
using AgendaMedica.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMedica.DAO {
    class ConsultaDAO {
        EntidadeContext contexto = new EntidadeContext();

        public void Save(Consulta consulta) {
            contexto.Consultas.Add(consulta);
            contexto.SaveChanges();
        }
        public void Update() {
            contexto.SaveChanges();
        }
        public void Delete(Consulta consulta) {
            contexto.Consultas.Remove(consulta);
            contexto.SaveChanges();
        }

        public List<Consulta> Get() {
            List<Consulta> consultas = new List<Consulta>();

            var busca = from consulta in contexto.Consultas orderby consulta.DataConsulta select consulta;

            foreach (var consulta in busca) {
                consultas.Add(consulta);
            }
            return consultas;
        }

        public Consulta SearchById(int id) {
            return contexto.Consultas.FirstOrDefault(c => c.Id == id);
        }
        
    }
}

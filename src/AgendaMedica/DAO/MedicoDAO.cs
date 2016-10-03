using AgendaMedica.Database;
using AgendaMedica.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Linq.Expressions;


namespace AgendaMedica.DAO {


    public class MedicoDAO {
        EntidadeContext contexto = new EntidadeContext();

        public void Save(Medico medico) {
            contexto.Medicos.Add(medico);

            contexto.SaveChanges();
            contexto.Dispose();
        }

        public void Delete(Medico medico) {
            contexto.Medicos.Remove(medico);
            contexto.SaveChanges();
        }

        public Medico SearchById(int id) {
            return contexto.Medicos.FirstOrDefault(m => m.Id == id); ;
        }

        public void Update(Medico medico) {
            contexto.SaveChanges();
        }

        public List<Medico> Get() {

            List<Medico> medicos = new List<Medico>();

            var busca = from medico in contexto.Medicos orderby medico.Nome select medico;

            foreach (var medico in busca) {
                medicos.Add(medico);
            }
            return medicos;
        }

        public int SearchByName(string nome) {

            return (from medico in contexto.Medicos
                    where nome.Contains(medico.Nome)
                    && nome.Contains(medico.Sobrenome)
                    select medico.Id).First();
        }
    }


}

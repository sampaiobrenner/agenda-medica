using AgendaMedica.Database;
using AgendaMedica.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMedica.DAO {
    class ConvenioDAO {
        EntidadeContext contexto = new EntidadeContext();

        public void Save(Convenio convenio) {
            contexto.Convenios.Add(convenio);
            contexto.SaveChanges();
        }
        public void Update() {
            contexto.SaveChanges();
        }
        public void Delete(Convenio convenio) {
            contexto.Convenios.Remove(convenio);
            contexto.SaveChanges();
        }

        public List<Convenio> Get() {
            List<Convenio> convenios = new List<Convenio>();

            var busca = from convenio in contexto.Convenios orderby convenio.Nome select convenio ;

            foreach(var convenio in busca) {
                convenios.Add(convenio);
            }
            return  convenios;
        }

        public Convenio SearchById(int id) {
            return contexto.Convenios.FirstOrDefault(c => c.Id == id);
        }
    }
}

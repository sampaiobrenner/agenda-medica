using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMedica.Entidades {
    public class Convenio {

        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual IList<Paciente> Pacientes { get; set; }        
    }
}

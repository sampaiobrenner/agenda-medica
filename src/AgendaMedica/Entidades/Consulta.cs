using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMedica.Entidades {
    public class Consulta {
        public int Id { get; set; }

        public virtual Medico Medico {get; set; }
        public int IdMedico { get; set; }

        public string Especialidade { get; set; }
        public string DataConsulta { get; set; }
        public string Paciente { get; set; }

        public virtual Convenio Convenio { get; set; }
        public int IdConvenio { get; set; }
    }
}

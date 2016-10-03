using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMedica.Entidades {
    public class Paciente : Pessoa {
                
        public string NumeroCarteiraConvenio { get; set; }

        //Definindo o relacionamento: 1 paciente pode ter 1 convenio
        public virtual Convenio Convenio { get; set; }

        public int ConvenioID { get; set; }
    }
}

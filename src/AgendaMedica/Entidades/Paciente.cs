using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMedica.Entidades {
    public class Paciente : Pessoa {
                
        public string NumeroCarteiraConvenio { get; set; }        
        
        //Navigation propertie
        public virtual Convenio Convenio { get; set; }

        public int ConvenioID { get; set; }
    }
}

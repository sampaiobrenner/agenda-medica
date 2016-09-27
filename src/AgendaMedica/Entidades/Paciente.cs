using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMedica.Classes {
    public class Paciente : Pessoa {
                
        string NumeroCarteiraConvenio { get; set; }
        string Convenio { get; set; }
    }
}

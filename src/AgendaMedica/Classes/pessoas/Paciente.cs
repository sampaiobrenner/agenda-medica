using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMedica.Classes {
    class Paciente : Pessoa {

        int Id { get; set; }
        string NumeroCarteiraConvenio { get; set; }
        string Convenio { get; set; }
    }
}

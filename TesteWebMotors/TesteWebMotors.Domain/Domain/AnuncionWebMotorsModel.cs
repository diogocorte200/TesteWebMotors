using System;
using System.Collections.Generic;
using System.Text;

namespace TesteWebMotors.Domain.Domain
{
    public class AnuncionWebMotorsModel : BaseDomain
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Versao { get; set; }
        public int Ano { get; set; }
        public int Quilometragem { get; set; }
        public string Observacao { get; set; }
    }
}

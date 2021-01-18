using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaFIPE.Domain.Models
{
    public class Veiculo
    {
        public Marca Marca { get; set; }
        public Modelo Modelo { get; set; }
        public string Valor { get; set; }
        public int Ano { get; set; }
        public string CodigoFipe { get; set; }
        public string Combustivel { get; set; }
    }
}

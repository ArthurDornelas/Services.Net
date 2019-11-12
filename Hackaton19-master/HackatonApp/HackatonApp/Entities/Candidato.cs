using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackatonApp.Entities
{
    public class Candidato
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Cpf { get; set; }

        public DateTime? DataNascimento { get; set; }
    }
}

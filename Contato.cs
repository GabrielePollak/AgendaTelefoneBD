using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTelefoneBD
{
    public class Contato
    {
        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string Apelido { get; set; }
        public string Email { get; set; }


        public Contato(string n, string t, string a, string e)
        {
            this.Nome = n;
            this.Telefone = t;
            this.Apelido = a;
            this.Email = e;
        }
    }
}

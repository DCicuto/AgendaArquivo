using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaArquivo
{
    internal class Contatos
    {
        public string Nome { get; set; }
        public string Cel { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public Contatos(string nome, string cel, string endereco, string email)
        {
            Nome = nome;
            Cel = cel;
            Endereco = endereco;
            Email = email ;
        }
        public override string? ToString()
        {
            return Nome + ";\n\n" + Cel + ";\n\n" + Endereco + ";\n\n" + Email;
        }
    }
}
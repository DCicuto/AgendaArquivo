using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace AgendaArquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            //TextWriter texto = new StreamWriter("agenda.txt");
            //texto.WriteLine("<<<<<<<<<<Meus contatos>>>>>>>>>>");
            //texto.WriteLine("Nome: Zaira Cicuto Gomes");
            //texto.WriteLine("Telefone: 16 99702-0088");         
            //texto.WriteLine("Endereço: Avenida PittBull, 09, Araraquara");
            //texto.WriteLine("E-mail: zaira@gmail.com");

            //texto.Close();

            /*TextReader textoReader = new StreamReader("agenda.txt"());
            Console.WriteLine(textoReader.ReadToEnd());
            textoReader.Close();*/

            List<Contatos> contatos = new List<Contatos>();

            Console.WriteLine("Meus Contatos");
            Console.WriteLine("Infome o Nome: ");
            String nome = Console.ReadLine();

            Console.WriteLine("Informe Telefone: ");
            string cel = Console.ReadLine();

            Console.WriteLine("Informe o Endereço: ");
            string endereco = Console.ReadLine();

            Console.WriteLine("Informe o E-mail: ");
            string email = Console.ReadLine();

            Contatos contato = new Contatos(nome, cel, endereco, email);

            // Abrir o arquivo no modo de adição
            using (StreamWriter text = File.AppendText("arquivo.txt"))
            {
                text.WriteLine(contato);
            }

            // StreamWriter text = File.AppendText("arquivo.txt");
            //text.WriteLine(nome +","+ telefone +","+ endereco +","+ email);
            //text.Close();

            //contatos.Add(text);

            Console.WriteLine("Registro concluido");

            Console.ReadLine();
        }
    }
}




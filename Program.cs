using System;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace AgendaTelefoneBD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nome: ");
            string n = Console.ReadLine();

            Console.WriteLine("Apelido: ");
            string a = Console.ReadLine();

            Console.WriteLine("Telefone: ");
            string t = Console.ReadLine();

            Console.WriteLine("Email: ");
            string e = Console.ReadLine();

            Contato c = new(n, t, a, e);
            #region Conexao com o Banco
            Banco conn = new Banco();

            

            SqlConnection conexaosql = new SqlConnection(conn.Caminho());

            conexaosql.Open();
            #endregion

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO Contatos(Nome, Telefone, Apelido, Email) VALUES (@Nome, @Telefone, @Apelidp, @Email);";

         

        }
    }
}

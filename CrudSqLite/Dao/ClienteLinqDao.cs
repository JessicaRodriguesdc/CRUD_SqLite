using CrudSqLite.Modal;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudSqLite.Dao
{
    public class ClienteLinqDao
    {
        private string conexaoM = @"Data source = C:\Users\jessi\OneDrive\Documentos\CrudSqLite\Banco\BancoSqLite.db; Version = 3;";
        private string nomebancoM = @"C:\Users\jessi\OneDrive\Documentos\CrudSqLite\Banco\BancoSqLite.db";

        public SQLiteConnection conectar()
        {
            SQLiteConnection conn = new SQLiteConnection(conexaoM);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao acessar o Banco " + ex);
            }

            return conn;
        }
        public void Clientes(List<string> listClientes)
        {
            foreach (string cli in listClientes)
            {
                Console.WriteLine(cli);
            }
        }
        public void j (List<string> lista)
        {
            IEnumerable<string> nameQuery = from nome in lista
                                             where nome[0] == 'j'
                                             select nome;

            foreach (string str in nameQuery)
            {
                Console.WriteLine(str);
            }

        }
        public void adcionarClientes()
        {

        }
        public void alterarClientes()
        {

        }

        public void excluirClientes()
        {

        }
    }
}

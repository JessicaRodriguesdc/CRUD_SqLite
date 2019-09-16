using CrudSqLite.Modal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudSqLite.Dao
{
    public class ClienteDao
    {
        //C:\Users\jessi\OneDrive\Documentos\CrudSqLite\Banco

        private string conexao = @"Data source = C:\Users\jessi_001\source\repos\CrudSqLite\Banco\BancoSqLite.db; Version = 3;";
        private string nomebanco = @"C:\Users\jessi_001\source\repos\CrudSqLite\Banco\BancoSqLite.db";

        private string conexaoM = @"Data source = C:\Users\jessi\OneDrive\Documentos\CrudSqLite\Banco\BancoSqLite.db; Version = 3;";
        private string nomebancoM = @"C:\Users\jessi\OneDrive\Documentos\CrudSqLite\Banco\BancoSqLite.db";

        public void criarBanco(SQLiteConnection conn)
        {
            if (!File.Exists(nomebancoM))
            {
                SQLiteConnection.CreateFile(nomebancoM);
                conn.Open();
                
                try
                {
                    Console.WriteLine("Banco criado");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao criar o banco de dados: " + ex.Message);
                }

            }
        }
        public void criarTabelaCliente(SQLiteConnection conn)
        {
            string query = "CREATE TABLE clientes(" +
                            "id     		    INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, " +
                            "nome				varchar(50), " +
                            "sexo				varchar(10), " +
                            "telefone			varchar(20))";

            SQLiteCommand comando = new SQLiteCommand(query, conn);
            try
            {
                comando.ExecuteNonQuery();
                Console.WriteLine("Tabela Criada");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao criar a tabela: " + ex.Message);
            }
        }
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
        public void fecharConexao(SQLiteConnection conn)
        {
          conn.Close();
        }

        public void addCliente(SQLiteConnection conn,Int32 id, string nome, string sexo, string telefone)
        {
            Cliente cli = new Cliente();
            cli.id = id;
            cli.nome = nome;
            cli.sexo = sexo;
            cli.telefone = telefone;

            string query = "INSERT INTO clientes VALUES('{0}','{1}','{2}','{3}')";
            query = String.Format(query,cli.id, cli.nome, cli.sexo, cli.telefone); 

            SQLiteCommand comando = new SQLiteCommand(query, conn);
            try
            {
                comando.ExecuteNonQuery();
                Console.WriteLine("Cliente Inserir");

                comando.Dispose();
                conn.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao Inserir " + ex);
            }
            
        }
        public void atualizarCliente(SQLiteConnection conn, Int32 id, string nome, string sexo, string telefone)
        {
            Cliente cli = new Cliente();
            cli.id = id;
            cli.nome = nome;
            cli.sexo = sexo;
            cli.telefone = telefone;


            string query = "UPDATE clientes SET nome = '{0}', sexo = '{1}', telefone = '{2}' WHERE id = {3}";
            
            query = String.Format(query, cli.nome, cli.sexo, cli.telefone, cli.id);
            SQLiteCommand comando = new SQLiteCommand(query, conn);
            try
            {
                comando.ExecuteNonQuery();
                Console.WriteLine("Cliente Modificado");

                comando.Dispose();
                conn.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao Modificado " + ex);
            }
        }
        public void excluirCliente(SQLiteConnection conn, Int32 id)
        {
            Cliente cli = new Cliente();
            cli.id = id;
      
            string query = "DELETE FROM clientes WHERE id = {0}";
            query = String.Format(query, cli.id);
            SQLiteCommand comando = new SQLiteCommand(query, conn);
            try
            {
                comando.ExecuteNonQuery();
                Console.WriteLine("Cliente Excluido");

                comando.Dispose();
                conn.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao Excluido " + ex);
            }

        }
        public void verRegistrosCliente(SQLiteConnection conn)
        {
            try
            {
                SQLiteDataAdapter adaptador = new SQLiteDataAdapter("SELECT * FROM clientes", conn);
                DataTable dados = new DataTable();
                adaptador.Fill(dados);

                foreach (DataRow linha in dados.Rows)
                {
                    Console.WriteLine(linha["nome"].ToString() + " -> " + linha["sexo"].ToString() + " -> " + linha["telefone"].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao Ver Registros " + ex);
            }

        }

    }
}

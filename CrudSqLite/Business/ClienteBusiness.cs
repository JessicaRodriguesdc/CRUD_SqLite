using CrudSqLite.Dao;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudSqLite.Business
{
    class ClienteBusiness
    {
        ClienteDao dao;
       
        public ClienteBusiness()
        {
            dao = new ClienteDao();
        }

        public bool criarBanco()
        {
            SQLiteConnection con = null;
            try
            {
                con = dao.conectar();
                dao.criarBanco(con);
                return true;
            }
            finally
            {
                if (con != null)
                {
                    dao.fecharConexao(con);
                }
            }
        }
        public bool tabelaCli()
        {
            SQLiteConnection con = null;
            try
            {
                con = dao.conectar();
                dao.criarTabelaCliente(con);
                return true;
            }
            finally
            {
                if (con != null)
                {
                    dao.fecharConexao(con);
                }
            }
        }
        public bool conexao()
        {
            SQLiteConnection con = null;
            try
            {
                con = dao.conectar();

                return true;
            }
            finally
            {
                if (con != null)
                {
                    dao.fecharConexao(con);
                }
            }
        }

        public bool addCli()
        {
            SQLiteConnection con = null;
            try
            {
                con = dao.conectar();
                dao.addCliente(con,1,"Jessica Rodrigues", "F", "123456798");
                
                return true;
            }
            finally
            {
                if (con != null)
                {
                    dao.fecharConexao(con);
                }
            }
        }
        public bool atualizarCli()
        {
            SQLiteConnection con = null;
            try
            {
                con = dao.conectar();
                dao.atualizarCliente(con, 2, "emily", "F", "993456798");

                return true;
            }
            finally
            {
                if (con != null)
                {
                    dao.fecharConexao(con);
                }
            }
        }

        public bool excluirCli()
        {
            SQLiteConnection con = null;
            try
            {
                con = dao.conectar();
                dao.excluirCliente(con, 2);

                return true;
            }
            finally
            {
                if (con != null)
                {
                    dao.fecharConexao(con);
                }
            }
        }
        public bool verRegistroCli()
        {
            SQLiteConnection con = null;
            try
            {
                con = dao.conectar();
                dao.verRegistrosCliente(con);
                return true;
            }
            finally
            {
                if (con != null)
                {
                    dao.fecharConexao(con);
                }
            }
        }
    }
}

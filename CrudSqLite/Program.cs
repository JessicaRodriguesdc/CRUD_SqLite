using CrudSqLite.Business;
using CrudSqLite.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudSqLite
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteBusiness cliBus = new ClienteBusiness();
            //cliBus.addCli();
            //cliBus.atualizarCli();
            //cliBus.excluirCli();
            cliBus.verRegistroCli();
            Console.ReadKey();
        }
    }
}

using CrudSqLite.Business;
using CrudSqLite.Dao;
using CrudSqLite.Linq;
using CrudSqLite.Modal;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudSqLite
{
    class Program
    {
        private static object bd;

        static void Main(string[] args)
        {
            //ClienteBusiness cliBus = new ClienteBusiness();
            //cliBus.addCli();
            //cliBus.atualizarCli();
            //cliBus.excluirCli();
            //cliBus.verRegistroCli();

            List<string> clientes = new List<string>();
            
            clientes.Add("emy");
            clientes.Add("vik");
            clientes.Add("ino");
            clientes.Add("jsk");
            clientes.Add("jor");
            clientes.Add("izk");
            clientes.Add("leo");
            clientes.Add("seg");
            LinqTeste teste = new LinqTeste();
            //Console.WriteLine(teste.buscarForeach(clientes, "jsk"));
            //Console.WriteLine(teste.buscarLinq(clientes, "jsk"));
            //Console.WriteLine(teste.buscarLinqLambda(clientes, "jsk"));
            //teste.buscarLinqList(clientes, "i").ForEach(x => Console.WriteLine(x));
            //teste.buscarLinqLambdaList(clientes, "i").ForEach(x => Console.WriteLine(x));

            List<string> listClientes = new List<string>
            {
                "jessica","Luca","Pedro","jhom"
            };
            
            ClienteLinqDao cliLinq = new ClienteLinqDao();
            cliLinq.Clientes(listClientes);
            //cliLinq.j(listClientes);

            Console.ReadKey();
        }
    }
}

using CrudSqLite.Business;
using CrudSqLite.Dao;
using CrudSqLite.Linq;
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

            Console.WriteLine(teste.buscarForeach(clientes, "jsk"));
            Console.WriteLine(teste.buscarLinq(clientes, "jsk"));
            Console.WriteLine(teste.buscarLinqLambda(clientes, "jsk"));


            teste.buscarLinqList(clientes, "i").ForEach(x => Console.WriteLine(x));
            teste.buscarLinqLambdaList(clientes, "i").ForEach(x => Console.WriteLine(x));


            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudSqLite.Linq
{
    public class LinqTeste
    {
        public string buscarForeach(List<string> lista, string termo)
        {
            foreach(string item in lista)
            {
                if (item.Equals(termo))
                    return item;
            }
            return null;
        }
        public string buscarLinq(List<string> lista, string termo)
        {
            return (from item in lista where item.Equals(termo) select item).First();
          
        }
        public List<string> buscarLinqList(List<string> lista, string termo)
        {
            return (from item in lista where item.Contains(termo) select item).ToList();
        }

        public string buscarLinqLambda(List<string> lista, string termo)
        {
            return lista.First(x => x.Equals(termo));
        }

        public List<string> buscarLinqLambdaList(List<string> lista, string termo)
        {
            return lista.Where(x => x.Contains(termo)).ToList();
        }
    }
}

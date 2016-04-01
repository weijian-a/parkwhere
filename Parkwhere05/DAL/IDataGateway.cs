using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkwhere05.DAL
{
    interface IDataGateway<T> where T : class
    {
        IEnumerable<T> SelectAll();
        T SelectById(int? id);
    }
}

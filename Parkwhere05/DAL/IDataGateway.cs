using System.Collections.Generic;

namespace Parkwhere05.DAL
{
    interface IDataGateway<T> where T : class
    {
        IEnumerable<T> SelectAll();
        T SelectById(int? id);
    }
}

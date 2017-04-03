using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Repository
{
    [ServiceContract] 
    public interface IRepository<T>
    {
        [OperationContract]
        List<T> GetAll();

        [OperationContract]
        T Find(int ID);

        [OperationContract]
        int Add(T entity);

        [OperationContract]
        void Update(T entity);

        [OperationContract]
        void Delete(T entity);
    }
}

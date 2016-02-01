using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Database
{
    public class DatabaseBal : IDatabaseBAL
    {
        public IList<CrmDomain.Databas> GetAllDatabase()
        {
            throw new NotImplementedException();
        }

        public CrmDomain.Databas GetDatabaseByName(string value)
        {
            throw new NotImplementedException();
        }

        public void AddDatabase(params CrmDomain.Databas[] databases)
        {
            throw new NotImplementedException();
        }

        public void UpdateDatabase(params CrmDomain.Databas[] databases)
        {
            throw new NotImplementedException();
        }

        public void RemoveDatabase(params CrmDomain.Databas[] databases)
        {
            throw new NotImplementedException();
        }

        public IList<CrmDomain.Customer> GetCustomerByDatabaseName(string databaseName)
        {
            throw new NotImplementedException();
        }
    }
}

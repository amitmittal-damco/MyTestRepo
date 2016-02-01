using System.Collections.Generic;
using CrmDomain;
namespace BAL.Database
{
    public interface IDatabaseBAL
    {
        IList<Databas> GetAllDatabase();
        Databas GetDatabaseByName(string value);
        void AddDatabase(params Databas[] databases);
        void UpdateDatabase(params Databas[] databases);
        void RemoveDatabase(params Databas[] databases);
        IList<Customer> GetCustomerByCustomerId(string databaseName);
    }
}

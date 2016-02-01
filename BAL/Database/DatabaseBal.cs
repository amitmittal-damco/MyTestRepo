using CRMEf.Repository.Customer;
using CRMEf.Repository.Database;
using System;
using System.Collections.Generic;

namespace BAL.Database
{
    public class DatabaseBal : IDatabaseBAL
    {

        private readonly ICrmDatabase _crmDatabase;
        private readonly ICustomer _crmCustomer;

        public DatabaseBal()
        {
            _crmDatabase = new DatabaseRepository();
            _crmCustomer = new CustomerRepository();
        }

        public DatabaseBal(ICrmDatabase crmDatabase, ICustomer crmCustomer)
        {
            _crmDatabase = crmDatabase;
            _crmCustomer = crmCustomer;
        }
        
        public IList<CrmDomain.Databas> GetAllDatabase()
        {
            return _crmDatabase.GetAll();
        }
        public CrmDomain.Databas GetDatabaseByName(string value)
        {
            return _crmDatabase.GetSingle(x=>x.DbName.Equals(value));
        }

        public void AddDatabase(params CrmDomain.Databas[] databases)
        {
            _crmDatabase.Add(databases);
        }

        public void UpdateDatabase(params CrmDomain.Databas[] databases)
        {
            _crmDatabase.Update(databases);
        }

        public void RemoveDatabase(params CrmDomain.Databas[] databases)
        {
            _crmDatabase.Update(databases);
        }

        public IList<CrmDomain.Customer> GetCustomerByCustomerId(string customerName)
        {
            return _crmCustomer.GetList(e => e.CustomerID == Convert.ToInt32(customerName));
        }
    }
}

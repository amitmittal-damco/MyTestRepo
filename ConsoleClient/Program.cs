using BAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrmDomain;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            IDatabaseBAL businessLayer = new DatabaseBal();


            var db = new Databas()
            {
                CustomerID = 2
                ,
                AccountID = 4
                ,
                ParentID = 1
                ,
                SupplierID = 3
                ,
                Company = "Damco (Test3)"
                ,
                DsnName = @"172.29.9.167\SQLSERVER"
                ,
                DbSchema = "3"
                ,
                DbName = "AutoCribNet_Schema_V2"
                ,
                DbLogin = "U_AutoCribNet2_Dev_V1"
                ,
                DbPassword = "damco"
            };


            //businessLayer.AddDatabase(db);

            var databases = businessLayer.GetAllDatabase();
            foreach (var database in databases)
                Console.WriteLine("{0} - {1}", database.DbName, database.DbLogin);



            var customers = businessLayer.GetCustomerByCustomerId("1");
            if (customers != null)
            {
                
                foreach (var customer in customers)
                    Console.WriteLine(string.Format("{0}, {1}", customer.Company,customer.CustomerID));
            };


           

            ///* Remove employee */
            //it.Employees.Clear();
            //businessLayer.RemoveEmployee(employee);

            ///* Remove departments*/
            //businessLayer.RemoveDepartment(it, sales, marketing);

            Console.ReadLine();
        }
    }
}

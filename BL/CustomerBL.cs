using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BO;
using DAL;

namespace BL
{
     public class CustomerBL
    {
        public List<CustomerBO> GetCustomersWaiting() // passing Bussiness object Here  
        {
            try
            {
                CustomerDAL objCustomer = new CustomerDAL(); // Creating object of Dataccess  
                return objCustomer.GetCustomersWaiting(); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }

        public string CreateNewCustomer(string name)
        {
            try
            {
                CustomerDAL objCustomer = new CustomerDAL(); // Creating object of Dataccess  
                return objCustomer.CreateNewCustomer(name);
            }
            catch
            {
                return "not good";
            }
        }

        public List<CustomerBO> UpdateCustomer()
        {
            try
            {
                CustomerDAL objCustomer = new CustomerDAL(); // Creating object of Dataccess  
                return objCustomer.UpdateCustomer(); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }

        }
    }
}

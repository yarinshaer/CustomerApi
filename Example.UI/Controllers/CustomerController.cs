using BL;
using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Example.UI.Controllers
{
    [AllowCrossSiteJson]
    public class CustomerController : ApiController
    {
        

        [System.Web.Http.HttpGet]
        public IEnumerable<CustomerBO> GetCustomersWaiting()
        { 
            try
            {
                CustomerBL cbl = new CustomerBL();
                var listCustomers = cbl.GetCustomersWaiting();
                return listCustomers;
            }
            catch
            {
                return null;
            }

        }
        [System.Web.Http.HttpPost]
        public string CreateNewCustomer(string name)
        {
            if (string.IsNullOrEmpty(name)||name=="undefined")
                return "not good";
            try
            {
                CustomerBL cbl = new CustomerBL();
                var listCustomers = cbl.CreateNewCustomer(name);
                return listCustomers;
            }
            catch
            {
                return "not good";
            }
        }
        [System.Web.Http.HttpPost]

        public string CreateNewCustomerS(string username,string password)
        {
            if (string.IsNullOrEmpty(username) || username == "undefined")
                return "not good";
            try
            {
                CustomerBL cbl = new CustomerBL();
                var listCustomers = cbl.CreateNewCustomer(username);
                return listCustomers;
            }
            catch
            {
                return "not good";
            }
        }
        [System.Web.Http.HttpPost]
        public IEnumerable<CustomerBO> UpdateCustomer()
        {
            try
            {
                CustomerBL cbl = new CustomerBL();
                 var listCustomer = cbl.UpdateCustomer();
                return listCustomer;
            }
            catch
            {
                return null;
            }
           
        }
    }

}

using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public  class CustomerDAL
    {
        public List<CustomerBO> GetCustomersWaiting()
        {
            CustomersHospitalEntities che = new CustomersHospitalEntities();
            List<CustomerBO> listcm = new List<CustomerBO>();
            try
            {
                var cmfromdb = che.GetAllCustomersWaiting().ToList();
                for (int i = 0; i < cmfromdb.Count; i++)
                {
                    listcm.Add(new CustomerBO

                    {
                        Name = cmfromdb[i].Name.ToString(),
                        Status = cmfromdb[i].Status,
                        Id = cmfromdb[i].Id,
                        Time = cmfromdb[i].Time
                    });

                }

                return listcm;

            }
            catch (Exception ex)
            {
                return listcm;
            }
        }

        public string CreateNewCustomer(string name)
        {
            try
            {
                CustomersHospitalEntities che = new CustomersHospitalEntities();
                che.InsertCustomer(name);
                che.SaveChanges();
                return "good";

            }
            catch (Exception ex)
            {

                return "not good";
            }
             

        }

        public List<CustomerBO> UpdateCustomer()
        {
            CustomersHospitalEntities ce = new CustomersHospitalEntities();
            List<CustomerBO> listcm = new List<CustomerBO>();

            try
            {
               
                var cmfromdb = ce.UpdateCustomer().ToList();
                listcm.Add(new CustomerBO

                {
                    Name = cmfromdb[0].Name.ToString(),
                    Status = cmfromdb[0].Status,
                    Id = cmfromdb[0].Id,
                    Time = cmfromdb[0].Time
                });

                ce.SaveChanges();
                return listcm;
            }
            catch (Exception ex)
            {
                return listcm;
            }
        }
    }
}

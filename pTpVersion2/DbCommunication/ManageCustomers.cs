using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using pTpVersion2.Data.DatabaseModels.DbContext;
using pTpVersion2.Data.DatabaseModels.ViewModels;

namespace pTpVersion2.DbCommunication
{
    public class ManageCustomers
    {
        public static CustomerView FindCustomer(int customerId)
        {
            using (var db = new PtpContext())
            {
                var customer = db.Customers.Find(customerId);
                return new CustomerView()
                {
                    CustomerId = customer.CustomerId,
                    FirmId = customer.FirmId
                };
            }
        }

        internal static System.Collections.IList ReturnCustomers()
        {
            var list = new List<CustomerView>();
            using (var db = new PtpContext())
            {
                foreach (var customer in db.Customers)
                {
                    list.Add(new CustomerView()
                    {
                        CustomerId = customer.CustomerId,
                        FirmId = customer.FirmId
                    });
                }
            }
            return list;
        }
    }
}

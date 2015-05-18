using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pTpVersion2.Data.DatabaseModels.DbContext;
using pTpVersion2.Data.DatabaseModels.ViewModels;

namespace pTpVersion2.DbCommunication
{
    public class ManageFirms
    {
        public static FirmView ReturnFirm(int firmId)
        {
            using (var db = new PtpContext())
            {
                var firm = db.Firms.Find(firmId);
                return new FirmView()
                {
                    FirmId = firm.FirmId,
                    FirmName = firm.FirmName,
                    PersonId = firm.ContactPersonId
                };
            }
        }


        internal static List<CustomerView> ReturnFirms()
        {
            var list = new List<CustomerView>();
            using (var db = new PtpContext())
            {
                var dbList = db.Customers.Where(x => x.FirmId != null).ToList();

                foreach (var customer in dbList)
                {
                    list.Add(new CustomerView()
                    {
                        CustomerId = customer.CustomerId,
                        PersonId = customer.PersonId,
                        FirmId = customer.FirmId
                    });
                }
            }
            return list;
        }
    }
}

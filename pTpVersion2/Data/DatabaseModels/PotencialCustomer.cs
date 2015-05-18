using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pTpVersion2.Data.DatabaseModels
{
    public class PotencialCustomer
    {
        [Key]
        public int PotencialCustomerId { get; set; }

        
        public int StrankaId { get; set; }

        public int TipStranke { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pTpVersion2.Data.DatabaseModels
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [ForeignKey("PersonId")]
        public virtual Person Person { get; set; }
        public int PersonId { get; set; }

        [ForeignKey("FirmId")]
        public Firm Firm { get; set; }
        public int? FirmId { get; set; }
    }
}

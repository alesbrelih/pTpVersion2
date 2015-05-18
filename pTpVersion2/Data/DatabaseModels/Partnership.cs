using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pTpVersion2.Data.DatabaseModels
{
    public class Partnership
    {
        [Key]
        public int PartnershipId { get; set; }

        public int FirmId { get; set; }

        [ForeignKey("FirmId")]
        public virtual Firm Firm { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}

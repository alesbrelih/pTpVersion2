using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pTpVersion2.Data.DatabaseModels
{
    public class Firm
    {
        [Key]
        public int FirmId { get; set; }

        public string FirmName { get; set; }

        [ForeignKey("ContactPersonId")]
        public virtual Person ContactPerson { get; set; }
        public int ContactPersonId { get; set; }
    }
}

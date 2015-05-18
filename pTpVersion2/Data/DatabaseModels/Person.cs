using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pTpVersion2.Data.DatabaseModels
{
    public class Person
    {
   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

    
        public string Email { get; set; }


        public string Telephone { get; set; }

        public bool Foreigner { get; set; }


    }
}

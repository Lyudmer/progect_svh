using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVHDB.Entities
{
    public class StatusGraph
    {
        [Key,Column("oldst")]
        public int oldst { get; set; }

        [Column("newst")]
        public int newst { get; set; }

        [Column("maskbit"),MaxLength(15)]
        public string maskbit { get; set; }

        public Status Status { get; set; }

    }

}

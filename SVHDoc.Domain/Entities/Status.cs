using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SVHDB.Entities
{
    public class Status
    {
        [Key, Column("id")]
        public int Id { get; set; }
        [Column("fullname"), MaxLength(50)]
        public string? FullName { get; set; }

        [Column("runwf")]
        public bool RunWf { get; set; }
        
        [Column("mkres")]
        public bool MkRes { get; set; }
        public StatusGraph StatusGraph { get; set; }
    }
}

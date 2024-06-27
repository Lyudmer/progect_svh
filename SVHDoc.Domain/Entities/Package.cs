using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace SVHDB.Entities
{
    [Table("packages")]
    public class Package
    {
        [Column("userid")]
        public int UserId { get; set; }

        [Required]
        public User User { get; set; }

        [Key, Column("pid")]
        public int Pid { get; set; }


        [Column("createdate")]
        public DateTime CreateDate { get; set; }

        [Column("modifydate")]
        public DateTime ModifyDate { get; set; }

        [Column("status")]
        public int StatusId { get; set; }

        [Column("UUId"),MaxLength(40)]
        public string UUId { get; set; }

        [Required]
        public Status Status { get; set; }

        public ICollection<Document> Documents { get; set; }
        
        
    }
}
